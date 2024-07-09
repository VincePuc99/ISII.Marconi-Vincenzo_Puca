using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1;
            int risultato, risultato1;
            int media, media1;

            do
            {
                Console.Write("Inserisci un numero (0 per smettere di inserire): ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserisci un numero (0 per smettere di inserire): ");
                n1 = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0 && n1 % 2 == 0)
                {
                    risultato = n + n1;
                    media = (n + n1) / 2;
                    Console.WriteLine("Somma dei pari: {0}",risultato);
                    Console.WriteLine("Media dei pari: {0}",media);
                }
                if (n % 2 != 0 && n1 % 2 != 0)
                {
                    risultato1 = n + n1;
                    media1 = (n + n1) / 2;
                    Console.WriteLine("Somma dei dispari: {0}",risultato1);
                    Console.WriteLine("Media dei dispari: {0}",media1);
                }
                
            } while (n != 0 || n1 != 0);

            Console.ReadLine();
            
        }
    }

}
