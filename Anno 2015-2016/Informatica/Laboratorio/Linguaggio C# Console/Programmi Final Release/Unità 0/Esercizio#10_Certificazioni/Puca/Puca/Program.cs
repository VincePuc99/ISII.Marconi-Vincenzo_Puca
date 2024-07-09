using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puca
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABILI

            int calcM1 = 1;
            int calcM2 = 2;
            int calcM3 = 2;
            string scelta;
            bool control = false;

            // INPUT

            do
            {
                Console.WriteLine("Quale esame vuoi sostenere? (M1,M2,M3)");
                scelta = Console.ReadLine();

                scelta = scelta.ToUpper();
                if (scelta == "M1" || scelta == "M2" || scelta == "M3")
                {
                    //CALCOLO M1
                    if (scelta == "M1")
                    {

                        if (calcM1 == 0)
                            Console.WriteLine("Non ci sono calcolatori disponibili per l'esame M1");
                        else
                            calcM1--;
                    }

                    //CALCOLO M2
                    if (scelta == "M2")
                    {

                        if (calcM2 == 0)
                            Console.WriteLine("Non ci sono calcolatori disponibili per l'esame M2");
                        else
                            calcM2--;
                    }

                    //CALCOLO M3
                    if (scelta == "M3")
                    {

                        if (calcM3 == 0)
                            Console.WriteLine("Non ci sono calcolatori disponibili per l'esame M3");
                        else
                            calcM3--;
                    }

                    //CALCOLATORI FINITI
                    if (calcM1 + calcM2 + calcM3 == 0)
                    {
                        Console.WriteLine("L'aula è piena!!!");
                        Console.WriteLine("Programma terminato!");                        
                        control = true;                        
                    }                    
                }                
               
            } while (control == false);

            Console.ReadKey();
        }
    }
}
