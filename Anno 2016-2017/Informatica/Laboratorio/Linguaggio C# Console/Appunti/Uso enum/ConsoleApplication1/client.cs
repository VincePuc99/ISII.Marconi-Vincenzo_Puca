using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class client
    {
        //attributi
        private string Nome;
        private int[] ordinazioni;


        //metodi

        //costruttori
        public client() //default
        {
            Nome = "";
            ordinazioni = null;
        }

        public client(string n, int[] o ) //overload
        {
            Nome = n;
            ordinazioni = o;
        }

        //distruttore
        //inizia con la tilde(alt-126)
        //~client()
        //{
        //    Console.WriteLine("\n\nmuoio\n\n");
        //}

        //proprietà
        public string getnome() { return Nome; }
        public void setnome(string n) { Nome = n; }

        //standard
        public string NOME
        {
            get { return Nome; }
            set { Nome = value; }
        }

        
        //metodi utente
        public void stampaordinazioni() 
        {
            if (ordinazioni != null)
            {
                for (int i = 0; i < ordinazioni.Length; i++)
                {
                    switch (ordinazioni[i])
                    {
                        case 1:
                            Console.WriteLine("Caffè");
                            break;

                        case 2:
                            Console.WriteLine("Cappuccino");
                            break;

                        case 3:
                            Console.WriteLine("Aranciata");
                            break;

                        default:
                            break;
                    }

                    //Console.WriteLine(ordinazioni[i]);
                }
            }
        }//fine void
    }
}
