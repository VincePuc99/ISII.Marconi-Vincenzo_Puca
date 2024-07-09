using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_Podistica
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempi, ora;
            int cont = 0, cont1 = 0;
            char err;
            bool sn = false;
             int gioc = 1, cont4 = 0;

            do{
            Console.WriteLine("Inserire i tempi es.(#12:15#12:20#12:22#12:25): ");
            tempi = Console.ReadLine();

            for (int i = 0; i < tempi.Length; i++)
            {
                if (tempi[i] == '#')
                {
                    cont++;
                    //if (tempi[i + 6] == '#')
                    //{
                    //    ora = tempi.Substring(i + 1, 5);
                    //    Console.WriteLine(ora);
                    //}

                    //if (tempi[i + 6] != '#')
                    //{
                    //    err = tempi[i + 6];
                    //    sn = true;
                    //}
                }

                if (tempi[i] == ':')
                {
                    cont1++;
                }
            }

            if(cont %2 != 0)
            {
                Console.WriteLine("Il N° di '#' deve essere pari!!!"); 
            }

            if (cont != cont1)
            {
                Console.WriteLine("Il N° di '#' deve essere uguale al N° di ':'"); 
            }

            if (sn == true)
            {
                Console.WriteLine("Orario non valido.");
            }

            } while (cont % 2 != 0 && cont != cont1 && sn == false);


           

            Console.WriteLine("Tabella intertempi di arrivo");
            Console.WriteLine("============================");

            for (int i = 0; i < tempi.Length; i++)
            {
                if (tempi[i] == '#')
                {
                    if (cont4 == 0)
                        Console.Write("Concorrente n.ro {0}      Tempo: ", gioc);
                    else
                        Console.Write("Concorrente n.ro {0}     Diff T. ", gioc);
                    cont4++;
                    gioc++;
                    Console.Write(tempi.Substring(i + 1, 2));
                    Console.Write(":");
                }

                if (tempi[i] == ':')
                {
                    Console.Write(tempi.Substring(i + 1, 2));
                    Console.Write("\n");
                }
            }








        }
    }
}
