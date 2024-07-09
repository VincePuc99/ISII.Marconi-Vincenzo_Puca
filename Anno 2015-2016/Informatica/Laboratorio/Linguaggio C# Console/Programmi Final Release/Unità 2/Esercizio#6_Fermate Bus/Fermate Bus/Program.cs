using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fermate_Bus
{
    class Program
    {
        static void Main(string[] args)
        {

            string dati = "#12:15@Via Rossi#12:20@Via Verdi#12:25@Via Terez";
            string d1 = "";
            string fermata;


            Console.WriteLine("Numero di fermate tot 3\n");
           
            Console.WriteLine("Orari fermate ");
            for (int i = 0; i < dati.Length; i++)
            {
                if(dati[i] == '#')
                {                  
                    d1 = dati.Substring(i + 1, 5);                                      
                }                          
            }            

            Console.WriteLine("\nNome delle fermate");
            for (int i = 0; i < dati.Length; i++)
            {
                if (dati[i] == '@')
                {
                    Console.WriteLine(dati.Substring(i + 1, 9));
                }
            }

            Console.WriteLine("\nTabella fermate");
            for (int i = 0; i < dati.Length; i++)
            {
                if (dati[i] == '#')
                {
                    Console.Write(dati.Substring(i + 1, 5) + " ");
                }
                if (dati[i] == '@')
                {
                    Console.WriteLine(dati.Substring(i + 1, 9));
                }             
            }
            Console.WriteLine("\n");
            do
            {
                Console.Write("Input fermata → ");
                fermata = Console.ReadLine();
                fermata = fermata.ToUpper();

                if (fermata != "VIA VERDI" && fermata != "VIA TEREZ" && fermata != "VIA ROSSI")
                {
                    Console.WriteLine("Nome via inesistente riprovare...");
                }

            } while (fermata != "VIA VERDI" && fermata != "VIA TEREZ" && fermata != "VIA ROSSI");
           
            int cont1 = 1, cont2 = 2, cont3 = 3, contot = 0;

            if (fermata == "VIA VERDI")
            {  
                contot = cont2 - cont1;
                Console.WriteLine("Dista da via rossi: {0}", contot);
                Console.Write("Arrivo in Via Verdi " + dati.Substring(17, 5) + "\n");

               
            }

            if (fermata == "VIA TEREZ")
            {
                contot = cont3 - cont1;
                Console.WriteLine("Dista da via rossi: {0}, arriverai lì alle → 12:25", contot);
                Console.Write("Arrivo in Via terez: {0} " + dati.Substring(33, 5) + "\n");

                
            }

            if (fermata == "VIA ROSSI")
            {
                Console.WriteLine("Sei già alla fermata di Via Rossi");
            }

            
            string arrivo;
            arrivo = Console.ReadLine();

            do
            {
                Console.Write("Input arrivo → ");
                arrivo = Console.ReadLine();
                arrivo = arrivo.ToUpper();

                if (arrivo != "VIA VERDI" && arrivo != "VIA TEREZ" && arrivo != "VIA ROSSI")
                {
                    Console.WriteLine("Nome via inesistente riprovare...");
                }

            } while (arrivo != "VIA VERDI" && arrivo != "VIA TEREZ" && arrivo != "VIA ROSSI");

           
            if (arrivo == "VIA ROSSI")
            {
                Console.WriteLine("Sei già a destinazione!!!");
            }

            if (fermata == "VIA VERDI")
            {
                if (arrivo == "VIA TEREZ")
                {
                    Console.WriteLine("Tempo di percorrenza 10 minuti");
                }
            }

            if (fermata == "VIA TEREZ")
            {
                if (arrivo == "VIA VERDI")
                {
                    Console.WriteLine("Tempo di percorrenza -5 minuti");
                }
            }


        }
    }
}
