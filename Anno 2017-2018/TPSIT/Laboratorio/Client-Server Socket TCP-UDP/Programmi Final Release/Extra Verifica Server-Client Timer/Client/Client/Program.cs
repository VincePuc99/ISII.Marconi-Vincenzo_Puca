using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //area dati
            string IPLocale = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString(); //reperisce l'ip locale in modo dinamico
            byte[] buffer = new byte[1024]; //istanzio un buffer
            int bytericevuti = 0;
            string datiricevuti = "";
            string inpututente;
            //programma
            try //try che risolve qualsiasi eccezione
            {
                Console.WriteLine("<<<<<<<<<<<<<< Client >>>>>>>>>>>>>>"); //area di creazione socket
                IPAddress IP = IPAddress.Parse(IPLocale);
                IPEndPoint IPEP = new IPEndPoint(IP, 1010);

                Socket SocketAscolto = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                SocketAscolto.Connect(IPEP);
                Console.WriteLine("Connessione effettuata con successo");
                //fine creazione socket con connessione effettuata
                for (; ;)
                {
                    Console.WriteLine("Inserire comando (vedi manuale): ");
                    inpututente = Console.ReadLine();

                    buffer = Encoding.ASCII.GetBytes(inpututente); //invio input
                    SocketAscolto.Send(buffer);

                    if (inpututente == "exit") //controllo se richiesta uscita
                    { break; }

                    buffer = new byte[1024];

                    if (inpututente.Substring(0, 3) != "set") //controllo se comando inserito non è set
                    {                  
                        bytericevuti = SocketAscolto.Receive(buffer); //ricevo cosa ho richiesto in precedenza(anche errori)
                        datiricevuti = Encoding.ASCII.GetString(buffer, 0, bytericevuti); //converto i dati

                        Console.WriteLine("Risposta a comando {0}: {1}", inpututente, datiricevuti);
                    }
                    else
                    {
                        bytericevuti = SocketAscolto.Receive(buffer);
                        datiricevuti = Encoding.ASCII.GetString(buffer, 0, bytericevuti);

                        Console.WriteLine("Ora modificata in {0}",datiricevuti);
                    }
                
                }//fine for
                //chiusura client
                Console.WriteLine("Chiusura in corso...");
                Thread.Sleep(2000);

                SocketAscolto.Close();
                Console.WriteLine("Client chiuso correttamente");
                Console.WriteLine("<<<<<<<<<<<<<< END Client >>>>>>>>>>>>>>");
            }//fine try
            catch { Console.WriteLine("Fatal Error Closing..."); } //messaggio in caso di errore
        }
    }
}
