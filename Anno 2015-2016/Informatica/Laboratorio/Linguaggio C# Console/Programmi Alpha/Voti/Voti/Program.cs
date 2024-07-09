using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Voti
{
    class Program
    {
        static void Main(string[] args)
        {
            string materia, voto, data;
            string miofile = @"C:\Users\M_inf2.terza\Desktop\Valutazione.txt";
            bool aggiungo = false;
            string scelta;
            StreamWriter sn = new StreamWriter(miofile,aggiungo);
            StreamReader sr = new StreamReader(miofile);

            do
            {
                Console.Write("Inserisci la data: ");
                data = Console.ReadLine();
                sn.WriteLine(data);

                Console.Write("Inserisci la materia: ");
                materia = Console.ReadLine();
                sn.WriteLine(materia);

                Console.Write("Inserisci il voto: ");
                voto = Console.ReadLine();
                sn.WriteLine(voto);

                sn.Close();

                Console.WriteLine("Se noo hai inserito almeno 2 voti la media non sarà fatta!!! ");
                Console.WriteLine("Hai finito di inserire i voti? (SI)--(NO): ");
                scelta = Console.ReadLine();
                scelta = scelta.ToUpper();

                if (scelta == "SI")
                {
                   continue;
                }
                
            } while (scelta == "NO");

            sr.ReadLine();







        }
    }
}
