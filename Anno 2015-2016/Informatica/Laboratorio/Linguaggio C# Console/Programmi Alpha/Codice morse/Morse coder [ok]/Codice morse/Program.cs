using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Codice_morse
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FreqPunto = 2000;
            const int FreqLinea = 2000;
            const int DurataPunto = 300;
            const int DurataLinea = 1000;

            string messaggio;
            
                Console.Write("Inserisci il tuo messaggio: ");
                messaggio = Console.ReadLine();
                messaggio = messaggio.ToUpper();

                for (int i = 0; i < messaggio.Length; i++)
                {
                    if (messaggio[i] == 'A')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . _ ");
                    }

                    if (messaggio[i] == 'B')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ . . . ");
                    }
                    if (messaggio[i] == 'C')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ . _ . ");
                    }
                    if (messaggio[i] == 'D')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ . . ");
                    }
                    if (messaggio[i] == 'E')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . ");
                    }
                    if (messaggio[i] == 'F')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . . _ . ");
                    }
                    if (messaggio[i] == 'G')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ . ");
                    }
                    if (messaggio[i] == 'H')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . . . . ");
                    }
                    if (messaggio[i] == 'I')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . . ");
                    }
                    if (messaggio[i] == 'J')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . _ _ _ ");
                    }
                    if (messaggio[i] == 'K')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ . _ ");
                    }
                    if (messaggio[i] == 'L')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . _ . . ");
                    }
                    if (messaggio[i] == 'M')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ ");
                    }
                    if (messaggio[i] == 'N')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ . ");
                    }
                    if (messaggio[i] == 'O')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ _ ");
                    }
                    if (messaggio[i] == 'P')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . _ _ . ");
                    }
                    if (messaggio[i] == 'Q')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ . _ ");
                    }
                    if (messaggio[i] == 'R')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . _ . ");
                    }
                    if (messaggio[i] == 'S')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . . . ");
                    }
                    if (messaggio[i] == 'T')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ ");
                    }
                    if (messaggio[i] == 'U')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . . _ ");
                    }
                    if (messaggio[i] == 'V')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . . . _ ");
                    }
                    if (messaggio[i] == 'W')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . _ _ ");
                    }
                    if (messaggio[i] == 'X')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ . . _ ");
                    }
                    if (messaggio[i] == 'Y')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);                 
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ . _ _ ");
                    }
                    if (messaggio[i] == 'Z')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ . . ");
                    }

                    if (messaggio[i] == '1')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . _ _ _ _ ");
                    }
                    if (messaggio[i] == '2')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . . _ _ _ ");
                    }
                    if (messaggio[i] == '3')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . . . _ _ ");
                    }
                    if (messaggio[i] == '4')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" . . . . _ ");
                    }
                    if (messaggio[i] == '5')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" . . . . . ");
                    }
                    if (messaggio[i] == '6')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ . . . . ");
                    }
                    if (messaggio[i] == '7')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ . . . ");
                    }
                    if (messaggio[i] == '8')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write( "_ _ _ . . ");
                    }
                    if (messaggio[i] == '9')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqPunto, DurataPunto);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ _ _ . ");
                    }

                    if (messaggio[i] == '0')
                    {
                        Thread.Sleep(1000);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Console.Beep(FreqLinea, DurataLinea);
                        Thread.Sleep(1000);
                        Console.Write(" _ _ _ _ _ ");
                    }

                }
                Console.WriteLine("");

        }
    }
}
