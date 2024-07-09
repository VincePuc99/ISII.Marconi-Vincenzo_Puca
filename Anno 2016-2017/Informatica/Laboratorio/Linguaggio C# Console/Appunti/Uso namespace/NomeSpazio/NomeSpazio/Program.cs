using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dirigenti.Ispettori;
using Dirigenti;
using Amministrazione;

namespace NomeSpazio
{
    class Program
    {//i namespace non son classi ma insiemi!!
        static void Main(string[] args)
        {
            Dirigenti.Preside Monti = new Dirigenti.Preside();
            Amministrazione.Impiegato Elisa = new Amministrazione.Impiegato();
            Dirigenti.Ispettori.IspettoeGenerale IS = new Dirigenti.Ispettori.IspettoeGenerale(); //using Dirigenti.Ispettori;  using Dirigenti   using amministrazione
        }
    }
}
