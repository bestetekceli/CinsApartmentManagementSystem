using HtmlAgilityPack;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HowToFixMyServer
{
    public partial class CinsAptSvr : Form
    {
        public CinsAptSvr()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            start_Sv();
              }

        private Socket sv_Socket;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private  List<Socket> client_socket_list = new List<Socket>();
  
     
        private void start_Sv()
        {
            try
            {
                sv_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint server_iep = new IPEndPoint(IPAddress.Any, 9050);
                sv_Socket.Bind(server_iep);
                sv_Socket.Listen(9);
                sv_Socket.BeginAccept(new AsyncCallback(sv_AcceptCallback), sv_Socket);
                sv_Weather();
                sv_Currency();
                StartTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The server is already exist at that address.");
                this.Close();
                //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sv_AcceptCallback(IAsyncResult iar)
        {
            Socket org_sv_socket = (Socket)iar.AsyncState;
            Socket new_Socket = org_sv_socket.EndAccept(iar);
            try
            {
                client_socket_list.Add(new_Socket);
                sv_SendUrlInfo();
                sendFirstMessages(new_Socket);
                sendFirstEntry(new_Socket);
                new_Socket.BeginReceive(data, 0, size, SocketFlags.None,
                    new AsyncCallback(sv_ReceiveCallBack), new_Socket);
                sv_Socket.BeginAccept(new AsyncCallback(sv_AcceptCallback), sv_Socket);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Socket creation problem.");
                sv_Socket.BeginAccept(new AsyncCallback(sv_AcceptCallback), sv_Socket);
            }
        }
        private void sv_ReceiveCallBack(IAsyncResult iar)
        {     
            Socket new_Socket = (Socket)iar.AsyncState;
            int rcv;
            if (new_Socket.Connected)
            {
                try
                {
                     rcv = new_Socket.EndReceive(iar);                    
                }
                catch (Exception)
                {

                    for (int i=0; i<client_socket_list.Count; i++)
                    {
                        if (client_socket_list[i].RemoteEndPoint.ToString().Equals(new_Socket.RemoteEndPoint.ToString()))
                        {
                            client_socket_list.RemoveAt(i);
                        }
                    } 
                    return;
                }
                if (rcv != 0)
                {                 
                    string text = Encoding.UTF32.GetString(data,0,rcv);
                    msg_Control_Method(text, new_Socket);
                    new_Socket.BeginReceive(data, 0, size, SocketFlags.None,
                       new AsyncCallback(sv_ReceiveCallBack), new_Socket);

                }
                else if (rcv == 0)
                {
                    new_Socket.Shutdown(SocketShutdown.Both);
                    new_Socket.Close();
                    socketClear(new_Socket);
                    return;
                }
            }
        }
        private void socketClear(Socket socket)
        {
            for (int i = 0; i < client_socket_list.Count; i++)
            {
                if (client_socket_list.ElementAt(i) == socket)
                {
                    client_socket_list.RemoveAt(i);
                }
            }
        }
        private void msg_Control_Method(string text,Socket socket)
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
                    snd_msg_every_client(mainText);
                    lstbx_chat.Items.Add(mainText);
                    break;
                case 3:
                    snd_outer_entry_msg_every_client(mainText);
                    lstbx_entry.Items.Add(mainText);
                    break;       
            }
        }
        private void snd_msg_every_client(string text)
        {
            text = "1|" + text;
            byte[] messagebyte = Encoding.UTF32.GetBytes(text);
               for (int i=0; i<client_socket_list.Count;i++) 
             {
               client_socket_list.ElementAt(i).BeginSend(messagebyte, 0, messagebyte.Length, SocketFlags.None,
                           new AsyncCallback(sv_SendCallBack), client_socket_list.ElementAt(i));
            }    
        }
        private void snd_outer_entry_msg_every_client(string text)
        {
            text = "3|" + text;
            byte[] messagebyte = Encoding.UTF32.GetBytes(text);
            for (int i = 0; i < client_socket_list.Count; i++)
            {
                client_socket_list.ElementAt(i).BeginSend(messagebyte, 0, messagebyte.Length, SocketFlags.None,
                            new AsyncCallback(sv_SendCallBack), client_socket_list.ElementAt(i));
            }
        }
        private void sv_SendCallBack(IAsyncResult iar)
        {
           
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
            client.BeginReceive(data, 0, size, SocketFlags.None,
            new AsyncCallback(sv_ReceiveCallBack), client);

        }
        private string sv_Weather()
        {
            Uri url = new Uri("https://weather.com/en-GB/weather/today/l/ca1734833d25fb15fd8de8c52fae8352c220c7200a6414348b48b4be5bebbead");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            HtmlNode node1 = doc.DocumentNode.SelectSingleNode("//*[@id=\"WxuCurrentConditions-main-b3094163-ef75-4558-8d9a-e35e6b9b1034\"]/div/section/div/div[2]/div[1]/div[1]/span");
            HtmlNode node2 = doc.DocumentNode.SelectSingleNode("//*[@id=\"WxuCurrentConditions-main-b3094163-ef75-4558-8d9a-e35e6b9b1034\"]/div/section/div/div[2]/div[1]/div[1]/div[1]");
            HtmlNode node3 = doc.DocumentNode.SelectSingleNode("//*[@id=\"WxuCurrentConditions-main-b3094163-ef75-4558-8d9a-e35e6b9b1034\"]/div/section/div/div[2]/div[1]/div[1]/div[2]");
            HtmlNode node4 = doc.DocumentNode.SelectSingleNode("//*[@id=\"WxuCurrentConditions-main-b3094163-ef75-4558-8d9a-e35e6b9b1034\"]/div/section/div/div[1]");
            string [] citynode = node4.InnerText.Split(",");
            string city = citynode[0];
            string text = node1.InnerText + "_" + node2.InnerText + "_" + node3.InnerText + "_" + city;

            lbl_CityV.Text = city;
            lbl_degree.Text = node1.InnerText;
            lbl_statusV.Text = node2.InnerText;
            lbl_daynight.Text=node3.InnerText;   
            return text;
        }
        private string sv_Currency()
        {
            string text="_";
            Uri url = new Uri("https://www.doviz.com");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
           
            for(int i=1; i<4; i++)
            {
                    HtmlNode node = doc.DocumentNode.SelectSingleNode("/html/body/header/div[2]/div/div[1]/div[" + i + "]/a/span[2]");
                    text += node.InnerText + "_";                   
            }
            string[] values = text.Split("_");
            lbl_value1.Text=values[1];
            lbl_value2.Text=values[2];
            lbl_value3.Text=values[3];
            return text;          
        }
        private void sv_SendUrlInfo()
        {
            string text= "2|"+sv_Weather()+sv_Currency();
            byte[] messagebyte = Encoding.UTF32.GetBytes(text);
            for (int i = 0; i < client_socket_list.Count; i++)
            {
                client_socket_list.ElementAt(i).BeginSend(messagebyte, 0, messagebyte.Length, SocketFlags.None,
                            new AsyncCallback(sv_SendUrlCallBack), client_socket_list.ElementAt(i));
            }
        }
        private void sv_SendUrlCallBack(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            try
            {
                
                int sent = client.EndSend(iar);
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                socketClear(client);
            }
        }

        private void sendFirstMessages(Socket socket)
        {
            try
            {
                for (int i = 0; i < lstbx_chat.Items.Count; i++)
                {
                    string text = "1|" + lstbx_chat.Items[i].ToString();
                    byte[] messagebyte = Encoding.UTF32.GetBytes(text);
                    socket.BeginSend(messagebyte, 0, messagebyte.Length, SocketFlags.None,
                                new AsyncCallback(sv_SendUrlCallBack), socket);
                    Thread.Sleep(1);
                }
            }catch(Exception ex)
            {
              //  MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sendFirstEntry(Socket socket)
        {
            try
            {
                for (int i = 0; i < lstbx_entry.Items.Count; i++)
                {
                    string text = "3|" + lstbx_entry.Items[i].ToString();
                    byte[] messagebyte = Encoding.UTF32.GetBytes(text);
                    socket.BeginSend(messagebyte, 0, messagebyte.Length, SocketFlags.None,
                                new AsyncCallback(sv_SendUrlCallBack), socket);
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void StartTimer()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                // This is the method that will be called every 5 minutes
                asyncTask().Wait();

                // Reset the timer
                timer.Change(TimeSpan.FromMinutes(5), TimeSpan.FromMilliseconds(-1));
            }, null, TimeSpan.FromMinutes(5), TimeSpan.FromMilliseconds(-1));
        }

        private async Task asyncTask()
        {
            sv_Weather();
            sv_Currency();
            sv_SendUrlInfo();
        }

        // General Control for Form

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
        private void CinsAptSvr_MouseMove(object sender, MouseEventArgs e)
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
        int r = 255, g = 0, b = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(r, g, b);


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