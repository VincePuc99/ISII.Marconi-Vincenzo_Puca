using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treni
{
    class Program
    {
        static void Main(string[] args)
        {
            //area dati
            string dati = "#Bologna@09:00#Modena@09.15#Reggio@09.25#Parma@9.40#Piacenza@10.05#Milano@10.55";            
            string[] parole = dati.Split('#');
            DateTime OraPartenza, OraArrivo;
            int shindex = 0;
            int atindex = 0;



            //elaborazione
            Console.WriteLine("Treno Bologna-Milano");
            Console.WriteLine("==========================================");

            foreach (string parola in parole)
            {
                Console.WriteLine(parola.Replace("@", "\t\t"));
                
            }

            Console.WriteLine("==========================================");

            Console.WriteLine("<INVIO> per continuare");
            Console.ReadKey();

            Console.Clear();
            //bologna milano
            Console.WriteLine("\n\nTreno Bologna-Milano");
            Console.WriteLine("==========================");

            atindex = dati.IndexOf('@', 0);
            DateTime.TryParse(dati.Substring(atindex + 1, 5), out OraPartenza);
            atindex = dati.LastIndexOf('@');

            DateTime.TryParse(dati.Substring(atindex + 1, 5), out OraArrivo);
            Console.WriteLine("Tempo totale di percorrenza (hh.mm.ss): {0}", OraArrivo - OraPartenza);

            Console.ReadKey();
            Console.Clear();
            //intertempo
            Console.Write("\n\nSpecificare la stazione di partenza: ");
            string StazPartenza = Console.ReadLine();
            Console.Write("Specificare la stazione di arrivo: ");
            string StazArrivo = Console.ReadLine();

            shindex = dati.IndexOf(StazPartenza, 0);
            atindex = dati.IndexOf(StazArrivo, 0);

            shindex = dati.IndexOf('@', shindex + 1);
            atindex = dati.IndexOf('@', atindex + 1);

            DateTime.TryParse(dati.Substring(shindex + 1, 5), out OraPartenza);
            DateTime.TryParse(dati.Substring(atindex + 1, 5), out OraArrivo);
            Console.WriteLine("Tempo totale di percorrenza (hh.mm.ss): {0}", OraArrivo - OraPartenza);

    
        }
    }
}
