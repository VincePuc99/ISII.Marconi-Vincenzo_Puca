using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[3][];//la prima parentesi quadra indica il numero di righe mentre la seconda indica il numero di elementi nella riga

            jaggedarray[0] = new int[] { 1, 6, 9 };
            jaggedarray[1] = new int[] { 4 };
            jaggedarray[2] = new int[] { 5, 2, 1, 99 };

            for (int i = 0; i <= jaggedarray.GetUpperBound(0); i++)
            {
                for (int f = 0; f <= jaggedarray[i].GetUpperBound(0); f++)
                {
                    Console.Write("{0} ", jaggedarray[i][f]);

                }
                Console.WriteLine();
            }

        }//fine main
    }
}
