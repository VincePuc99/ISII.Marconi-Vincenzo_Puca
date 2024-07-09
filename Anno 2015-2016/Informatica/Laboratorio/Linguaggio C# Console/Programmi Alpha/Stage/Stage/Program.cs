using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alleeevee = new string[4];
            string[] deette = new string[4];
            int [,] deestanze = new int[4,4];
            int cont = 0;
            

            //allievi
            for (int i = 0; i < 4; i++)
            {
                cont++;
                Console.Write("Inserisci il cognome del {0}° allievo: ", cont);
                alleeevee[i] = Console.ReadLine();
            }

            cont = 0;
            //ditte
            for (int i = 0; i < 4; i++)
            {
                cont++;
                Console.Write("Inserisci il nome della {0}° ditta: ", cont);
                deette[i] = Console.ReadLine();
            }




            //distanza
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                        Console.Write("Inserire la distanza dell' allievo {0} dalla {1}: ", alleeevee[i], deette[j]);
                        deestanze[i, j] = Convert.ToInt16(Console.ReadLine());
             
                }

            }


            //tabellone
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("  Tabella distanze (km) allievi-ditte  ");
            Console.WriteLine("======================================");

            Console.Write("Allievo\t");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t\t", deette[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}\t", alleeevee[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t\t", deestanze[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            

        }
    }
}
