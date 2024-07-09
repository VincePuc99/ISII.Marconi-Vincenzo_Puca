using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sillabatore
{
    class Program
    {
        static void Main(string[] args)
        {
            string messaggio, messaggio1, messaggio2, messaggio3;
            try
            {
                Console.WriteLine("Inserire una parola a scelta: ");
                messaggio = Console.ReadLine();
                messaggio = messaggio.ToLower();
                messaggio1 = messaggio.Substring(0);
                messaggio2 = messaggio.Substring(0);
                messaggio3 = messaggio.Substring(0);


                //1 regola
                for (int i = 0; i < messaggio.Length; i++)
                {

                    if (messaggio[i] == messaggio[i + 1])
                    {
                        messaggio = messaggio.Insert(i + 1, "-");
                        Console.WriteLine("Regola n.ro 1: {0}", messaggio);

                    }

                }
                //2 regola
                for (int i = 0; i < messaggio1.Length; i++)
                {

                    if (messaggio1[i] == 'c')
                    {
                        if (messaggio1[i + 1] == 'q')
                        {
                            messaggio1 = messaggio1.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 2: {0}", messaggio1);
                        }
                    }
                }
                //3 regola
                for (int i = 0; i < messaggio2.Length; i++)
                {

                    if (messaggio2[i] == 'a')
                    {
                        if (messaggio2[i - 1] != 'a')
                        {
                            messaggio2 = messaggio2.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 3: {0}", messaggio2);
                        }
                    }
                    if (messaggio2[i] == 'e')
                    {
                        if (messaggio2[i - 1] != 'e')
                        {
                            messaggio2 = messaggio2.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 3: {0}", messaggio2);
                        }
                    }
                    if (messaggio2[i] == 'i')
                    {
                        if (messaggio2[i - 1] != 'i')
                        {
                            messaggio2 = messaggio2.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 3: {0}", messaggio2);
                        }
                    }
                    if (messaggio2[i] == 'o')
                    {
                        if (messaggio2[i - 1] != 'o')
                        {
                            messaggio2 = messaggio2.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 3: {0}", messaggio2);
                        }
                    }
                    if (messaggio2[i] == 'u')
                    {
                        if (messaggio2[i - 1] != 'u')
                        {
                            messaggio2 = messaggio2.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 3: {0}", messaggio2);
                        }
                    }
                }

                //regola 4
                for (int i = 0; i < messaggio3.Length; i++)
                {
                    if (messaggio3[i] == 'l')
                    {
                        if (messaggio3[i + 1] != 'a' || messaggio3[i + 1] != 'e' || messaggio3[i + 1] != 'i' || messaggio3[i + 1] != 'o' || messaggio3[i + 1] != 'u')
                        {
                            messaggio3 = messaggio3.Insert(i + 1, "-");
                            Console.WriteLine("Regola n.ro 4: {0}", messaggio3);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("Fine programma");
            }
        }
    }
}
