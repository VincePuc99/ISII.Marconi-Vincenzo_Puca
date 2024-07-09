using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Diplomati
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cognome, scelta;
            int voto, a = 0,b = 0;
            string collegamento = @"C:\Users\Vincenzo\Desktop\diplomati.txt";
            StreamWriter scrivi = new StreamWriter(collegamento,false);
            string[] file = new string[4];
            int[] voti = new int[2];

            do
            {
                Console.Clear();
                Console.WriteLine("xxxxxxxxx Gestione diplomati xxxxxxxxx");
                Console.WriteLine("Inserire cognome allievo: ");
                cognome = Console.ReadLine().ToLower();

                Console.WriteLine("Inserire nome allievo: ");
                nome = Console.ReadLine().ToLower();
                do
                {
                    Console.WriteLine("Inserire voto dell' allievo: ");
                    voto = Convert.ToInt32(Console.ReadLine());
                    if (voto < 0 || voto > 110)
                    {
                        Console.WriteLine("Voto non disponibile riprova");
                    }

                } while (voto < 0 || voto > 110);

                scrivi.Write(cognome + " ");
                scrivi.Write(nome + " ");
                scrivi.Write(voto);
                scrivi.WriteLine();

                file[a] = cognome;
                a++;
                file[a] = nome;
                a++;
                voti[b] = voto;
                b++;

                Console.WriteLine("Hai finito? (SI)--(NO)");
                scelta = Console.ReadLine().ToLower();
                if (scelta == "si")
                {
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    scrivi.Close();
                    Thread.Sleep(1500);
                    menu(collegamento, file, voti);                 
                }
            } while (scelta == "no");          
            
        }//fine main

        static void menu(string coll,string[] nominativi,int[] voti)
        {
            do
            {
                Console.Clear();
                int scelta = 0;
                Console.WriteLine("xxxxxxxxx Gestione diplomati xxxxxxxxx");
                Console.WriteLine("1) Visualizzazione elenco");
                Console.WriteLine("2) Cerca allievo");
                Console.WriteLine("3) Visualizza eccellenze");
                Console.WriteLine("4) Elimina Criticità");
                Console.WriteLine("5) Fine programma");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.Write("Inserisci scelta → ");
                scelta = Convert.ToInt16(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        visualizzaelenco(coll, nominativi, voti);
                        break;

                    case 2:
                        ricerca(coll, nominativi, voti);
                        break;

                    case 3:
                        visualizzaeccellenze(coll, nominativi, voti);
                        break;

                    case 4:
                        eliminacriticità(coll, nominativi, voti);
                        break;
                    case 5:
                        return;
                }
            } while (true);
        }//fine menu

        static void visualizzaelenco(string coll,string[] nomi,int[] voti)
        {
            Console.Clear();
                Console.Write(nomi[1] + " ");
                Console.Write(nomi[0] + " ");
                Console.WriteLine("(voto:{0})", voti[0]);

                Console.Write(nomi[3] + " ");
                Console.Write(nomi[2] + " ");
                Console.WriteLine("(voto:{0})", voti[1]);
                Console.ReadKey();
        }

        static void ricerca(string coll, string[] nomi, int[] voti)
        {
            string input;
            Console.Clear();
            Console.Write("Inserire cognome allievo da ricercare: ");
            input = Console.ReadLine().ToLower();

            if (input == nomi[0])
            {
                Console.WriteLine(nomi[0] + " " + nomi[1] + " " + voti[0]);
            }

            if (input == nomi[2])
            {
                Console.WriteLine(nomi[2] + " " + nomi[3] + " " + voti[2]);
            }

            if (input != nomi[0] && input != nomi[2])
            {
                Console.WriteLine("Cognome non presente!");
            }
            Console.ReadKey();
        }

        static void visualizzaeccellenze(string coll, string[] nomi, int[] voti)
        {
            if (voti[0] == 100)
            {
                Console.WriteLine(nomi[0]+ " " + nomi [1]);
            }

            if (voti[1] == 100)
            {
                Console.WriteLine(nomi[2] + " " + nomi[3]);
            }

            if (voti[0] != 100 && voti[1] != 100)
            {
                Console.WriteLine("Nessuna eccellenza");
            }
            Console.ReadKey();
    }//fine eccellenze

        static void eliminacriticità(string coll, string[] nomi, int[] voti)
        {
            StreamWriter scrivi = new StreamWriter(coll, false);
            if (voti[0] < 60 || voti[0] > 100)
            {
                scrivi.WriteLine("1");
            }

            if (voti[1] < 60 || voti[1] > 100)
            {
                scrivi.WriteLine("1");
            }

            scrivi.Close();
            Console.ReadKey();
        }

    }//fine class
}
