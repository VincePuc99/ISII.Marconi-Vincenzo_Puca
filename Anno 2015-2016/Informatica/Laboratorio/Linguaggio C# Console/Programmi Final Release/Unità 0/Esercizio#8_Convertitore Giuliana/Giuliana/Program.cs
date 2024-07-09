using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuliana
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            string riavvio;

            restartx:
            Console.WriteLine("Formato Giuliana --> Gregoriano.");
            Console.Write("Inserire una data Giuliana da 1 a 365 (Inserire solo i valori 1/43/365 ): ");
            data = Convert.ToInt32(Console.ReadLine());
            //condizioni di esistenza
            if (data > 365)
            {
                Console.WriteLine("Valore non consentito,Riprova!");
                goto restart;
            }

            if (data < 1)
            {
                Console.WriteLine("Valore non consentito,Riprova!");
                goto restart;
            }
            //Giuliana
            if (data == 43)
            {
                Console.WriteLine("Data Gregoriana = 12 febbraio 2015");
                goto restart;
            }

            if (data == 1)
            {
                Console.WriteLine("Data Gregoriana = 1 gennaio 2015");
                goto restart;
            }
            if (data == 365)
            {
                Console.WriteLine("Data Gregoriana = 31 dicembre 2015");
                goto restart;
            }
            Console.WriteLine("Valore non salvato...");
            //cambio
            restart:
            Console.Write("\nVuoi riprovare (SI)--(NO),Passerai al Gregoriano:  ");
            riavvio = Console.ReadLine();

            if (riavvio.ToUpper() == "NO")
            {
                goto gregorian;
            }
            if (riavvio.ToUpper() == "SI")
            {
                Console.WriteLine("\n----------------------------------------");
                goto restartx;
            }

            //gregoriana

            gregorian:
            int giorno;
            int mese;
            //Input

            Console.WriteLine("Formato Gregoriano --> Giuliana.");

            Console.Write("Inserisci il giorno,valori(1-31): ");
            giorno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il mese (in numero)valori(1-12): ");
            mese = Convert.ToInt32(Console.ReadLine());

            //Elaborazione
            if (giorno > 0 || giorno < 365)
            {
                if (mese > 0 || mese < 12)
                {
                    if (giorno == 1)
                        if (mese == 1)
                        {
                            Console.WriteLine("Equivale al giorno 1 Giuliana");
                        }

                    if (giorno == 31)
                        if (mese == 12)
                        {
                            Console.WriteLine("Equivale al giorno 365 Giuliana");
                        }

                }
            }
            //output
            Console.Write("Programma terminato!");
            Console.ReadKey();
        }
    }
}
