using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe_numeriche
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeri;
            int cont1 = 0, cont2 = 0, cont3 = 0, cont0 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0;
            string numeri1 = "";

            do
            {
                Console.Write("Inserire solo cifre numeriche: ");
                numeri = Console.ReadLine();

                if (numeri != "0" && numeri != "1" && numeri != "2" && numeri != "3" && numeri != "4" && numeri != "5" && numeri != "6" && numeri != "7" && numeri != "8" && numeri != "9")
                {
                    Console.WriteLine("Inserisci solo numeri!!!\n");
                }

            } while (numeri != "0" && numeri != "1" && numeri != "2" && numeri != "3" && numeri != "4" && numeri != "5" && numeri != "6" && numeri != "7" && numeri != "8" && numeri != "9");


            for (int i = 0; i < numeri.Length; i++)
            {

                if (numeri[i] == '0')
                {
                    cont0++;
                    numeri1 = numeri1.Insert(i, "0");
                    numeri1 = numeri1.Insert(i, "cont0");
                    Console.WriteLine("{0}",numeri1);
                }

                if (numeri[i] == '1')
                {
                    cont1++;
                }

                if (numeri[i] == '2')
                {
                    cont2++;
                }

                if (numeri[i] == '3')
                {
                    cont3++;
                }

                if (numeri[i] == '4')
                {
                    cont4++;
                }

                if (numeri[i] == '5')
                {
                    cont5++;
                }

                if (numeri[i] == '6')
                {
                    cont6++;
                }

                if (numeri[i] == '7')
                {
                    cont7++;
                }

                if (numeri[i] == '8')
                {
                    cont8++;
                }

                if (numeri[i] == '9')
                {
                    cont9++;
                }






            }


        }
    }
}
