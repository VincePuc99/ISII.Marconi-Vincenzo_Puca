using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diplomati
{
    class Program
    {
        static void Main(string[] args)
        {
            string collegamento = @"C:\Users\m_inf2.quarta\Desktop\diplomati.txt";
            InputAllievi(collegamento);
        }

        static void InputAllievi(string coll)
        {
            int voto, cont = 0;
            string scelta, nome, cognome;
            StreamWriter scrivi = new StreamWriter(coll,false);
            do
            {
                
                Console.WriteLine("Inserire il cognome dell alievo: ");
                cognome = Console.ReadLine().ToLower();
                scrivi.Write(cognome + " ");

                Console.WriteLine("Inserire il nome dell alievo: ");
                nome = Console.ReadLine().ToLower();
                scrivi.Write(nome + " (voto: ");

                do
                {
                    Console.WriteLine("Inserire il voto dell alievo: ");
                    voto = Convert.ToInt16(Console.ReadLine());
                    if (voto < 0 || voto > 110)
                    {
                        Console.WriteLine("Voto non valido");
                    }

                } while (voto < 0 || voto > 110);

                scrivi.Write(voto + ")");

                Console.WriteLine("Hai finito? (SI)-(NO)");
                scelta = Console.ReadLine().ToUpper();
                scrivi.WriteLine();
                cont++;
                if (scelta == "SI")
                {
                    continue;
                }
            } while (scelta == "NO");
            scrivi.Close();

            VisualizzaElenco(coll,cont);
        }


        static void VisualizzaElenco(string coll,int cont)
        {
           
            Console.Clear();
            Console.WriteLine("######### Visualizzazione Allievi #########");
            StreamReader sr = new StreamReader(coll);
            String Riga;
            while ((Riga = sr.ReadLine()) != null)
                Console.WriteLine(Riga);
            sr.Close();
            Console.WriteLine("###########################################");
            CercaAllievo(coll, cont);
     
        }

        static void CercaAllievo(string coll,int cont)
        {
            string cognome;
            string[] container = new string[cont];

            Console.Write("Inserisci il cognome dell'allievo da cercare:");
            cognome = Console.ReadLine();

            StreamReader sr = new StreamReader(coll);
            string a, trovato= "";

            for (int i = 0; i < container.GetLength(0); i++)
            {
                container[i] = sr.ReadLine();
                a = container[i];

                for(int s = 0; s < a.Length; s++)
                {
                    if (a[s] == ' ')
                    {
                       trovato = a.Substring(0, s);
                       goto fine;
                    }
                }
               fine:
                if (cognome == trovato)
                {
                    Console.WriteLine(container[i]);
                    return;
                }

                if (cognome != trovato)
                {
                    Console.WriteLine("Cognome non trovato");
                    return;
                }
            }

            sr.Close();
     
        }//fine metodo




    }
}
