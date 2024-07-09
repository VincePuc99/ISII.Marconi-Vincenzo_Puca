using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Traslare
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string parola1, parola2, parola3;
            string est;
            int cont = 0;
            
            Console.Write("Inserire prima parola: ");
            parola1 = Console.ReadLine();

            Console.Write("Inserire seconda parola: ");
            parola2 = Console.ReadLine();

            Console.WriteLine("============================");
            Console.Write("Elaborazione in corso");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine("Visualizzazione di  tutte le traslazioni possibili della stringa {0}",parola1);
            Console.WriteLine("============================");

            for (int i = 0; i < parola1.Length; i++)
            {

                est = parola1.Substring(0, 1);
                parola1 = parola1.Remove(0, 1);
                parola1 += est;
                Console.WriteLine(parola1);
                if (parola1 == parola2)
                {
                    cont = i;
                    cont++;
                    cont -= 1;
                    Console.WriteLine("{0}*", parola1);
                    parola3 = parola1;
                  
                }
            
            }
            Console.WriteLine("Inserire traslazione trovata e corretta");
            parola3 = Console.ReadLine();
            if (parola3 == parola2)
            {

                Console.WriteLine("============================");
                Console.WriteLine("Esito elaborazione:");
                Console.WriteLine("Si,occorre traslare a sinistra {0} volte la prima stringa in input per ottenere la prima", cont);
            }

            if (parola3 != parola2)
            {

                Console.WriteLine("============================");
                Console.WriteLine("Esito elaborazione:");
                Console.WriteLine("No,non ci sono corrispondenze");
            }







        }
    }
}
