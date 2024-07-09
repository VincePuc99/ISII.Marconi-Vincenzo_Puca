using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlfabetoFarfallino
{
    class Program
    {
        static void Main(string[] args)
        {

            string miofile = @"C:\Users\M_INF2.Terza\Desktop\frasi.txt";
            string miofileF = @"C:\Users\M_INF2.TERZA\Desktop\Traduzione.txt";

            Console.WriteLine("Lettura utilizzando null");
            Console.WriteLine();
            bool aggiungo = false;
            StreamWriter sw = new StreamWriter(miofileF, aggiungo);

            StreamReader sr = new StreamReader(miofile);
            string riga;
            riga = sr.ReadLine();
            while ((riga = sr.ReadLine()) != null)
                Console.WriteLine(riga);
                sw.WriteLine(riga);
                riga = riga.Replace("a", "afa");
            {
                riga = riga.Replace("A", "Afa");
                riga = riga.Replace("e", "efe");
                riga = riga.Replace("E", "Efe");
                riga = riga.Replace("i", "ifi");
                riga = riga.Replace("I", "Ifi");
                riga = riga.Replace("o", "ofo");
                riga = riga.Replace("O", "Ofo");
                riga = riga.Replace("u", "ufu");
                riga = riga.Replace("U", "Ufu");

                Console.WriteLine(riga);
                sw.WriteLine(riga);

            }
            sr.Close();



            sw.Close();
            Console.ReadKey();
        }
    }
}
