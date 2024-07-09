using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpoDocenti;//va messo se si rinomina il namespace senza fare rename (va messo in tutte le classi dove è presente)

namespace ArrayDiOggetti
{
    class Program
    {
        static void Main(string[] args)
        {
            //vecchio metodo di inizializzazione dell'array
            //Insegnante Zucchini = new Insegnante("Zucchini"); //la stringa rappresenta il cognome (string) mentre Zucchini rappresenta il nome della classe
            //Insegnante Veneziani = new Insegnante("Venezianini"); 
            //int a = MyLibrary.Somma(2, 4);

            //nuovo metodo di inizializzazione dell'array
            Global.i = 0;
            Global.Proff[0] = new Insegnante("Zucchini");
            Global.i++;
            Global.Proff[1] = new Insegnante("Venezianini");
            Global.i++;

            Global.Proff[0] = null;//ammazza prof0 (lo rende nullo)

            Global.Proff[1].COGNOME = "Giorgi"; //cambia il nome (la proprietà) in: Giorgi 

            //Global.i contiene il numero degli insegnanti (che ho instanziato)

        }
    }
}
