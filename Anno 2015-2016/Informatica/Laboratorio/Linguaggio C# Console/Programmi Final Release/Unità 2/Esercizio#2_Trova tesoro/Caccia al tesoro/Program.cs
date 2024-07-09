using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Caccia_al_tesoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int righe, colonne, passi;
            int righep, colonnep, conterr = 0;
            string scelta;

            righe = r.Next(1, 26);
            colonne = r.Next(1, 80);
            righep = r.Next(1, 26);
            colonnep = r.Next(1, 80);

            Console.WriteLine("=============================================");
            Console.WriteLine("              CACCIA AL TESORO               ");
            Console.WriteLine("=============================================");
            Console.Write("Calcolatore: Sto nascondendo il tesoro");
            Thread.Sleep(550);
            Console.Write(".");
            Thread.Sleep(550);
            Console.Write(".");
            Thread.Sleep(550);
            Console.WriteLine(".");
            Console.Write("Esploratore: Sbarco sull'isola in una posizione non nota");
            Thread.Sleep(550);
            Console.Write(".");
            Thread.Sleep(550);
            Console.Write(".");
            Thread.Sleep(550);
            Console.WriteLine(".\n");
            do
            {
                Console.Write("Calcolatore: In che posizione vuoi andare? (N,S,E,O): ");
                scelta = Console.ReadLine();
                scelta = scelta.ToUpper();

                Console.Write("Calcolatore: Di quanti passi ti vuoi spostare?(1,10): ");
                passi = Convert.ToInt32(Console.ReadLine());
                if (passi > 10 || passi < 1)
                {
                    Console.WriteLine("Quantità di passi non disponibile Riprova!");
                }
               
                if (scelta != "N" && scelta != "S" && scelta != "O" && scelta != "E")
                {
                    Console.WriteLine("Coordinate inesistenti,riprova!");
                }
                if (scelta == "N")
                {
                    righep += passi;
                    conterr++;
                }
                if (scelta == "S")
                {
                    righep -= passi;
                    conterr++;
                }
                if (scelta == "E")
                {
                    colonnep += passi;
                    conterr++;
                }
                if (scelta == "O")
                {
                    colonnep -= passi;
                    conterr++;
                }
                if (conterr == 20)
                {
                    Console.WriteLine("il tesoro non è stato trovato");
                    return;
                }

                if (righep == righe && colonnep == colonne)
                {
                    Console.WriteLine(">>>>>>>>>>> HAI TROVATO IL TESORO !!! <<<<<<<<<<");
                    Console.WriteLine("Lo hai trovato in {0} tentativi!",conterr);
                    return;
                }


                if (righep + colonnep > righe + colonne)
                {
                    Console.WriteLine("Sei in avanti!!");
                }

                if (righep + colonnep < righe + colonne)
                {
                    Console.WriteLine("Sei in dietro!!");
                }
                
                //posizione tesoro
                //Console.WriteLine("{0}.{1}",righe,colonne);
                //posizione player
               // Console.WriteLine("{0}.{1}", righep,colonnep);

            } while (true);







        }
    }
}
