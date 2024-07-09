using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_Man
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("Benvenuto in Hang Man!!");
            string [] listwords = new string[10];
            listwords[0] = "pecora";
            listwords[1] = "capra";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "melone";
            listwords[5] = "gelato";
            listwords[6] = "jasmine";
            listwords[7] = "ananas";
            listwords[8] = "arancia";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char [mysteryWord.Length];
            Console.Write("Inserisci la lettera: ");
            for (int p = 0; p < mysteryWord.Length; p++) 
                guess[p]= '*';
            while (a)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                if (new string(guess) == mysteryWord)
                    a = false;
            }
            Console.WriteLine("Hai trovato la parola! :)");
            Console.Read();


        }
    }
}
