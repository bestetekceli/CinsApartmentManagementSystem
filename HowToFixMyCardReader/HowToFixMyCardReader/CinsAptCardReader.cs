using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HowToFixMyCardReader
{
    public partial class CinsAptCardReader : Form
    {
        public CinsAptCardReader()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            comboBoxAptAdder();
            cardReaderStartUp();
        }
        private Socket card_socket;
        private IPEndPoint server_iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        private void cardReaderStartUp()
        {
            try
            {
                card_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);                
                card_socket.BeginConnect(server_iep, new AsyncCallback(card_ConnectCallback), card_socket);

                
            }
            catch (Exception ex)
            {
                //If any extra problem occurs as like socket couldn't open.
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Access_Click(object sender, EventArgs e)
        {
            try
            {
                if (cardReaderEmptyCheck(txt_name.Texts)&&aptno_combobox.Texts.Length!=0)
                {
                    string text = "3|" + txt_name.Texts + " unlock the outer gate of CinsAparment no: " + aptno_combobox.Texts + " at " + date_now();
                    byte[] sendin_data = Encoding.UTF32.GetBytes(text);
                    card_socket.BeginSend(sendin_data, 0, sendin_data.Length, SocketFlags.None,
                        new AsyncCallback(card_SendCallBack), card_socket);
                }
                else if (aptno_combobox.Texts.Length==0)
                {
                    MessageBox.Show("Choose an apt no!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void card_ConnectCallback(IAsyncResult iar)
        {
            card_socket = (Socket)iar.AsyncState;
            try
            {
                card_socket.EndConnect(iar);
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no accessable server.\r\n Try to reconnect in 5 sec. after closing this message.");
                //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                recconAttempts();
            }
        }
        private void recconAttempts()
        {
            try
            {
                Thread.Sleep(5000);
                card_socket.BeginConnect(server_iep, new AsyncCallback(card_ConnectCallback), card_socket);
            }
            catch (Exception ex)
            {   //If any extra problem occurs as like socket couldn't connect.
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void card_SendCallBack(IAsyncResult iar)
        {
            try
            {
                card_socket.EndSend(iar);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server Lost");
                //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                card_socket.Shutdown(SocketShutdown.Both);
                card_socket.Close();
                cardReaderStartUp();
            }
        }
    // Control the card reader is empty or not.
        private Boolean cardReaderEmptyCheck(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(text+" can not be empty. ");
                return false;
            }
            else if (text.Length < 3 || text.Length > 25)
            {
                MessageBox.Show(text+ " must contain at least 3 and no more than 25 characters.");
                return false;
            }
            else
            {
                return true;
            }
        }

        // Gets the current date. 
        private string date_now() { 
            DateTime now = DateTime.Now;
            string date_now = "";
            date_now = now.ToString(" dd-MM-yyyy HH:mm");
            return date_now; 
        }
        // Fill the apt no text into the combobox.
        private void comboBoxAptAdder()
        {
            for (int i = 1; i < 9; i++)
            {
                aptno_combobox.Items.Add(i.ToString());
            }
        }

        // General controls of the form 
        private void altoButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void altoButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private bool mouseDown;
        private Point lastLocation;
        private void CinsAptOuterGate_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void CinsAptOuterGate_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void CinsAptOuterGate_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
       
    }   
}