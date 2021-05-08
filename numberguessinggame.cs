using System;

namespace FinalGuessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            gameInstruct();
            RandomGene();

            string getName()
            {
                Console.WriteLine("Hello, What's your name? ");
                string name = Console.ReadLine();
                return name;
            }

            void gameInstruct()
            {
                string name = getName();
                Console.WriteLine(name + "! Lets play the game. All you need to do is guess an number betweeen 1 and 5");
            }

            void RandomGene()
            {
                Random random = new Random();

                int randomNum = random.Next(1, 5);
                int guess = -1;
                while (guess != randomNum)
                {
                    Console.WriteLine("Whats your guess: ");
                    guess = int.Parse(Console.ReadLine());
                    if (guess != randomNum)
                    {
                        Console.WriteLine("Wrong!!! Try again");
                    }
                }
                
                
                Console.WriteLine("Great!!! You Guessed it. ");
              
            }

        }
    }
}
