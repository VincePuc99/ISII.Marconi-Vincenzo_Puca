using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liza
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int anni;
            string tempo;
            string stato;

            Console.WriteLine("Ciao, come ti chiami? " );
            nome = Console.ReadLine();

            Console.WriteLine("Piacere di conoscerti {0}, io mi chiamo PC.",nome);
            Console.Write("Quanti anni hai {0}?",nome);

            Console.WriteLine("");
            anni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} anni? WOW!", anni);
            Console.WriteLine("Io ne ho 4 e già mi sento obsoleto... :( ");

            Console.WriteLine("Caro {0}, mi sai dire che tampo fa oggi?",nome);
            tempo = Console.ReadLine();

            tempo = tempo.ToUpper();
            if (tempo == "PIOGGIA" || tempo == "PIOVE")
            {
                Console.WriteLine("Che tristezza...");
            }

            if (tempo == "SOLE")
            {
                Console.WriteLine("Che gioia!!!");
            }
            Console.WriteLine("Caro {0}, mi sai dire dove vivi (Lo stato)?", nome);
            stato = Console.ReadLine();

            Console.WriteLine("Che bello! Anche a me piacerebbe vivere in {0}...", stato);
            Console.WriteLine("{0} sono stanco...Ciao ci vediamo domani! ;)", nome);
            Console.ReadKey();



        }
    }
}
