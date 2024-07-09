using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace File_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            string collegamento = @"C:\Users\Vincenzo\Desktop\file.txt";
            string[] doc = new string[6];
            do
            {
                Console.Clear();
                Console.WriteLine("======== MENU =========");
                Console.WriteLine("1) Visualizzazione");
                Console.WriteLine("2) Visualizzazione per data");
                Console.WriteLine("3) Visualizzazione per luogo");
                Console.WriteLine("4) Temperatura media in data");
                Console.WriteLine("5) Temperatura media per città");
                Console.WriteLine("6) Temperatura media per città/data");
                Console.WriteLine("7) Registrazione");
                Console.WriteLine("8) Cancellazione");
                Console.WriteLine("=======================");
                do
                {
                    Console.Write("Inserire scelta desiderata → ");
                    scelta = Convert.ToInt16(Console.ReadLine());
                    if (scelta < 1 || scelta > 8)
                    {
                        Console.WriteLine("Scelta non disponibile riprova");
                    }
                } while (scelta < 1 || scelta > 8);
                switch (scelta)
                {
                    case 1:
                        Console.Clear();
                        StreamReader sr = new StreamReader(collegamento);
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(sr.ReadToEnd());
                        }
                        sr.Close();
                        break;
                    case 2:
                        Console.Write("Inserire data per la ricerca → ");
                        string ricercadata = Console.ReadLine().ToLower();
                        StreamReader sr1 = new StreamReader(collegamento);
                        for (int i = 0; i < 6; i++)
                        {
                            doc[i] = sr1.ReadLine();                   
                        }

                        for (int i = 0; i < 6; i++)
                        {   
                            if (ricercadata == (doc[i].Substring(0, 10)))
                            {
                                Console.WriteLine(doc[i]);
                            }
                        }
                        sr1.Close();
                        break;
                    case 3:
                        Console.Write("Inserire luogo per la ricerca → ");
                        string ricercaluogo = Console.ReadLine().ToLower();
                        StreamReader sr2 = new StreamReader(collegamento);
                        for (int i = 0; i < 6; i++)
                        {
                            doc[i] = sr2.ReadLine();                   
                        }
                        
                        for (int i = 0; i < 6; i++)
                        {
                            int fine = doc[i].Length;
                            fine--;
                            if (ricercaluogo == doc[i].Substring(19,fine))
                             {
                              Console.WriteLine(doc[i]);
                             }
                         }
                        
                  
                        break;
                }
            } while (true);
        }
    }
}
