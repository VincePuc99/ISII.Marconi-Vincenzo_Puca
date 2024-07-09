using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nascita dell'istanza dell'oggetto punto
            Punto P;            //dichiarazione
            P = new Punto();    //istanza

            //Nascita della seconda istanza chiamata P2
            Punto P2;
            P2 = new Punto(2,4);

            Console.WriteLine("{0}-{1}",P.GetX(),P.GetY());
            Console.WriteLine("{0}-{1}", P2.GetX(), P2.GetY());

            //incrementa x e y di P ma non x e y di P2

            P.IncX();
            P.IncY();

            Console.WriteLine("{0}-{1}", P.GetX(), P.GetY());
            Console.WriteLine("{0}-{1}", P2.GetX(), P2.GetY());


        }
    }
}
