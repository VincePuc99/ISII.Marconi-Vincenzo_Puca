using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo mossa;
            int scelta = 0;
            string punt1 = "", punt2 = "";
            char i;            
            Random a = new Random();

            punt1 = "►";

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("{0} 1) Esegui il programma", punt1);
                    Console.WriteLine("{0} 2) Chiudi il programma\n", punt2);
                    mossa = Console.ReadKey();

                    if (mossa.Key == ConsoleKey.Enter)
                    {
                        if (punt1 == "☻")
                        {
                            scelta = 1;
                            break;
                        }
                        if (punt2 == "☻")
                        {
                            scelta = 2;
                            break;
                        }

                    }

                    switch (mossa.Key)
                    {
                        case ConsoleKey.UpArrow:

                            if (punt1 == "►")
                            {
                                punt1 = "";
                                punt2 = "►";
                            }
                            if (punt2 == "►")
                            {                                
                                punt1 = "►";
                                punt2 = "";

                            }

                            break;

                        case ConsoleKey.DownArrow:

                            if (punt2 == "►")
                            {
                                punt1 = "►";
                                punt2 = "";                                
                            }
                            if (punt1 == "►")
                            {
                                punt1 = "";
                                punt2 = "►";
                            }

                            break;
                    }
                } while (true);


                switch (scelta)
                {
                    case 1:
                        for (int j = 0; j < 5; j++)
                        {
                            i = Convert.ToChar(a.Next(65, 91));
                            i = Convert.ToChar(a.Next(97, 123));
                            Console.Write(i);
                            System.Threading.Thread.Sleep(100);
                        }

                        Console.WriteLine("\n\n\nPremi <INVIO>");
                        Console.ReadLine();

                        continue;

                    case 2:
                        return;

                }
            } while (true);
            
        }
    }
}
