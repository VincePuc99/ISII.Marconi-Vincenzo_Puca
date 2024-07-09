using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string messaggio1;
            string est;
            bool sn = false;

            do
            {
                Console.WriteLine("Inserire una sequenza di simboli (punto-linea)");
                Console.WriteLine("!ATTENZIONE! All'inizio e alla fine dei simboli devono esserci degli spazi: \n");
                messaggio1 = Console.ReadLine();
                est = messaggio1.Substring(0, 1);
                sn = messaggio1.EndsWith(" ");

                if (est != " " && messaggio1 != "." && messaggio1 != "_" && sn == false)
                {
                    Console.WriteLine("Non hai rispettato delle regole riprova!!!");
                }

            } while (est != " " && messaggio1 != "." && messaggio1 != "_" && sn == true);



            for (int i = 0; i < messaggio1.Length; i++)
            {
                if (messaggio1[i] == '.')
                {
                    if (messaggio1[i + 1] == '_')
                    {
                        Console.WriteLine("A");
                    }
                } 
                    //f
                    if (messaggio1[i ] == '.')
                    {
                        if (messaggio1[i + 1] == '.')
                        {
                            if (messaggio1[i + 2] == '_')
                            {
                                if (messaggio1[i + 3] == '.')
                                {
                                    Console.WriteLine("F");
                                }
                            }
                        }
                    }

            }

            




        }
    }
}




        