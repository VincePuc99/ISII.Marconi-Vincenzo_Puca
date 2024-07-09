using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceso;  // lampadina
            int varo = 0;  // controllo se è accesa o spenta

            do
            {
                // INPUT
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Interruttore: ");
                acceso = Convert.ToInt32(Console.ReadLine());

                // ELABORAZIONE

                if (varo != 1)  // se rischiaccio e la variabile è incrementata non fa niente
                {
                    if (acceso == 1)  // se l'utente vuole accendere la lampadina
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\n\t\tLampadina accesa\n");
                        Console.WriteLine("\t\t ___ ");
                        Console.WriteLine("\t\t| _ |");
                        Console.WriteLine("\t\t|_|_| ");
                        Console.WriteLine("\t\t |_|  \n\n");     
                        varo++;  // incrementa la variabile varo e si spegne
                    }
                }

                if (varo != 0) // se rischiaccio e la variabile è decrementata non fa niente
                {
                    if (acceso == 0)  // se l'utente vuole spegnere la lampadina
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\n\t\tLampadina spenta\n");
                        Console.WriteLine("\t\t ___ ");
                        Console.WriteLine("\t\t| _ |");
                        Console.WriteLine("\t\t|_|_| ");
                        Console.WriteLine("\t\t |_|  \n\n");          
                        varo--; // decrementa la variabile varo e si spegne
                    }
                }


            } while (true);  // esegue sempre l'interruttore
        }
    }
}
