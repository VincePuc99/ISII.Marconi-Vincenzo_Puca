using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                DateTime date1 = DateTime.Now;
                Console.Clear();
                Console.WriteLine(date1);
                Thread.Sleep(1000);       
            }
        }
    }
}
