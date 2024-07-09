using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Text;

namespace Client
{
    public partial class frmmain : Form
    {
        public static IPAddress IP = IPAddress.Parse(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
        public static IPEndPoint IPEP = new IPEndPoint(IP, 1007);
        public static Socket SocketConnessione = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static byte[] buffer = new byte[1024];

        public frmmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IPAddress IP = IPAddress.Parse(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
            //IPEndPoint IPEP = new IPEndPoint(IP, 1007);

            //Socket SocketConnessione = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            SocketConnessione.Connect(IPEP);

            label1.Visible = true;
            bttled.BackColor = Color.Green;
            btttentativo.Enabled = false;

            grpcomunicazione.Enabled = true;          
        }

        private void bttinvio_Click(object sender, EventArgs e)
        {
            buffer = Encoding.ASCII.GetBytes(txtcomunicazione.Text);
            SocketConnessione.Send(buffer);
        }
    }
}
