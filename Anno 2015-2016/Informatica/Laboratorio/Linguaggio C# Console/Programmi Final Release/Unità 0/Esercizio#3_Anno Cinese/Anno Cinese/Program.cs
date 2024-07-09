using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno_Cinese
{
    class Program
    {
        // Anno CINESE
        // By Rizza
        static void Main(string[] args)
        {
            // Dati

            int nascita = 0;
            int attuale = 0;
            string riavvio;
            
            // Input e controllo dati immessi dall'utente

            Restart:

            do
            {
                Console.Write("\nIn che anno sei nato: ");
                nascita = Convert.ToInt32(Console.ReadLine());

                if (nascita < 1971 || nascita > 2003)
                    Console.WriteLine("\nERRORE! Valore non riconosciuto\n");

            }
            while (nascita < 1971 || nascita > 2003);           

            do
            {
                Console.Write("\nAnno attuale: ");
                attuale = Convert.ToInt32(Console.ReadLine());

                if (attuale < 2015)
                    Console.WriteLine("\nERRORE! Non è questo l'anno attuale");
            }
            while (attuale < 2015);

            // Output
            
            Console.WriteLine("\n----------------------------------------");

            switch (nascita)
            {
                case 1971:
                    Console.Write("\nIl tuo segno zodiacale è il Maiale ");
                    break;

                case 1972:
                    Console.Write("\nIl tuo segno zodiacale è il Topo ");
                    break;

                case 1973:
                    Console.Write("\nIl tuo segno zodiacale è il Bue ");
                    break;

                case 1974:
                    Console.Write("\nIl tuo segno zodiacale è la Tigre ");
                    break;

                case 1975:
                    Console.Write("\nIl tuo segno zodiacale è il Coniglio ");
                    break;

                case 1976:
                    Console.Write("\nIl tuo segno zodiacale è il Serpente ");
                    break;

                case 1978:
                    Console.Write("\nIl tuo segno zodiacale è il Cavallo ");
                    break;

                case 1979:
                    Console.Write("\nIl tuo segno zodiacale è la Capra ");
                    break;

                case 1980:
                    Console.Write("\nIl tuo segno zodiacale è la Scimmia ");
                    break;

                case 1981:
                    Console.Write("\nIl tuo segno zodiacale è il Gallo ");
                    break;

                case 1982:
                    Console.Write("\nIl tuo segno zodiacale è il Cane ");                    
                    break;

                case 1983:
                    Console.Write("\nIl tuo segno zodiacale è il Maiale ");
                    break;

                case 1984:
                    Console.Write("\nIl tuo segno zodiacale è il Topo ");                    
                    break;

                case 1985:
                    Console.Write("\nIl tuo segno zodiacale è il Bue ");                    
                    break;

                case 1986:
                    Console.Write("\nIl tuo segno zodiacale è la Tigre ");                    
                    break;
                
                case 1987:
                    Console.Write("\nIl tuo segno zodiacale è il Coniglio ");                    
                    break;
                
                case 1988:
                    Console.Write("\nIl tuo segno zodiacale è il Drago ");                    
                    break;
                
                case 1989:
                    Console.Write("\nIl tuo segno zodiacale è il Serpente ");                    
                    break;
                
                case 1990:
                    Console.Write("\nIl tuo segno zodiacale è il Cavallo ");                    
                    break;
                
                case 1991:
                    Console.Write("\nIl tuo segno zodiacale è la Capra ");                    
                    break;

                case 1992:
                    Console.Write("\nIl tuo segno zodiacale è la Scimmia ");                    
                    break;
                
                case 1993:
                    Console.Write("\nIl tuo segno zodiacale è il Gallo ");                    
                    break;
                
                case 1994:
                    Console.Write("\nIl tuo segno zodiacale è il Cane ");                    
                    break;

                case 1995:
                    Console.Write("\nIl tuo segno zodiacale è il Maiale ");                    
                    break;
                
                case 1996:
                    Console.Write("\nIl tuo segno zodiacale è il Topo ");                    
                    break;

                case 1997:
                    Console.Write("\nIl tuo segno zodiacale è il Bue ");                    
                    break;

                case 1998:
                    Console.Write("\nIl tuo segno zodiacale è la Tigre ");                    
                    break;

                case 1999:
                    Console.Write("\nIl tuo segno zodiacale è il Coniglio ");                    
                    break;

                case 2000:
                    Console.Write("\nIl tuo segno zodiacale è il Drago ");                    
                    break;

                case 2001:
                    Console.Write("\nIl tuo segno zodiacale è il Serpente ");
                    break;

                case 2002:
                    Console.Write("\nIl tuo segno zodiacale è il Cavallo ");
                    break;

                case 2003:
                    Console.Write("\nIl tuo segno zodiacale è la Capra ");
                    break;
            }
                        
            Console.Write("ed hai {0} anni.\n", attuale - nascita);

            // Riavvio
            
            Console.WriteLine("\n----------------------------------------");
            
            Console.Write("\nVuoi riprovare (SI) o (NO) :  ");
            riavvio = Console.ReadLine();

            if (riavvio.ToUpper() == "NO")
            {
                return;
            }
            if (riavvio.ToUpper() == "SI")
            {
                Console.WriteLine("\n----------------------------------------");
                goto Restart;
            }             
        }
    }
}
