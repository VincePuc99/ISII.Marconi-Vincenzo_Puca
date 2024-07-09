using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 13, b = 24;
            int[] v1 = new int[] { 1, 2, 3 };
            int[] v2 = new int[] { 4, 5, 6 };

            //Scambia(ref a,ref b);
            for (int i = 0; i < v1.GetLength(0); i++)
            {
                Console.Write(v1[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < v2.GetLength(0); i++)
            {
                Console.Write(v2[i]);
            }

            ScambiaArray(v1, v2); //senza ref viene passata soltanto la modifica al singolo valore mentre con il ref viene applicata la modifica a tutto l'array se presente nel metodo scelto

            Console.WriteLine();

            for (int i = 0; i < v1.GetLength(0); i++)
            {
                Console.Write(v1[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < v2.GetLength(0); i++)
            {
                Console.Write(v2[i]);
            }
            Console.WriteLine();
            //Console.WriteLine("{0} {1}",a,b);
        }

        static void Scambia(ref int x,ref int y)
        {
            int scambio = 0;

            scambio = x;
            x = y;
            y = scambio;
            
        }

        static void ScambiaArray( int[] ar1, int[] ar2) //questo passaggio parametri modifica il valore anche nell array principale ma senza ref non modifica l'intero array
        {
            int[] arraycomodo = new int[3];
            arraycomodo = ar1; //non essendoci il ref l'array nel main non viene modificato
            ar1 = ar2;
            ar2 = arraycomodo;
            ar1[0] = 999; //questa modifica viene fatta anche nalla variabile presente nel main
        }
    }
}
