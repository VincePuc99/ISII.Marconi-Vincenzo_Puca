using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Poliambulatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] medici = new string[] { "rossi", "bianchi", "verdi" };
            string[] ambulatori = new string[]{"a1","a2","a3"};
            int scelta = 0;

            Console.WriteLine("XXXXXXXXXXXXX Poliambulatori XXXXXXXXXXXXX");
            Console.WriteLine("1) Input cognomi medici");
            Console.WriteLine("2) Visualizzazione tabella");
            Console.WriteLine("3) Ricerca tramite cognome" );
            Console.WriteLine("4) Ricerca tramite nome ambulatorio");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            do
            {
            Console.Write("Opzione scelta →");
            scelta = Convert.ToInt16(Console.ReadLine());

            if (scelta < 0 || scelta > 4)
            {
                Console.WriteLine("Scelta non consentita");
            }

            } while (scelta < 0 || scelta > 4);

            Console.Clear();
            switch (scelta)
            { 
                case 1:
                    input();
                    break;
            
            }
        }

        static void input()
        {
            string[][] dati = new string[2][];

            dati[0] = new string[1];
            dati[1] = new string[1];

            for(int i=0;i < dati.Length;i++)
            {
                for (int f = 0; f < dati[i].Length; f++)
                {
                    Console.Write("Inserisci cognome medico → ");
                    dati[i][f] = Console.ReadLine();

                }
            }

            for (int i = 0; i < dati.Length; i++)
            {
                for (int f = 0; f < dati[i].Length; f++)
                {
                    Console.Write("Inserisci nome ambulatorio → ");
                    dati[i][f] = Console.ReadLine();
                }
            }
        }//fine input
    }
}
