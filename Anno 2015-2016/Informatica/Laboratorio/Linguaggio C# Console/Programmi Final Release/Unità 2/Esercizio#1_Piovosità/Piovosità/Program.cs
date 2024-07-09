using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Piovosità
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabili
            string dati = "@01/01/2011@5@02/01/2011@0@04/01/2011@8@06/01/2011@2";
            //string dati = "@01/01/2011@5@02/01/2011@3@";
            bool stampa = false;
            int piovosita = 0;
            int maxpiov = 0;

            //input

            //Console.Write("Inserire la stringa dei dati: ");
            //dati = Console.ReadLine();

            //elaborazione variabili
            for (int i = 0; i < dati.Length; i++)

            {

                if (dati[i] == '@')
                {
                    if (stampa == false)
                    {
                        stampa = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("   {0}   ", dati [i+1] ); // non va messo i++
                        piovosita += Convert.ToInt32(dati[i+1].ToString()); //trasformo il carateere nella stringa e la stringa la converto in int
                        if (Convert.ToInt32(dati[i + 1].ToString())>maxpiov)
                        {
                            maxpiov = Convert.ToInt32(dati[i + 1].ToString());
                        }
                        if (Convert.ToInt32(dati[i + 1].ToString()) == 0)
                        {
                            Console.WriteLine("Data in cui non è piovuto {0}", dati.Substring(i-10 , 10));
                        }
                        Console.WriteLine();
                        stampa = false;
                    }
                }

                if (stampa == true)
                {
                    Console.Write("{0}", dati[i]);  //dati di i 
                }         
            }

            //visualizzo piovosità tot
            Console.WriteLine("Piovosità totale: {0}", piovosita);

            //visualizzo piovosità max
            Console.WriteLine("Piovosità massima: {0}", maxpiov);

            //output



        }
    }
}
