using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Ufficio_vendite
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, scelta = 0;
            double tot = 0;
            string[] listaordini = new string[4];
            string [] listaclienti = new string[6];
            string collegamentoclienti = @"C:\Users\M_INF2.terza\Desktop\clienti.txt";
            string collegamentoordini = @"C:\Users\M_INF2.terza\Desktop\ordini.txt";
            try
            {
               
                do
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("====== MENU ======");
                    Console.WriteLine("1)Visualizzazione elenco completo clienti");
                    Console.WriteLine("2)Dato un cognome viengono visualizzate le informazioni");
                    Console.WriteLine("3)Dato un importo e una data di un ordine vengono visualizzate le informazioni");
                    Console.WriteLine("4)Per ogni cliente determinare il numero complessivo di ordini");
                    Console.WriteLine("5)Dato un cognome visualizzare l'importo complessivo di ordini");
                    Console.WriteLine("==================");
                    do
                    {
                        Console.Write("Inserire scelta desiderata → ");
                        scelta = Convert.ToInt16(Console.ReadLine());
                        if (scelta < 1 || scelta > 5)
                        {
                            Console.WriteLine("Comando non esatto");
                        }
                    } while (scelta < 1 || scelta > 5);
                    Console.Clear();
                    switch (scelta)
                    {
                        case 1:
                            StreamReader leggi = new StreamReader(collegamentoclienti);
                            Console.WriteLine(leggi.ReadToEnd());
                            leggi.Close();
                            break;
                        case 2:
                            Console.Write("Inserire cognome ricercato: ");
                            string cognome = Console.ReadLine().ToLower();
                            StreamReader leggi1 = new StreamReader(collegamentoclienti);
                            for (int i = 0; i < listaclienti.GetLength(0); i++)
                            {
                                listaclienti[i] = leggi1.ReadLine();
                            }

                            if (listaclienti[2] == cognome)
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    if (i != 2)
                                    {
                                        Console.WriteLine(listaclienti[i]);
                                    }
                                    else
                                        Console.WriteLine();
                                }
                            }
                            else
                                Console.WriteLine("Cognome non trovato");

                            leggi1.Close();
                            break;
                        case 3:
                            Console.Write("Inserire data: ");
                            string data = Console.ReadLine().ToLower();
                            Console.Write("Inserire importo: ");
                            int importo = Convert.ToInt16(Console.ReadLine());
                            StreamReader leggi2 = new StreamReader(collegamentoordini);
                            for (int i = 0; i < listaordini.GetLength(0); i++)
                            {
                                listaordini[i] = leggi2.ReadLine();
                            }
                            double conversione = Convert.ToDouble(listaordini[3]);
                            if (listaordini[2] == data && conversione > importo)
                            {
                                for (int i = 0; i < listaordini.GetLength(0); i++)
                                {
                                    Console.WriteLine(listaordini[i]);
                                }
                            }
                            leggi2.Close();
                            break;
                        case 4:
                            StreamReader leggi3 = new StreamReader(collegamentoordini);
                            for (int i = 0; i < listaordini.GetLength(0); i++)
                            {
                                listaordini[i] = leggi3.ReadLine();
                            }
                            Console.WriteLine("Inserire ID scelto → ");
                            int id = Convert.ToInt16(Console.ReadLine());
                            double conversione1 = Convert.ToDouble(listaordini[1]);
                            if (id == conversione1)
                            {
                                cont++;
                            }
                            Console.WriteLine("Ordini effettuati totali: {0}", cont);
                            leggi3.Close();
                            break;
                        case 5:
                            StreamReader leggi4 = new StreamReader(collegamentoordini);
                            for (int i = 0; i < listaordini.GetLength(0); i++)
                            {
                                listaordini[i] = leggi4.ReadLine();
                            }
                            Console.WriteLine("Inserire ID scelto →");
                            int id1 = Convert.ToInt16(Console.ReadLine());
                            double conversione2 = Convert.ToDouble(listaordini[1]);
                            double conversione3 = Convert.ToDouble(listaordini[3]);
                            if (id1 == conversione2)
                            {
                                tot += conversione3;
                            }
                            Console.WriteLine("TOtale ordini {0}", tot);
                            break;
                    }
                } while (true);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File non trovato");
            }
            finally
            {
                Console.WriteLine("Fine programma");
            }
        }
    }
}
