using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Server2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            ConnectBTN.Enabled = false;
            Socket newsock, client;
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);
            InfoTxt.Text += "Waiting for a client...\n";
            client = newsock.Accept();
            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            client.Send(data, data.Length, SocketFlags.None);
            while (true)
            {
                data = new byte[1024];
                recv = client.Receive(data);
                if (recv == 0)
                    break;
                string Info = Encoding.ASCII.GetString(data, 0, recv) + "\n";
                InfoTxt.Text += Info;
                client.Send(data, recv, SocketFlags.None);
            }
            InfoTxt.Text += "Disconnected from " + clientep.Address;
            newsock.Close();
            client.Close();
            ConnectBTN.Enabled = true;
        }
    }
}