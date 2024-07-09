using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Text;


namespace Server
{
    public partial class frmmain : Form
    {
        public static byte[] buffer = new byte[1024];
        public static IPAddress IP = IPAddress.Parse(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
        public static IPEndPoint IPEP = new IPEndPoint(IP, 1007);
        public static Socket SocketAscolto = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static Socket SocketLavoro = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public frmmain()
        {
            InitializeComponent();
        }

        private void btttentativo_Click(object sender, EventArgs e)
        { 
            //IPAddress IP = IPAddress.Parse(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
            //IPEndPoint IPEP = new IPEndPoint(IP, 1007);

            //Socket SocketAscolto = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            SocketAscolto.Bind(IPEP);

            SocketAscolto.Listen(2);
            SocketLavoro = SocketAscolto.Accept();
            
            label1.Visible = true;
            bttled.BackColor = Color.Green;
            btttentativo.Enabled = false;

            grpcomunicazione.Enabled = true;
        }

        private void bttinvio_Click(object sender, EventArgs e)
        {
            SocketLavoro.Receive(buffer);
            string ricevuto = Encoding.ASCII.GetString(buffer);
            txtcomunicazione.Text = ricevuto;
            Array.Clear(buffer, 0, buffer.Length);

        }
    }
}
