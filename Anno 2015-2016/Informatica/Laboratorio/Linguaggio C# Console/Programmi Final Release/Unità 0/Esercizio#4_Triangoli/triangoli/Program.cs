using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            string riavvio;
            
            Restart:

            Console.Write("\nInserire il lato 1: ");
            l1 = Convert.ToInt32 (Console.ReadLine());

            Console.Write("\nInserire il lato 2: ");
            l2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInserire il lato 3: ");
            l3 = Convert.ToInt32(Console.ReadLine());

            //elaborazione

            if (l1 < (l2 + l3) && l2 < (l1 + l3) && l3 < (l2 + l1)) // Se è falso va a *1    // Se è vero va a *2 
            {
                if ((l3 * l3) == (l1 * l1) + (l2 * l2)) // *2       // Se è falso va a *3    // Se è vero va a *4
                {
          I          Console.WriteLine("Il triangolo è rettangolo"); // *4
                }
                else
                {
                    Console.WriteLine("Il triangolo non è rettangolo"); // *3
                }
            }         
            else
                {
                    Console.WriteLine("Non ci sono le condizioni per l’esistenza di un triangolo."); // *1
                }

     
            
            Console.Write("Vuoi Ricominciare??? (SI)--(NO): ");
            riavvio = Console.ReadLine();

            if (riavvio.ToUpper() == "SI")
            {
                goto Restart;
            }
            if (riavvio.ToUpper() == "NO")
            {
                return;
            }            


            Console.ReadKey();



        }
    }
}
