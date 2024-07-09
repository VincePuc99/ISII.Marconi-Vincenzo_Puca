using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno_Bisestile
{
    class Program
    {
        static void Main(string[] args)
        {
            //dati
           
            int anno;
            int bisestile;

            //input
            restart:
            do
            {

                Console.Write("inserire un anno tra il 1582 e il 2015 (Inclusi): ");
                anno = Convert.ToInt32(Console.ReadLine());

                if (anno < 1582  || anno > 2015)
                    Console.WriteLine("Valore non consentito,riprovare...");

            } while (anno < 1582 || anno > 2015); //condizione input errato
          
            //calcolo se è bisestile

            bisestile = anno / 4;

            //output
            if (anno == 1700)
            {
                Console.WriteLine("L'anno non è bisestile!!!");
                goto restart;
            }

            if (anno == 1800)
            {
                Console.WriteLine("L'anno non è bisestile!!!");
                goto restart;
            }

            if (anno == 1900)
            {
                Console.WriteLine("L'anno non è bisestile!!!");
                goto restart;
            }

            Console.WriteLine("L'anno è bisestile se il risultato è pari,altrimenti non lo è...{0}",bisestile);
            Console.ReadKey();
        }
    }
}
