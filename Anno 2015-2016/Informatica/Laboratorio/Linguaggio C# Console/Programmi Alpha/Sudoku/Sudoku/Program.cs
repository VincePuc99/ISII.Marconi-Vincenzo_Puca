using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabella = new int[9, 9];
            StringBuilder prova = new StringBuilder(9);
            StringBuilder vuoto = new StringBuilder(9);




            //for (int i = 0; i < tabella.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabella.GetLength(1); j++)
            //    {
            //        do
            //        {
            //            Console.Write("Inserisci il numero per completare lo spazio {0}X{1}: ", i, j + 1);
            //            tabella[i, j] = Convert.ToInt16(Console.ReadLine());
            //            if (tabella[i, j] > 9 || tabella[i, j] < 1)
            //            {
            //                Console.WriteLine("Non puoi inserire numeri maggiori di 9 o minori di 1");
            //            }
            //        } while (tabella[i, j] > 9 || tabella[i, j] < 1);
            //    }
            //}

            //inserimenti multipli in una riga

            int[,] numeri = {{1,1,2,3,4,5,6,7,8 },
                             {0,1,2,3,4,5,6,7,8}};

            for (int i = 0; i < numeri.GetLength(0); i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (numeri[i, j] == j+1 )
                    {
                        prova[j] = ' ';
                    }
                }
            }

            if (prova == vuoto)
            {
                Console.WriteLine("Hai inserito valori uguali");
            }








        }//fine programma
    }
}
