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
            int x = 0, y = 0;
            y = valore(x);
            Console.WriteLine(y);
        }

        static int valore(int c)
        {
            
            c++;
            return c;
        }
    }
}
