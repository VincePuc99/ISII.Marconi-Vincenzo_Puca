using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {   //area dati 
            string IPLocale = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            byte[] buffer = new byte[1024];
            int bytericevuti = 0;
            string oracorrente = "00:00", datiricevuti= "";
            //inizio programma
            try//try che risolve qualsiasi eccezione
            {
                IPAddress IP = IPAddress.Parse(IPLocale);//area di creazione socket
                IPEndPoint IPEP = new IPEndPoint(IP, 1010);

                Socket SocketAscolto = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                SocketAscolto.Bind(IPEP);

                Console.WriteLine("<<<<<<<<<<<<<< Server >>>>>>>>>>>>>>");
                Console.WriteLine("Timer Server in esecuzione e in ascolto...");

                SocketAscolto.Listen(2);

                Socket SocketLavoro = SocketAscolto.Accept();
                Console.WriteLine("Connessione riuscita e Server pronto");
                //fine creazione socket con connessione effettuata
                for (; ;)
                {
                    buffer = new byte[1024];
                    bytericevuti = SocketLavoro.Receive(buffer);
                    datiricevuti = Encoding.ASCII.GetString(buffer, 0, bytericevuti);

                    //buffer = new byte[1024];   in verifica spostare questa riga da 41 a 37

                    //valuto il comando ricevuto
                    if (datiricevuti == "get")
                    {
                        buffer = Encoding.ASCII.GetBytes(oracorrente);
                        SocketLavoro.Send(buffer);
                        Console.WriteLine("Ora Corrente inviata correttamente");
                    }
                    else if (datiricevuti == "exit")
                    {   //chiusura del server
                        Console.WriteLine("Chiusura in corso...");
                        Thread.Sleep(2000);

                        SocketAscolto.Close();
                        SocketLavoro.Close();
                        break;
                    }
                    else if(datiricevuti.Substring(0,3) == "set") //set per modifica dell'ora
                    {
                   
                        oracorrente = datiricevuti.Substring(4,5);
                        buffer = Encoding.ASCII.GetBytes(oracorrente);
                        SocketLavoro.Send(buffer);
                        Console.WriteLine("Ora Modificata Correttamente");
                    }
                    else
                    {
                        buffer = Encoding.ASCII.GetBytes("Error");
                        SocketLavoro.Send(buffer);
                        Console.WriteLine("Comando errato");
                    }

                }//fine for

                Console.WriteLine("Server Chiuso correttamente.");
                Console.WriteLine("<<<<<<<<<<<<<< END Server >>>>>>>>>>>>>>");

            }//fine try
            catch { Console.WriteLine("Fatal error closing..."); }//messaggio in caso di errore

        }//fine main
    }
}
