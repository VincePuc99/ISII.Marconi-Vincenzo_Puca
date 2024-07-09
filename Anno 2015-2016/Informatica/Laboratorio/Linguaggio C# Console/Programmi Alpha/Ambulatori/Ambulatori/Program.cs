using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ambulatori
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] dati = new string[4,3];
            string [] cognome = new string[3];
            string [] gsett = new string[7];
            int scelta;

            do
            {
                Console.Clear();
                Console.WriteLine("========== Ambulatorio ==========");
                Console.WriteLine("1) Input Medici                  ");
                Console.WriteLine("2) Input Giorni Settimana        ");
                Console.WriteLine("3) Input Ambulatori              ");
                Console.WriteLine("4) Tabellone                     ");
                Console.WriteLine("5) Presenze Medico               ");
                Console.WriteLine("6) Assegna Ambulatorio           ");
                Console.WriteLine("7) Ambulatorio Sottoutilizzato   ");
                Console.WriteLine("=================================");

                Console.Write("Inserisci il codice scelto → ");
                scelta = Convert.ToInt16(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Thread.Sleep(1000);
                        Console.Clear();

                        //input multiplo negli array
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Inserisci i cognomi: ");
                            cognome[i] = Console.ReadLine();                       
                        }
                    
                        Console.WriteLine("Sono stati aggiunti alla lista 3 medici");
                        Console.ReadLine();
                        break;

                    case 2:
                        Thread.Sleep(1000);
                        Console.Clear();

                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write("Inserisci i giorni: ");
                            gsett[i] = Console.ReadLine();
                        }
                        Console.WriteLine("I giorni sono stati aggiunti");
                        Console.ReadLine();

                        break;

                    case 3:

                        Thread.Sleep(1000);
                        Console.Clear();

                        for (int i = 0; i < 3; i++) //gestione righe
                        {
                            for (int j = 0; j < 3; j++) //gestione colonne
                            {
                                Console.Write("il dottor {0} nel giorno {1} occupa l'ambulatorio: ", cognome[i], gsett [j]);
                                dati[i,j] = Console.ReadLine();
                            }
                        }

                        break;

                    case 4:

                        Thread.Sleep(1000);
                        Console.Clear();


                        Console.WriteLine("================================");
                        Console.WriteLine("Tabellone Occupazione Ambulatori");
                        Console.WriteLine("================================");

                        Console.Write("Medico \t");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write("{0}\t",gsett[i]);
                        }
                        Console.WriteLine();

                        for (int i = 0; i < 3; i++) //gestione righe
                        {
                            Console.Write("{0}",cognome[i]);

                            for (int j = 0; j < 8; j++) //gestione colonne
                            {
                                  Console.Write("{0}\t",dati[i,j]);
                            }
                            Console.WriteLine();
                        }

                        Console.ReadLine();
                        break;

                    case 5:

                        string nome;

                        Console.WriteLine("Inserire il cognome del medico da ricercare: ");
                        nome = Console.ReadLine();

                        for (int i = 0; i < cognome.GetLength(0); i++)
                        {
                            if (nome == cognome[i])
                            {
                                Console.WriteLine("Il dott. {0} occupa i seguenti ambulatori: ", nome);

                                for (int j = 0; j < 4; j++)
                                {                                   
                                    Console.WriteLine(dati[i, j]);
                                }
                            }
                        }

                        break;



                }

            } while (true);
        }
    }
}
