using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] supermerc = new string[] { "spesapiù", "risparmia", "spendibene" };
            //string[] cibo = new string[] { "pane", "pasta", "latte", "uova" };
            //double[,] costi = new double[,] {{ 0.50, 0.65, 0.45, 0.30},
            //                                {  0.75, 0.80, 0.38, 0.25},
            //                                {  0.65, 0.95, 0.40, 0.15}};

            string[] supermerc = new string[3];
            string[] cibo = new string[4];
            double[,] costi = new double[3, 4];

            input(supermerc, cibo, costi);     
           
        }
        static void input(string[] s, string[] ci, double[,] co)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome supermercato: ");
                s[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Nome prodotto: ");
                ci[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    do
                    {
                        Console.WriteLine("Costo {0} nel supermercato {1}: ", ci[j], s[i]);
                        co[i, j] = Convert.ToDouble(Console.ReadLine());

                        if (co[i, j] < 0 || co[i, j] > 1)
                        {
                            Console.WriteLine("Prezzo non consentito riprova!");
                        }
                    } while (co[i, j] < 0 || co[i, j] > 1);
                }
            }

            menu(s, ci, co);     
        }

        static void menu(string[] s, string[] ci, double[,] co)
        {
            Console.Clear();
            int scelta;
            Console.WriteLine("===== Gestione Supermercati =====");
            Console.WriteLine("1) Tabella comparativa");
            Console.WriteLine("2) Modifica costo di un prodotto");
            Console.WriteLine("3) Miglior supermercato per prodotto scelto");
            Console.WriteLine("4) Miglior supermercato in media");
            Console.WriteLine("================================");
            do
            {
                Console.Write("Opzione scelta → ");
                scelta = Convert.ToInt16(Console.ReadLine());
                if (scelta < 1 || scelta > 7)
                {
                    Console.WriteLine("Scelta inesistente");
                }
            } while (scelta < 1 || scelta > 7);
            Console.Clear();

            switch (scelta)
            { 
                case 1:
                    tabella(s, ci, co);
                    break;
                case 2:
                    modificacosto(s, ci, co);
                    break;
                case 3:
                    migliorsupermprod(s, ci, co);
                    break;
                case 4:
                    migliorsupermedia(s, ci, co);
                    break;
            
            }
        }

        static void tabella(string[] s, string[] ci, double[,] co)
        {
            Console.Write("Supermercato\t");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t", ci[i]);
            }

            Console.WriteLine();

            int salto = 0;
            int contaggio = 0;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0}\t", s[i]);
                    Console.Write("{0}\t", co[contaggio, salto]);
                    salto++;
                    Console.Write("{0}\t", co[contaggio, salto]);
                    salto++;
                    Console.Write("{0}\t", co[contaggio, salto]);
                    salto++;
                    Console.Write("{0}\t", co[contaggio, salto]);
                    salto = 0;
                    contaggio++;
                    Console.WriteLine();
                }
            } while (contaggio == 12);
            Console.ReadKey();
        }

        static void modificacosto(string[] s, string[] ci, double[,] co)
        {
            Console.Clear();
            Console.Write("Inserisci nome prodotto: ");
            string nomeprod = Console.ReadLine().ToLower();
            Console.Write("Inserisci nome supermercato: ");
            string nomesuperm = Console.ReadLine().ToLower();

            for (int i = 0; i < 4; i++)
            {
                if (ci[i] == nomeprod)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (s[j] == nomesuperm)
                        {
                            Console.Write("Inserire nuovo costo: ");
                            int nuovocost = Convert.ToInt16(Console.ReadLine());
                            co[j,i] = nuovocost;
                            Console.WriteLine("Cambiato con usccesso!!");
                            return;
                        }
                    
                    }

                }
            }///fine for
        }//fine void

        static void migliorsupermprod (string[] s, string[] ci, double[,] co)
        {
            double scatola, scatola1 = 0.9;
            int var = 0;
            Console.Write("Inserisci nome prodotto: ");
            string nomeprod = Console.ReadLine().ToLower();

            for (int i = 0; i < 4; i++)
            {
                if (nomeprod == ci[i])
                {
                    for (int j = 0; j < 3; j++)
                    {
                        scatola = co[j, i];
                        if (scatola < scatola1)
                        {
                          scatola1 = scatola;
                          var = j;
                        }                       
                    }
                }                         
            }
        
            Console.WriteLine("Prezzo migliore:{0} in: {1}",scatola1,s[var]);
        }//fine void

        static void migliorsupermedia(string[] s, string[] ci, double[,] co)
        {
            double tot = 0, tot1 = 0;
            double[] salvataggio = new double[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tot += co[i, j];
                }

                tot1 = tot / 4;
                salvataggio[i] = tot1;
                tot1 = 0;
                tot = 0;
            }

            double container = 0, container1 = 1;
            int var = 0;
            for (int i = 0; i < 3; i++)
            {
                container = salvataggio[i];
                if (container < container1)
                {
                    container1 = container;
                    var = i;
                }          
            }
            Console.WriteLine("Media Migliore {0} nel supermercato {1}",container1,s[var]);
        }//fine void


    }
}
