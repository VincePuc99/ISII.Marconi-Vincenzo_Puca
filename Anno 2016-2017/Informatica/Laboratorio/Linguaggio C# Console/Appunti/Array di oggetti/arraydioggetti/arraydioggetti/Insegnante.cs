using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpoDocenti
{
    class Insegnante
    {
        private string Cognome="";
        //Proprietà
        public string COGNOME
        {
        get { return Cognome; }
        set { Cognome = value; }
        }
        //Metodi
        //Costruttori di default
        public Insegnante() { Cognome = "";    }

        //Costruttori di Overload
        public Insegnante(string c) { Cognome = c; }
        }


        ////Distruttore
        //~

    
}
