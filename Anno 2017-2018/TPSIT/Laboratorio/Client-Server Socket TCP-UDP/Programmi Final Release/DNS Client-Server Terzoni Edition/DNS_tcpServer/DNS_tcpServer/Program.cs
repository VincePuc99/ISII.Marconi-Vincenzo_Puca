using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DNS_tcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //data
            string[,] Data = new string[3, 2] { { "c215-011", "192.168.3.11" } , { "c215-012", "192.168.3.12" } , { "c215-013", "192.168.3.13" } };
            //data

            //tools
            bool check = false;
            //tools

            IPAddress ipaServer = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipepLocalEndPoint = new IPEndPoint(ipaServer, 1010);
            byte[] buffer = new byte[65536];
            int intNumBytesRec;
            string strData = "";
            
            Console.WriteLine("<<<<<<<<<<<<< SERVER >>>>>>>>>>>>>");
            Socket sckListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Binding...");
            Thread.Sleep(500);
            sckListener.Bind(ipepLocalEndPoint);

            Console.WriteLine("Open new connection...");
            Thread.Sleep(500);
            sckListener.Listen(2);

            Console.WriteLine("Server is ONLINE");
            Thread.Sleep(500);

            start:
            Socket sckWorker = sckListener.Accept();

            for (; ; ) {
                buffer = new byte[65536];
                try { intNumBytesRec = sckWorker.Receive(buffer); } 
                catch (SocketException) { goto start; }
                strData = Encoding.ASCII.GetString(buffer, 0, intNumBytesRec);

                if (strData == "exit") { goto start; }
                if (strData == "") { continue; }
                if (strData.ToLower() == "getip")
                {
                    buffer = Encoding.ASCII.GetBytes(ipaServer.ToString());
                    sckWorker.Send(buffer);
                }

                else if (strData.ToLower() == "getdn")
                {
                    buffer = Encoding.ASCII.GetBytes("C215-000");
                    sckWorker.Send(buffer);
                }

                else if ((strData.Length >= 5) && (strData.Substring(0, 5).ToLower() == "resdn"))
                {
                    for (int i = 0; i < Data.GetLength(0); i++)
                    {
                        if (strData.Substring(6, 8) == Data[i, 0])
                        {
                            buffer = Encoding.ASCII.GetBytes(Data[i, 1].ToString());
                            sckWorker.Send(buffer);
                            check = true;
                            break;
                        }
                    }

                    if (check == false)
                    {
                        buffer = Encoding.ASCII.GetBytes("IP not found");
                        sckWorker.Send(buffer);
                    }
                }

                else
                {
                    buffer = Encoding.ASCII.GetBytes("Command error");
                    sckWorker.Send(buffer);
                }
            }
        }
    }
}
