using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Prove
{
    class Program
    {
        int p = 22; //questa variabile può essere usata in tutti i metodi si chiama variabile globale

        static void Main(string[] args)   //metodo nel quale il sistema entra per primo
        {
            int x = 0;  //funziona solo nel metodo main se dichiarata qui   //variabile locale nel metodo main   //parametro effettivo
            int y = 0, z = 0;
            Stampa(x);  //da qui salta al metodo scelto terminato stampa ritorna qui
            x++;
            Stampa(x);  //rifà il metodo stampa
            y++;

            z = incrementa(x);  //il valore espulso va in Z            
        }

        //qui scrivo cosa fa il metodo 
        static void Stampa(int valore )           //parametro formale  
            //nome del metodo    //non dare mai a questi parametri lo stesso nome delle variabili nei metodi precedenti        
            //eventuali parametri nelle () 
            //se il metodo non deve dare nessun valore scrivo void 
        {         
             Console.WriteLine(valore);
        }

        //incrementa il valore e lo restituisce
        static int incrementa (int valore)   
        {
            int p = 21;      //questa variabile è vista soltanto in questo metodo
            valore++;
            return valore;   //espelle il valore //puo esserci solo una variabile
        }

    }
}
