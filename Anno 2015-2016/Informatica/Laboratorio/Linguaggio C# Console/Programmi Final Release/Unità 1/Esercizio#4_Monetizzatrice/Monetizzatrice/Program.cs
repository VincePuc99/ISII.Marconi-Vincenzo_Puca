using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Monetizzatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            int conterr = 0;
            int monete2, monete1, monete050, monete020, monete010, monete005, monete002, monete001;
            Random mon = new Random();
            int banconota;

            do
            {

                monete2 = mon.Next(1, 11);
                monete1 = mon.Next(1, 21);
                monete050 = mon.Next(1, 101);
                monete020 = mon.Next(1, 201);
                monete010 = mon.Next(1, 501);
                monete005 = mon.Next(1, 1001);
                monete002 = mon.Next(1, 2001);
                monete001 = mon.Next(1, 2001);


                Console.Clear();
                Console.WriteLine("============Monetizzatrice========");
                Console.WriteLine("Menù funzioni");
                Console.WriteLine("==================================");
                Console.WriteLine("\t1) Ripristino magazzino monete");
                Console.WriteLine("\t2) Visualizzazione stato magazzino monete");
                Console.WriteLine("\t3) Accettazione banconota e suo monetizzazione");
                Console.WriteLine("\t4) spegnimento ");
                Console.WriteLine("==================================");

                
                    Console.WriteLine("Inserire il numero della scelta: ");
                    scelta = Convert.ToInt32(Console.ReadLine());
                    if (scelta < 1 || scelta > 4)
                    {
                        Console.WriteLine("Scelta inesistente riprovare...");
                        conterr++;
                    }
                    if (conterr == 3)
                    {
                        Console.WriteLine("Limite tentativi raggiunto, chiusura...");
                        break;
                    }
                } while (scelta < 1 || scelta > 4);

                Thread.Sleep(1500);
                Console.Clear();

                switch (scelta)
                {
                    case 1:
                        monete2 = mon.Next(1, 11);
                        monete1 = mon.Next(1, 21);
                        monete050 = mon.Next(1, 101);
                        monete020 = mon.Next(1, 201);
                        monete010 = mon.Next(1, 501);
                        monete005 = mon.Next(1, 1001);
                        monete002 = mon.Next(1, 2001);
                        monete001 = mon.Next(1, 2001);
                        Console.WriteLine("Ripristino eseguito");
                        break;


                    case 2:
                        Console.WriteLine("\n\n============Monetizzatrice========");
                        Console.WriteLine("Magazzino");
                        Console.WriteLine("==================================");
                        Console.WriteLine("\t{0} monete da 2 euro", monete2);
                        Console.WriteLine("\t{0} monete da 1 euro", monete1);
                        Console.WriteLine("\t{0} monete da 50 centesimi", monete050);
                        Console.WriteLine("\t{0} monete da 20 centesimi", monete020);
                        Console.WriteLine("\t{0} monete da 10 centesimi", monete010);
                        Console.WriteLine("\t{0} monete da 5 centesimi", monete005);
                        Console.WriteLine("\t{0} monete da 2 centesimi", monete002);
                        Console.WriteLine("\t{0} monete da 1 centesimo", monete001);
                        Console.WriteLine("==================================");
                        break;

                    case 3:

                        do
                        {
                            Console.WriteLine("================= Monetizzatrice ==================");
                            Console.WriteLine("\tAccettazione banconota e sua monetizzazione");                            
                            Console.Write("Inserire il valore della banconota da monetizzare: ");
                            banconota = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("===================================================");

                            if (banconota != 5 && banconota != 10 && banconota != 20 && banconota != 50)
                            {
                                Console.WriteLine("Banconota inesistente riprovare...");
                            }
                        } while (banconota != 5 && banconota != 10 && banconota != 20 && banconota != 50);

                        Console.WriteLine("Importo monetizzato in ");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                        }

                        if (banconota == 5)
                        {                            
                            Console.WriteLine("2 monete da 2 euro, 1 moneta da 1 euro");
                            monete2 -= 2;
                            monete1 -= 1;
                        }

                        if (banconota == 10)
                        {
                            Console.WriteLine("5 monete da 2 euro, 1 moneta da 1 euro");
                            monete2 -= 5;

                        }

                        if (banconota == 20)
                        {
                            Console.WriteLine("10 monete da 2 euro");
                            monete2 -= 10;
                        }

                        if (banconota == 50)
                        {
                            Console.WriteLine("25 monete da 2 euro");
                            monete2 -= 25;
                        }

                        break;

                    case 4:
                        return;
   
                }

            
        }
    }
}
