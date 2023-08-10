using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretword = "giraffe";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofGuesses = false;

            while (guess != secretword && !outofGuesses)
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("Enter guess:");

                    guess = Console.ReadLine();
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofGuesses = true;
                }
            }
            if (outofGuesses)
            {
                Console.Write("you lost !");
            }
            else
            {
                Console.Write("you win!");
            }

            Console.ReadLine();
        }
    }
}
