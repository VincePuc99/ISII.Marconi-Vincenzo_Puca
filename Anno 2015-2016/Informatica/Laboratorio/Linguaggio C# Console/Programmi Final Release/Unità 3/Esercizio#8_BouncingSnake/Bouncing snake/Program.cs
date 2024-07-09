using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bouncing_snake
{
    class Program
    {
        static void Main(string[] args)
        {

              
            string[] testa = { "< >", "[ ]", "( )", "◄ ►" };
            string[] corpo = { "-", "+", "♫", "*" };
            string serpente;
            int numt, numc, cont = 3;
            Random r = new Random();
            string area = "========================================";
            // creo serpente
            numt = r.Next(0, 4);
            numc = r.Next(0, 4);

            // serpente  
          
            serpente = testa[numt].Replace(" ", corpo[numc]);

            do
            {
               
              for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(area);
                    Console.WriteLine("\n\t\tSNAKE");
                    Console.WriteLine(area + "\n\n\n");
                    Console.WriteLine(serpente);
                    serpente = serpente.Insert(0, " ");
                    Console.WriteLine("\n\n\n" + area + "\n");
                    Console.WriteLine(area + "\n");
                    Thread.Sleep(500);
                    Console.Clear();

                    
                }

              if (serpente[10] != ' ')
              {
                  serpente = serpente.Insert(10, corpo[numc]);
                  cont++;
              }

              if (cont == 8)
              {
                  Console.WriteLine("Raggiunta dimensione massima del serpente Game Over!!!");
                  return;
              }

                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(area);
                    Console.WriteLine("\n\t\tSNAKE");
                    Console.WriteLine(area + "\n\n\n");
                    Console.WriteLine(serpente);
                    serpente = serpente.Remove(0, 1);
                    Console.WriteLine("\n\n\n" + area + "\n");
                    Console.WriteLine(area + "\n");
                    Thread.Sleep(500);
                    Console.Clear();

                    if (serpente[0] != ' ')
                    {
                        serpente = serpente.Insert(1, corpo[numc]);
                        cont++;
                    }

                }

            } while (true);


            
            
            

        }
    }
}
