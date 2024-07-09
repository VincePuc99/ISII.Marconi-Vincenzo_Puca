using System;

namespace Ereditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(1, 1.1);
            Classederivata c = new Classederivata(2,2,"s");
            Console.WriteLine(b.A +" "+b.B);
            Console.WriteLine(c.S +" "+ c.A +" "+ c.B);
        }
    }
}
