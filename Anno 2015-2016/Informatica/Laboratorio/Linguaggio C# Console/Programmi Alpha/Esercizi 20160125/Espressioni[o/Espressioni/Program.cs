using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espressioni
{
    class Program
    {
        static void Main(string[] args)
        {
            string espressione;
            string somma, somma1;
            int totale, totale1;
            string  differenza1;

            Console.WriteLine("Inserire l'espressione desiderata: ");
            espressione = Console.ReadLine();

            for (int i = 0; i < espressione.Length; i++)
            {
                if (espressione[i] == '+')
                {
                    somma = espressione.Substring(i - 2, 2);
                    somma1 = espressione.Substring(i + 1, 2);
                  
                    int numero = Int32.Parse(somma);
                    int numero1 = Int32.Parse(somma1);
                    totale = numero + numero1;

                    Console.WriteLine("{0} + {1} = {2}", numero,numero1,totale);
                    
                }

                if (espressione[i] == '-')
                {
                    
                    differenza1 = espressione.Substring(i + 1, 2);                 
                    int numer1 = Int32.Parse(differenza1);
                    totale1 = totale - numer1;

                    Console.WriteLine("{0} - {1} = {2}", totale, numer1, totale1);
                }





            }

        }
    }
}
