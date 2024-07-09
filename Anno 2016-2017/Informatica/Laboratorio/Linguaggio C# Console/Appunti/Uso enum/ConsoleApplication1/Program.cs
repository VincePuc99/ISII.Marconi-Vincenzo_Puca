using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TipoOrdinazione Ordine1 = TipoOrdinazione.Caffè;

            //for (TipoOrdinazione o = TipoOrdinazione.Caffè; o <= TipoOrdinazione.Aranciata; o++)
            //{
            //    Console.WriteLine(o.ToString());
            //}

            client c1 = new client();
            client c2 = new client("Alessandro", new int[] {1,2,3,4,5});
            c2.setnome("leonardo"); //passa la variabile
            c2.NOME = "Leonardo";
            Console.WriteLine(c2.getnome()); //richiama metodo
            Console.Write(c2.NOME);



            //Console.ReadLine();
            //// c2.stampaordinazioni();
            //c2 = null; //impostiamo l'indirizzo dell'oggetto c2 a null
            //Console.ReadLine();

        }//fine void
    }
}
