using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // dato
          int scelta;
          int conterr = 0;

            //menu
          do
          {
              do
              {
                  Console.Clear();
                  Console.WriteLine("================= ");
                  Console.WriteLine("       Menù       ");
                  Console.WriteLine("=================");
                  Console.WriteLine("    1) prima voce ");
                  Console.WriteLine("    2)seconda voce");
                  Console.WriteLine("    3) fine       ");
                  Console.WriteLine("inserire un valore tra 1 e 3 inclusi");
                  scelta = Convert.ToInt16(Console.ReadLine());


                  if (scelta < 1 || scelta > 3)
                      Console.WriteLine("valore errato");
                  conterr++;
                  if (conterr == 3)
                      Console.WriteLine("limite raggiunto");

              } while (scelta < 1 || scelta > 3);

              //elaborazione 
              switch (scelta)
              {
                  case 1:
                      Console.WriteLine("\n\neseguo prima voce");
                      Console.WriteLine("Premi <INVIO>  per tornare al menu...");
                      Console.ReadLine();
                      break;

                  case 2:
                      Console.WriteLine("\n\neseguo seconda voce");
                      Console.WriteLine("Premi <INVIO>  per tornare al menu...");
                      Console.ReadLine();
                      break;
                  case 3:
                      Console.WriteLine("termine esecuzione programma!!!");
                      break;
                  default: Console.WriteLine("valore in input non previsto");   //nel caso in cui non sia ne 1 ne 2 ne 3
                      break;
              }
          } while (scelta!=3);


        }
    }
}
