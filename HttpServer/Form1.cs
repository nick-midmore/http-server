using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HttpServer
{
    public partial class Form1 : Form
    {

        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopServerBtn.Enabled = false;
        }

        private void startServerBtn_Click(object sender, EventArgs e)
        {
            serverLogsText.Text = "";

            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort = int.Parse(serverPortText.Text);

                    if(serverPort > 65535 || serverPort < 0)
                    {
                        throw new Exception("Server port not within valid range");
                    }
                }
                catch(Exception ex)
                {
                    serverLogsText.Text = "Failed to start server on specified port\r\n";
                }

                thread = new Thread(new ThreadStart(this.ConnectionThread));
                thread.Start();

                startServerBtn.Enabled = false;
                stopServerBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                serverLogsText.Text = "Failed to start server\r\n";
            }

            serverLogsText.Text = "Server started...\r\n";
        }

        private void stopServerBtn_Click(object sender, EventArgs e)
        {
            serverLogsText.Text += "Server stopping...\r\n";
            try
            {
                httpServer.Close();

                thread.Abort();

                startServerBtn.Enabled = true;
                stopServerBtn.Enabled = false;
                serverLogsText.Text += "Server stopped.\r\n";
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not stop the server");
            }
        }

        private void ConnectionThread()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endpoint);
                httpServer.Listen(1);
                StartListeningForConnection();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not start");
            }
        }

        private void StartListeningForConnection()
        {
            while (true)
            {
                DateTime time = DateTime.Now;

                string data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept();

                while(true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                serverLogsText.Invoke((MethodInvoker)delegate {
                    serverLogsText.Text += "\r\n\r\n";
                    serverLogsText.Text += data;
                    serverLogsText.Text += "\n\n -------- End of request --------\r\n";
                });

                String resHeader = "HTTP/1.1 200 Ok\nServer: my_http_server\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = "<!DOCTYPE html> " +
                    "<html><head><title>My Server</title></head>" +
                    "<body>" +
                    "<h4>Server Time: " + time.ToString() + "</h4>" +
                    "</body></html>";
                String resStr = resHeader + resBody;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();
            }
        }
    }
}
