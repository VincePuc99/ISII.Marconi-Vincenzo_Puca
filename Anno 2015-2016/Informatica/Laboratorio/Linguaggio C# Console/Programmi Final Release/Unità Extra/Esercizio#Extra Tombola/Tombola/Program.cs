using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Benvenuto, questo è il giuoco del tombolone!");
            Console.WriteLine("");

            Random sacchetto = new Random();
            int numero = 0;
            int cont=0;
            bool[] si = new bool[15];
            bool[] estratti = new bool[90];
            int[,] tab = new int[3, 5];

            int num1 = sacchetto.Next(0, 91);
            int num2 = sacchetto.Next(0, 91);
            int num3 = sacchetto.Next(0, 91);
            int num4 = sacchetto.Next(0, 91);
            int num5 = sacchetto.Next(0, 91);
            int num6 = sacchetto.Next(0, 91);
            int num7 = sacchetto.Next(0, 91);
            int num8 = sacchetto.Next(0, 91);
            int num9 = sacchetto.Next(0, 91);
            int num10 = sacchetto.Next(0, 91);
            int num11 = sacchetto.Next(0, 91);
            int num12 = sacchetto.Next(0, 91);
            int num13 = sacchetto.Next(0, 91);
            int num14 = sacchetto.Next(0, 91);
            int num15 = sacchetto.Next(0, 91);

            do
            {
                numero = sacchetto.Next(1, 91);
                Console.WriteLine("Numero Generato {0}", numero);
                if (estratti[numero - 1] == false)
                {
                    Console.WriteLine("Numero Estratto {0}", numero);
                    estratti[numero - 1] = true;
                }
                Console.WriteLine();
                cont++;
                Console.ReadKey();

            //generazione cartella giocatore
           
            tab[0, 0] = num1;
            tab[1, 0] = num2;
            tab[0, 1] = num3;
            tab[0, 2] = num4;
            tab[1, 1] = num5;
            tab[1, 2] = num6;
            tab[0, 3] = num7;
            tab[0, 4] = num8;
            tab[1, 3] = num9;
            tab[1, 4] = num10;
            tab[2, 0] = num11;
            tab[2, 1] = num12;
            tab[2, 2] = num13;
            tab[2, 3] = num14;
            tab[2, 4] = num15;

            Console.WriteLine("╔═══╦═══╦═══╦═══╦═══╗");
            Console.WriteLine("║{0}║{1}║{2}║{3}║{4}║", tab[0, 0], tab[0, 1], tab[0, 2], tab[0, 3], tab[0, 4]);
            Console.WriteLine("╠═══╬═══╬═══╬═══╬═══╣");
            Console.WriteLine("║{0}║{1}║{2}║{3}║{4}║", tab[1, 0], tab[1, 1], tab[1, 2], tab[1, 3], tab[1, 4]);
            Console.WriteLine("╠═══╬═══╬═══╬═══╬═══╣");
            Console.WriteLine("║{0}║{1}║{2}║{3}║{4}║", tab[2, 0], tab[2, 1], tab[2, 2], tab[2, 3], tab[2, 4]);
            Console.WriteLine("╚═══╩═══╩═══╩═══╩═══╝");

            if (num1 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}",num1,numero);
                si[0] = true;
            }

            if (num2 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num2, numero);
                si[1] = true;
            }

            if (num3 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num3, numero);
                si[2] = true;
            }
            if (num4 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num4, numero);
                si[3] = true;
            }
            if (num5 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num5, numero);
                si[4] = true;
            }
            if (num6 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num6, numero);
                si[5] = true;
            }
            if (num7 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num7, numero);
                si[6] = true;
            }
            if (num8 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num8, numero);
                si[7] = true;
            }
            if (num9 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num9, numero);
                si[8] = true;
            }
            if (num10 == numero)
            {
                si[9] = true;
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num10, numero);
            }
            if (num11 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num11, numero);
                si[10] = true;
            }
            if (num12 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num12, numero);
                si[11] = true;
            }
            if (num13 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num13, numero);
                si[12] = true;
            }
            if (num14 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num14, numero);
                si[13] = true;
            }
            if (num15 == numero)
            {
                Console.WriteLine("Tuo numero {0}, numero estratto e preso {0}", num15, numero);
                si[14] = true;
            }

            foreach (bool vero in si)
            {
               continue;
            }
               

            } while (cont < 91);

        }
    }
}
