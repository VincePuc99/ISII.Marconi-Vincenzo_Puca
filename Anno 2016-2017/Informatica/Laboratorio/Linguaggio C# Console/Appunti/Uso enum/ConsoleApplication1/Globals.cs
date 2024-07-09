using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Globals
    { //solo le variabili nella classe globale devono essere inizializzati subito
        public static int[] array = new int[] { 1,2,3};
        public static client[] clienti = new client[]
        {
            new client("MARCO",new int [] {1,2,1}),
            null,
            null,
            null
        };
    }
}
