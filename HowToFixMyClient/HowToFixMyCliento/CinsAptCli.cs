using System.Net.Sockets;
using System.Net.WebSockets;
using System.Net;
using System.Text;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace HowToFixMyCliento
{
    public partial class CinsAptCli : Form
    {
        public CinsAptCli()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;            
        }
        private Socket new_Socket;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private Boolean isConnected = false;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected || new_Socket == null)
            {
                if (clientNameCheck(textsToText(txt_cliName.Texts)))
                {
                    try
                    {
                        new_Socket = new Socket(AddressFamily.InterNetwork,
                                                SocketType.Stream, ProtocolType.Tcp);
                        IPEndPoint server_iep = new IPEndPoint
                                              (IPAddress.Parse("127.0.0.1"), 9050);
                        new_Socket.BeginConnect(server_iep, 
                                   new AsyncCallback(cli_ConnectCallback), new_Socket);
                        isConnected = true;
                        online_btn.Checked= true;
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, 
                      Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                } 
            }
            else
            {
                if (new_Socket.Connected && new_Socket!=null)
                {
                    MessageBox.Show("Already Connected.");
                }
                else
                {
                    MessageBox.Show("Server lost.");
                    isConnected = false;
                    txt_cliName.Enabled = true;
                    online_btn.Checked = false;
                }
            } 
        }
        private void cli_ConnectCallback(IAsyncResult iar)
        {
            new_Socket = (Socket)iar.AsyncState;
            try
            {
                new_Socket.EndConnect(iar);
                lstbx_Chat.Items.Clear();
                lstbx_OuterGate.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server could not find. ");
             // MessageBox.Show(ex.Message, Application.ProductName,
             // MessageBoxButtons.OK, MessageBoxIcon.Error);
                isConnected = false;
                online_btn.Checked = false;
                txt_cliName.Enabled = true;

            }
            new_Socket.BeginReceive(data, 0, data.Length, SocketFlags.None,
                       new AsyncCallback(cli_ReceiveCallBack), new_Socket);
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string sendin_text = "1|" + textsToText(txt_cliName.Texts) + " :  " + textsToText(txt_MessageText.Texts);
                byte[] sendin_data = Encoding.UTF32.GetBytes(sendin_text);
                new_Socket.BeginSend(sendin_data, 0, sendin_data.Length, SocketFlags.None,
                    new AsyncCallback(cli_SendCallBack), new_Socket);
                txt_MessageText.Texts = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection needed for send message.");
                //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cli_SendCallBack(IAsyncResult iar)
        {
            try
            {
                new_Socket.EndSend(iar);
            }
            catch (Exception ex)
            {
                if (!isConnected) 
                {
                    MessageBox.Show("Not Connected!");
                }
           // MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void cli_ReceiveCallBack(IAsyncResult iar)
        {
            Socket rmt = (Socket)iar.AsyncState;
            try
            {
                byte[] datas = new byte[1024];
                int rcv = rmt.EndReceive(iar);
                string stringData = Encoding.UTF32.GetString(data, 0, rcv);
                OrWhich(stringData);
                new_Socket.BeginReceive(data, 0, data.Length, SocketFlags.None,
                   new AsyncCallback(cli_ReceiveCallBack), new_Socket);
            }
            catch (SocketException)
            {
                if (isConnected) {
                    MessageBox.Show("Server Connection Lost");
                    isConnected = false;
                    txt_cliName.Enabled = true;
                    online_btn.Checked = false;
                    new_Socket.Shutdown(SocketShutdown.Both);
                    new_Socket.Close();
                    new_Socket = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disconnected");
                txt_cliName.Enabled = true;
                online_btn.Checked= false;

               // MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrWhich(string text)
        {
            string type = "";
            string mainText = "";
            for (int i = 0; i < 2; i++)
            {
                type = text.Substring(0, 1);
                mainText = text.Substring(2);
            }
            switch (Int32.Parse(type))
            {
                case 1:
                    lstbx_Chat.Items.Add(mainText); // 1| message
                    break;

                case 2:
                    placeHolder(mainText);  // 2| weather/currency
                    break;
                case 3:
                    lstbx_OuterGate.Items.Add(mainText);  // 3| outer-gate
                    break;
            }

        }
        private void placeHolder(string stringData)
        {
            string[] data = stringData.Split('_');
            lbl_city.Text = data[3];
            lbl_degree.Text = data[0];
            lbl_Status.Text = data[1];
            lbl_daynigt.Text = data[2];
            lbl_goldV.Text = data[4];
            lbl_dolarV.Text = data[5];
            lbl_euroV.Text = data[6];
          
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (new_Socket!=null)
                {
                    new_Socket.Shutdown(SocketShutdown.Both);
                    new_Socket.Close();
                    new_Socket = null;
                    isConnected = false;
                    online_btn.Checked = false;
                    txt_cliName.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Already disconnected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already disconnected.");
                //   MessageBox.Show(ex.Message, Application.ProductName,
                //   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Boolean clientNameCheck(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Client name cannot be left blank!");
                return false;
            }
            else if (text.Length < 3 || text.Length > 25)
            {
                MessageBox.Show("Client name must contain " +
                           "at least 3 and no more than 25 characters.");
                return false;
            }
            else
            {
                txt_cliName.Enabled = false;
                return true;
                
            }
        }

        // General control methods for  CinsAptCli Form
        private void altoButton1_Click(object sender, EventArgs e) //close_button

        {
            if (new_Socket!= null && new_Socket.Connected)
            {
                new_Socket.Shutdown(SocketShutdown.Both);
                new_Socket.Close();
                this.Close();
            }
            else
            {
                this.Close();
            }
            
        }

        private void altoButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int r = 255, g = 0 , b = 0;

        private bool mouseDown;
        private Point lastLocation;

        private void CinsAptCli_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void CinsAptCli_MouseUp(object sender, MouseEventArgs e)
        {
           
                mouseDown = false;
            
        }

        private void CinsAptCli_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        
        private string  textsToText(string texts)
        {
            string text = texts;
            return text;
        }
        
        // it makes to title RGB 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_title.ForeColor= Color.FromArgb(r, g, b); 
            
            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;

            }
        }
    }
}
