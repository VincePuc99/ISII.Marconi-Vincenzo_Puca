using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area dati

            string d1 = "D1#45°4’36N@9°27’16E#45°3’43N@9°26’24E#45°3’28N@9°25’26E#45°3’0N@9°24’51E#45°2’28N@9°23’15E#";
            string d2 = "D2#45°4’36N@9°27’16E#45°4’20N@9°27’47E#45°4’8N@9°28’16E#45°4’1N@9°28’55E#45°3’31N@9°29’48E#";
            string lastpos = "";
            string source = "", source1 = "";
            bool trovata = false;
            int start, end;

            Console.WriteLine("MONITORAGGIO DRONI");
            Console.WriteLine("==================");
            Console.WriteLine("Rotta D1..........");

            for (int i = 0; i < d1.Length; i++)
            {
                if (d1[i] == '@')
                {
                    Console.Write(" ");
                }

                else if (d1[i] == '#')
                {
                    Console.WriteLine();
                }

                else
                    Console.Write(d1[i]);
            }

            Console.WriteLine(".................");

            Console.WriteLine("Visualizzazione ultima posizione drone 1: ");

            lastpos = d1.Substring(d1.LastIndexOf('#', d1.Length - 2) + 1 ,
             d1.LastIndexOf('#') - d1.LastIndexOf('#', d1.Length - 2) - 1);

            lastpos = lastpos.Replace('@', ' ');

            //source = "45°3’0N@9°24’51E";

            //Console.WriteLine("Introdurre le coordinate di posizione da cercare: ");
            //source = Console.ReadLine().ToUpper();
            //source = source.Replace(' ', '@');
            
            //if (d1.Contains(source) == true)
            //{
            //    Console.WriteLine("Il drone D1 è passato per: {0}", source);
            //}

            //else
            //    Console.WriteLine("Il drone D1 NON è passato per: {0}", source);
            
            //Punto 4

            //source1 = "45°4’36N@9°27’16E";


            source1 = "";
            start = 0;
            end = 0;

            for (; ; )
            {
                start = d1.IndexOf('#', start);
                end = d1.IndexOf('#', start + 1);

                if (end == -1)
                    break;

                               
                source1 = d1.Substring(start + 1, end - start - 1);

                if (d2.Contains(source1) == true)
                {
                    trovata = true;
                }

                
                if (trovata == true)

                    Console.WriteLine("Le traiettorie dei 2 droni si incrociano almeno una volta");

                else
                    Console.WriteLine("Le traiettorie dei 2 droni non si incrociano mai");


                Console.WriteLine(source1);

                start = end;
            }










               
     









          
            //Console.WriteLine(lastpos);
        }
    }
}
