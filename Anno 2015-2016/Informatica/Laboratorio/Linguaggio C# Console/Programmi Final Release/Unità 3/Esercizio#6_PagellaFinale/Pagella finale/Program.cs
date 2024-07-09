using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagella_finale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allievi = new string[3];
            string[] materie = new string[4];
            int[,] voti = new int[3, 4];
            int cont = 0, cont1 = 0;

            //allievi
            for (int i = 0; i < 3; i++)
            {
                cont++;
                Console.Write("Inserisci il cognome del {0}° allievo: ", cont);
                allievi[i] = Console.ReadLine();
            }
            //materie
            for (int i = 0; i < 4; i++)
            {
                cont1++;
                Console.Write("Inserisci il nome della {0}° materia: ", cont1);
                materie[i] = Console.ReadLine();
            }

            //voti
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    do
                    {
                        Console.Write("Inserire il voto dell' allievo {0} in {1}: ", allievi[i], materie[j]);
                        voti[i, j] = Convert.ToInt16(Console.ReadLine());
                        if (voti[i, j] < 0 || voti[i, j] > 10)
                        {
                            Console.WriteLine("VOTO NON VALIDO");
                        }

                    } while (voti[i, j] < 0 || voti[i, j] > 10);
                }

            }


            //tabellone
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("   Tabellone di fine anno scolastico  ");
            Console.WriteLine("======================================");

            Console.Write("Allievo\t");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t", materie[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}\t", allievi[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t\t", voti[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            //input pagella
            Console.Clear();
            string nome;

            Console.Write("Inserire il cognome dell'allievo da ricercare: ");
            nome = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (nome == allievi[i])
                    {
                        Console.WriteLine("{0} ha preso {1} in {2}", nome, voti[i, j], materie[j]);
                    }
                }
            }
            Console.ReadLine();
            //modifica voto
            Console.Clear();
            string materiamod;

            Console.Write("Inserire il cognome dell'allievo da ricercare: ");
            nome = Console.ReadLine();

            Console.Write("Inserire la materia con il voto da modificare: ");
            materiamod = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (nome == allievi[i])
                    {
                        if (materiamod == materie[j])
                        {
                            Console.Write("Inserisci il nuovo voto: ");
                            voti[i, j] = Convert.ToInt16(Console.ReadLine());
                        }
                        
                    }
                }
            }
            Console.ReadLine();
            //media crediti
           
            int medie = 0, medie1 = 0, medie2 = 0;
            int [] med = new int[3];


            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    medie += voti[i, j];
                }
            }

            medie = medie / 4;
            Console.WriteLine("Media {0} di {1}",medie,allievi[0]);
            med[0] = medie;

            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    medie1 += voti[i, j];
                }
            }

            medie1 = medie1 / 4;
            Console.WriteLine("Media {0} di {1}",medie1,allievi[1]);
            med[1] = medie1;

            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    medie2 += voti[i, j];
                }
            }

            medie2 = medie2 / 4;
            Console.WriteLine("Media {0} di {1}",medie2,allievi[2]);
            med[2] = medie2;

            //crediti assegnazione

            for (int i = 0; i < 3; i++)
            {
                if (med[i] < 6)
                {
                    Console.WriteLine("Nessun credito per {0}", allievi[i]);
                }
                else if (med[i] >= 6 && med[i] <= 7)
                {
                    Console.WriteLine("1 credito per {0}", allievi[i]);
                }
                else if (med[i] > 7 && med[i] <= 8)
                {
                    Console.WriteLine("2 crediti per {0}", allievi[i]);
                }
                else if (med[i] > 8 && med[i] <= 10)
                {
                    Console.WriteLine("3 crediti per {0}", allievi[i]);
                }
            }

            int cont4 = 0;

            //promosso o bocciato

            //1                        
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (voti[i, j] < 6)
                    {
                        cont4++;
                    }
                }
            }

            for (int q = 0; q < 1; q++)
            {
                Console.Write("{0}\t", allievi[q]);

                if (cont4 >= 3)
                {
                    Console.Write("Bocciato\n");
                }
                else
                    Console.Write("Promosso\n");
            }

            //2
           int cont7 = 0;
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (voti[i, j] < 6)
                    {
                        cont7++;
                    }
                }
            }

            for (int q = 1; q < 2; q++)
            {
                Console.Write("{0}\t", allievi[q]);

                if (cont7 >= 3)
                {
                    Console.Write("Bocciato\n");
                }
                else
                    Console.Write("Promosso\n");
            }

            //3
            int cont6 = 0;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (voti[i, j] < 6)
                    {
                        cont6++;
                    }
                }
            }

            for (int q = 2; q < 3; q++)
            {
                Console.Write("{0}\t", allievi[q]);

                if (cont6 >= 3)
                {
                    Console.Write("Bocciato\n");
                }
                else
                    Console.Write("Promosso\n");
            }
            
            //debiti

            if (cont4 < 3)
            {
                //voti prima persona
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (voti[i, j] < 6)
                        {
                            Console.WriteLine("Voto da recuperare {0} in materia {1}", voti[i, j], materie[j]);
                        }
                    }

                }
            }

            if (cont6 < 3)
            {
                //voti seconda persona
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (voti[i, j] < 6)
                        {
                            Console.WriteLine("Voto da recuperare {0} in materia {1}", voti[i, j], materie[j]);
                        }
                    }

                }
            }

            if (cont7 < 3)
            {
                //voti terza persona
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (voti[i, j] < 6)
                        {
                            Console.WriteLine("Voto da recuperare {0} in materia {1}", voti[i, j], materie[j]);
                        }
                    }

                }
            }




        }
    }
}
