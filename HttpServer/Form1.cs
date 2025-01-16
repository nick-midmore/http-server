using System;
using System.Net;
using System.Net.Sockets;
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
                    serverLogsText.Text = "Failed to start server on specified port";
                }

                thread = new Thread(new ThreadStart(this.ConnectionThread));
                thread.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                serverLogsText.Text = "Failed to start server";
            }

            serverLogsText.Text = "Server started...";
        }

        private void stopServerBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionThread()
        {

        }

        private void StartListeningForConnection()
        {
            while (true)
            {

            }
        }
    }
}
