using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            long val1;
            long val2;
            double risultato, risultato1, risultato2, risultato3, risultato4;
            double resto;
            string scelta;

            do
            {
                Console.Write("\n---------------------------------------\n");
                Console.Write("\nInserire valore 1: ");
                val1 = Convert.ToInt64(Console.ReadLine());

                Console.Write("Inserire valore 2: ");
                val2 = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Scegliere l'operatore (Somma,Divisione,Moltiplicazione,Sottrazione): ");
                scelta = Console.ReadLine();
                scelta = scelta.ToUpper();

                if (scelta == "SOMMA")
                {
                    risultato = val1 + val2;
                    Console.WriteLine("Il risultato è: " + risultato);
                }

                if (scelta == "SOTTRAZIONE")
                {
                    risultato1 = val1 - val2;
                    Console.WriteLine("Il risultato è: " + risultato1);
                }

                if (scelta == "MOLTIPLICAZIONE")
                {
                    risultato2 = val1 * val2;
                    Console.WriteLine("Il risultato è: " + risultato2);
                }

                if (scelta == "DIVISIONE")
                {
                    risultato3 = val1 / val2;
                    risultato4 = Math.Round(risultato3);
                    resto = val1 % val2;

                    Console.WriteLine("Il risultato è: " + risultato3);
                    Console.WriteLine("Il risultato arrotondato è: " + risultato4);
                    Console.WriteLine("Il resto è: " + resto);

                }

            } while (true);

        }
    }
}
