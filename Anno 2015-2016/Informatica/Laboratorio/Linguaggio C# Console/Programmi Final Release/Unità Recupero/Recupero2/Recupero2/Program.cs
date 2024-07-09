using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupero2
{
    class Program
    {
        static void Main(string[] args)
        {

            int livello;
            int quesito1_1;
            int quesito1_2;
            int quesito1_3;
            double quesito2_1;
            double quesito2_2;
            double quesito2_3;

            do
            {
                Console.WriteLine("Quale livello di difficoltà scegli? ");
                livello = Convert.ToInt16(Console.ReadLine());

                if (livello != 1 && livello != 2)
                {
                    Console.WriteLine("Difficoltà inesistente,riprova!!!");
                }

            } while (livello != 1 && livello != 2);


            if (livello == 1)
            {
                Console.WriteLine("Inserisci un risultato alle operazioni,alla fine verrà analizzato.");
                Console.Write("(2 + 8) * 3 = ");
                quesito1_1 = Convert.ToInt16(Console.ReadLine());
               
                Console.Write("(4 * 2) + (5 - 2) = ");
                quesito1_2 = Convert.ToInt16(Console.ReadLine());

                Console.Write("(2 * (1 + 3 + 4 + 5) + 1) = ");
                quesito1_3 = Convert.ToInt16(Console.ReadLine());

                if (quesito1_1 == 30)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }

                if (quesito1_2 == 11)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }

                if (quesito1_3 == 27)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }
            }

            if (livello == 2)
            {
                Console.WriteLine("Inserisci un risultato alle operazioni,alla fine verrà analizzato.");
                Console.Write("(4 / 8) + ((2 + 7) / 3) * 5) = ");
                quesito2_1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("(77 / (9 + 2)) – (3 * 5) / 10 = ");
                quesito2_2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("(1 + 2 * 3 * 4) – (2 * 3) = ");
                quesito2_3 = Convert.ToDouble(Console.ReadLine());
                
                if (quesito2_1 == 15.5)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }

                if (quesito2_2 == 5.5)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }

                if (quesito2_3 == 30)
                {
                    Console.WriteLine("Risultato del primo quesito corretto!");
                }
                else
                {
                    Console.WriteLine("Risultato del primo quesito errato!");
                }
            }













        }
    }
}
