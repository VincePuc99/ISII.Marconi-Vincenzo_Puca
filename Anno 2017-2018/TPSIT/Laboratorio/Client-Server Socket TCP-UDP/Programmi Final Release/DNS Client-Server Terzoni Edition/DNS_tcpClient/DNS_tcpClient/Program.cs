using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DNS_tcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipaServer = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipepRemoteEndPoint = new IPEndPoint(ipaServer, 1010);
            byte[] buffer = new byte[65536];
            int intNumBytesRec;
            string strData = "";

            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("<<<<<<<<<<<<< CLIENT >>>>>>>>>>>>>");

            sckClient.Connect(ipepRemoteEndPoint);

            for (; ; )
            {
                Console.WriteLine("Request:");
                strData = Console.ReadLine();
                if (strData == "exit") { break; }
                else
                {
                    buffer = System.Text.Encoding.ASCII.GetBytes(strData);
                    sckClient.Send(buffer);

                    buffer = new byte[65536];
                    intNumBytesRec = sckClient.Receive(buffer);
                    strData = System.Text.Encoding.ASCII.GetString(buffer, 0, intNumBytesRec);

                    Console.WriteLine(strData);
                    Console.WriteLine();
                }
            }

            buffer = System.Text.Encoding.ASCII.GetBytes(strData);
            sckClient.Send(buffer);
            sckClient.Close();
        }
    }
}
