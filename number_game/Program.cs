using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_game
{
    class Game
    {
        static int guess = 0;
        static int target = 5;
        static string Input = "";
        static Random RandomNumber = new Random();

        public static void Play()
        {
            target = RandomNumber.Next(10);
            Console.Write("The number that was made...");
            Input = Console.ReadLine();
            if(int.TryParse(Input, out guess))
            {
                    if(guess == target)
                {
                    Console.WriteLine("Congratulations! You guessed " + guess + ". the number that was made " + target + ".");
                }
                    else
                {
                    Console.WriteLine("You did not guess! " + guess + ". the number that was made " + target + ". Try again!");
                }

            }
            else
            {
                Console.WriteLine("Enter the number!");
                Console.WriteLine("Press Enter to continue!");
                Console.ReadLine();
                Play();
            }

            Console.Read();
        }
    }

    class Program
    {
        static void Main()
        {
            Game.Play();
        }
    }
}
