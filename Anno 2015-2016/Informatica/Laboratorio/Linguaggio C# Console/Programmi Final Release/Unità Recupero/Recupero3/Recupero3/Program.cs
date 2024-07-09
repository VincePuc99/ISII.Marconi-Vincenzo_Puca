using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupero3
{
    class Program
    {
        static void Main(string[] args)
        {
            string assembly = "#NOP#90#MOV AX,0000#BB 0000#MOV BX,0000#B8 0000#INC AX#D2#INC BX#C2#";
            int scelta;
            bool stampa = false;
            string agg;
            int operativo;
            string agg1;

            Console.WriteLine("\n1) Visualizzare l’intera stringa inserita");
            Console.WriteLine("2) Visualizzare l’intero programma solo in formato Assembly 80x86");
            Console.WriteLine("3) Visualizzare l’intero programma solo in formato linguaggio macchina");
            Console.WriteLine("4) Consentire l’inserimento di una nuova istruzione (Assembly 80x86) con la seguente traduzione in linguaggio macchina");
            Console.WriteLine("5) Consentire la cancellazione di una istruzione una volta specificato il suo codice operativo");
            Console.WriteLine("6) Consentire la modifica di un’istruzione già presente specificandone il codice operativo\n");
            Console.Write("Inserire l'opzione desiderata → ");
            scelta= Convert.ToInt16(Console.ReadLine()); 
                

            switch(scelta)
            {

            case 1:
                    for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            assembly = assembly.Replace("#"," ");
                            Console.WriteLine(assembly);
                        }
                    }                   
                    break;

            case 2:
                    for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            if (stampa == true)
                            {
                                stampa = false;  // spengo la stampante
                                Console.WriteLine();
                            }
                            else
                                stampa = true;  // spengo la stampante                       
                        }

                        if (stampa == true)
                        {
                            if (assembly[i] != '#')
                                Console.Write(assembly[i]);
                        }
                    }
                    break;
            case 3:
                    
           for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            if (stampa == false)
                            {
                                stampa = true; 
                                Console.WriteLine();
                            }
                            else
                                stampa = false;                      
                        }

                        if (stampa == false)
                        {
                            if (assembly[i] != '#')
                                Console.Write(assembly[i]);
                        }
                    }
                    break;

        
            case 4:

                   Console.Write("Inserisci un istruzione assembly: ");
                   agg = Console.ReadLine();
                   assembly = assembly.Insert(68, agg);

                    for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            assembly = assembly.Replace("#"," ");
                           
                        }
                    }                   
                    
                   Console.WriteLine(assembly);
                    

                    break;
            case 5:

                    for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            assembly = assembly.Replace("#"," ");
                            Console.WriteLine(assembly);
                        }
                    }

                    Console.WriteLine("Ogni numero corrisponde ad una istruzione da rimuovere");
                    Console.WriteLine("Inserire un codice operativo(da 1 a 5): ");
                    operativo = Convert.ToInt16(Console.ReadLine());

                    
                   if (operativo == 1)
                   {
                       assembly = assembly.Remove(0, 7);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 2)
                   {
                       assembly = assembly.Remove(7,27);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 3)
                   {
                       assembly = assembly.Remove(27, 48);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 4)
                   {
                       assembly = assembly.Remove(48, 58);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 5)
                   {
                       assembly = assembly.Remove(58, 68);
                       Console.WriteLine(assembly);
                   }
                                 
                        break;
            case 6:
                    for (int i = 0; i < assembly.Length; i++)
                    {
                        if (assembly[i] == '#')
                        {
                            assembly = assembly.Replace("#"," ");
                            Console.WriteLine(assembly);
                        }
                    }

                    Console.WriteLine("Ogni numero corrisponde ad una istruzione da rimuovere");
                    Console.WriteLine("Inserire un codice operativo(da 1 a 5): ");
                    operativo = Convert.ToInt16(Console.ReadLine());

                    
                   if (operativo == 1)
                   {
                       assembly = assembly.Remove(0, 7);
                       Console.Write("Inserire cosa si vuole aggiungere a questo posto: ");
                       agg1 = Console.ReadLine();
                       assembly = assembly.Insert(0, agg1);
                       Console.WriteLine(assembly);
                       
                   }

                   if (operativo == 2)
                   {
                       assembly = assembly.Remove(7,27);
                       Console.Write("Inserire cosa si vuole aggiungere a questo posto: ");
                       agg1 = Console.ReadLine();
                       assembly = assembly.Insert(7, agg1);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 3)
                   {
                       assembly = assembly.Remove(27, 48);
                       Console.Write("Inserire cosa si vuole aggiungere a questo posto: ");
                       agg1 = Console.ReadLine();
                       assembly = assembly.Insert(27, agg1);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 4)
                   {
                       assembly = assembly.Remove(48, 58);
                       Console.Write("Inserire cosa si vuole aggiungere a questo posto: ");
                       agg1 = Console.ReadLine();
                       assembly = assembly.Insert(48, agg1);
                       Console.WriteLine(assembly);
                   }

                   if (operativo == 5)
                   {
                       assembly = assembly.Remove(58, 68);
                       Console.Write("Inserire cosa si vuole aggiungere a questo posto: ");
                       agg1 = Console.ReadLine();
                       assembly = assembly.Insert(58, agg1);
                       Console.WriteLine(assembly);
                   }
                                 
                        break;

            }
        }
    }
}
