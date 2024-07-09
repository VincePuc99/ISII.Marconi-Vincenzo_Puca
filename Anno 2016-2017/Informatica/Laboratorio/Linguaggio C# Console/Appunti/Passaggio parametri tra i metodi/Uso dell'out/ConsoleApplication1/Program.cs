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
            int x;
            input(out x);
            Console.WriteLine(x);
        }
        static void input(out int y) //out è mono direzionale cioè posso solo ricevere dati dal metodo scelto 
        {
            y = 33;
        }
    }
}
