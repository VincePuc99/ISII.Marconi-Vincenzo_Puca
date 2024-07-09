using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trova_min_Trova_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[] { 5, 2, 9, 1 };
            int min;
            int max;

            //trova min

            min = vet[0];
            for (int i = 1; i < vet.GetLength(0); i++)
            {
                if (vet[i] < min)
                {
                    min = vet[i];                
                }
            
            }

            Console.WriteLine("{0}", min);

            //trova max   

            max = vet[0];
            for (int i = 1; i < vet.GetLength(0); i++)
            {
                if (vet[i] > max)
                {
                    max = vet[i];
                }

            }

            Console.WriteLine("{0}",max);


        }
    }
}
