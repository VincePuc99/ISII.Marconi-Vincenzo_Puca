using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eercizio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area Dichiarazione dati
            int bas = 0; //base della potenza
            int esponente = 0; // esponente della potenza 
            int potenza = 1; //risultato
            
            //Input 
            Console.WriteLine( "inserire il valore della base");
            bas=Convert.ToInt32(Console.ReadLine()); //lettura da tastiera

            Console.WriteLine("inserire valore dell'esponente :");
            esponente=Convert.ToInt32(Console.ReadLine()); //lettura da tastiera

            //controllo della correttezza del valore della base
            if(bas>0 || esponente>0)
            {

                //elaborazione            
                
                for (int i = 0; i < esponente; i++)
                        {
                            potenza = potenza * bas;
                        }

            }
                    
            //output
            Console.WriteLine("il risultato è: {0}", potenza);
            Console.ReadKey();

        }   
    }
}
