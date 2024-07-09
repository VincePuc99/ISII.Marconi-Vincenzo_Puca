using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace file_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string collegamento = @"C:\Users\M_inf2.terza\Desktop\tluoghi.txt";
          //  StreamWriter sr = new StreamWriter(collegamento, false);
            StreamReader sw = new StreamReader(collegamento);
            Console.Write("Creazione file in corso");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }
   
         
            //sr.WriteLine("15/03/2015  19.0   Torino");
            //sr.WriteLine("15/03/2015  18.0   Milano");
            //sr.WriteLine("15/03/2015  15.0   Piacenza");
            //sr.WriteLine("15/03/2015  15.0   Piacenza");
            //sr.WriteLine("16/03/2015  21.0   Milano");
            //sr.WriteLine("16/03/2015  22.0   Piacenza");
       
            Console.WriteLine("====== Menù =======");
            Console.WriteLine("1) visualizzazione");
            Console.WriteLine("2) visualizzazione per data");
            Console.WriteLine("2) visualizzazione per luogo");
            Console.WriteLine("3) temperatura media in  data");
            Console.WriteLine("4) temperatura media in  data");
            Console.WriteLine("5) temperatura media per città e data");
            Console.WriteLine("6) registrazione");
            Console.WriteLine("7) cancellazione ");
            Console.WriteLine("===================");
            Console.WriteLine("Inserire una scelta desiderata → ");
















           
            
        }//fine programma
    }
}
