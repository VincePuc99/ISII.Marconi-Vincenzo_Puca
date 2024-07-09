using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ristornate_cinese
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int costotot=0;
            int quantit;
            int scelta;
            do
            {
                Console.WriteLine("\nxxxxxxxxxxxx Ristornante Cinese xxxxxxxxxxxxx");
                Console.WriteLine("1)Involtino primavera (5$)");
                Console.WriteLine("2)Ravioli al vapore (6$)");
                Console.WriteLine("3)Spaghetti di soia con verdure (4$)");
                Console.WriteLine("4)Pollo con bambù e funghi (8$)");
                Console.WriteLine("5)Vitello con sedano (7$)");
                Console.WriteLine("6)Termina il programma");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");

               
                Console.WriteLine("Inserire l'opzione desiderata: ");
                scelta = Convert.ToInt32(Console.ReadLine());

                switch(scelta)
                {

                    case 1:
                    Console.WriteLine("Inserire quante se ne vuole: ");
                    quantit=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hai ordinato {0} involtini",quantit);
                    costotot += quantit * 5;
                    break;

                    case 2:
                    Console.WriteLine("Inserire quante se ne vuole: ");
                    quantit=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hai ordinato {0} Ravioli", quantit);
                    costotot += quantit * 6;
                    break;

                    case 3:
                    Console.WriteLine("Inserire quante se ne vuole: ");
                    quantit=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hai ordinato {0} Spaghetti", quantit);
                    costotot += quantit * 4;
                    break;

                    case 4:
                    Console.WriteLine("Inserire quante se ne vuole: ");
                    quantit=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hai ordinato {0} Pollo/i", quantit);
                    costotot += quantit * 8;
                    break;

                    case 5:
                    Console.WriteLine("Inserire quante se ne vuole: ");
                    quantit=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hai ordinato {0} Vitello/i", quantit);
                    costotot += quantit * 7;
                    break;

                    case 6:
                    Console.WriteLine("Programma terminato...");
                    Console.WriteLine("\nxxxxxxxxxxxx Ristornante Cinese xxxxxxxxxxxxx");
                    Console.WriteLine("xxxxxxxxxxxxxx Scontrino Fiscale xxxxxxxxxxxxxx");
                    Console.WriteLine("Subtot {0} $",costotot);
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
                    return;
                
            }

            } while (true);






        }
    }
}
