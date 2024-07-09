using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpoDocenti;//va messo se si rinomina il namespace senza fare rename (va messo in tutte le classi dove è presente)


namespace ArrayDiOggetti
{
    class Global
    {
        //Variabili Globali
        public static int i = 0; //si può inizializzare perchè globale
        public static Insegnante[] Proff = new Insegnante[2];

    }
}
