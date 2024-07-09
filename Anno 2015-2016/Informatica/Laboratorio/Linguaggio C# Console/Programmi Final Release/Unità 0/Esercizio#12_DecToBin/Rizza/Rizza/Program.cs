using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabili
            int valore;
            int resto1, resto2, resto3, resto4, resto5, resto6, resto7, resto8;
            int risultato1, risultato2, risultato3, risultato4, risultato5, risultato6, risultato7, risultato8;

            //Input

            Console.WriteLine("\n-------------------------------------------\n");
            do
            {
                do
                {
                    
                    Console.Write("Inserire il valore decimale da convertire: ");
                    valore = Convert.ToInt32(Console.ReadLine());

                    if (valore < 0 || valore > 255)
                    {
                        Console.WriteLine("\n   Non va bene questo numero! Inserisci un'altro numero.    \n");
                        Console.WriteLine("----------------------\n");
                    }

                } while (valore < 0 || valore > 255);

                risultato1 = valore / 2;
                resto1 = valore % 2;

                risultato2 = risultato1 / 2;
                resto2 = risultato1 % 2;

                risultato3 = risultato2 / 2;
                resto3 = risultato2 % 2;

                risultato4 = risultato3 / 2;
                resto4 = risultato3 % 2;

                risultato5 = risultato4 / 2;
                resto5 = risultato4 % 2;

                risultato6 = risultato5 / 2;
                resto6 = risultato5 % 2;

                risultato7 = risultato6 / 2;
                resto7 = risultato6 % 2;

                risultato8 = risultato7 / 2;
                resto8 = risultato7 % 2;

                Console.WriteLine("\nIl numero in binario è {0}{1}{2}{3}{4}{5}{6}{7}", resto8, resto7, resto6, resto5, resto4, resto3, resto2, resto1);
                Console.WriteLine("\n-------------------------------------------\n");

            } while (true);


        }
    }
}
