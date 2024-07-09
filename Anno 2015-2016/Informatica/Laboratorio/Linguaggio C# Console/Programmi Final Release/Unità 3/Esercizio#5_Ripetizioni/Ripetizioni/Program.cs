using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripetizioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Random va1 = new Random();
            int cont,cont1,cont2,cont3,cont4;
            int conte=0, conte1=0, conte2=0, conte3=0, conte4=0;
            cont = va1.Next(9);
            cont1 = va1.Next(9);
            cont2 = va1.Next(9);
            cont3 = va1.Next(9);
            cont4 = va1.Next(9);

            int[] var = new int[5] {cont,cont1,cont2,cont3,cont4 };

            Console.WriteLine("{0}-{1}-{2}-{3}-{4}",cont,cont1,cont2,cont3,cont4);

            for (int i = 0; i < var.GetLength(0); i++)
            { 

            if(var[i] == cont)
            {
                conte++;
                if (conte >= 2)
                {
                    Console.WriteLine("Si ripete {0}, {1} volte", cont,conte);
                }
            }

            if (var[i] == cont1)
            {
                conte1++;
                if (conte1 >= 2)
                {
                    Console.WriteLine("Si ripete {0}, {1} volte", cont1,conte1);
                }
            }

            if (var[i] == cont2)
            {
                conte2++;
                if (conte2 >= 2)
                {
                    Console.WriteLine("Si ripete {0}, {1} volte", cont2, conte2);
                }
            }

            if (var[i] == cont3)
            {
                conte3++;
                if (conte3 >= 2)
                {
                    Console.WriteLine("Si ripete {0}, {1} volte", cont3, conte3);
                }
            }

            if (var[i] == cont4)
            {
                conte4++;
                if (conte4 >= 2)
                {
                    Console.WriteLine("Si ripete {0}, {1} volte", cont4, conte4);
                }
            }
            
            }








        }
    }
}
