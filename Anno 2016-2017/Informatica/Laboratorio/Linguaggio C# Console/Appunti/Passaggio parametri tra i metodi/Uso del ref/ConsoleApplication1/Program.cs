﻿using System;
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
          int a = 0;
          valore(ref a);
        Console.WriteLine(a);

        }
        static void valore (ref int a)
       {
        a++; 
       }

    }
}
