using System;

namespace FinalGuessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling of all void functions will happen here and the order of the function call
            
            gameInstruct();
            RandomGene();

            // The getName() is the first function to be called and it will be
            // returning the user input which in this case is going to be a name.
            string getName()
            {
                // Console.WriteLine("String") is a way to display output to the screen
                // string specifize the data type
                Console.WriteLine("Hello, What's your name? ");
                string name = Console.ReadLine();
                return name;
            }
            // gameInstruct is void because she is returning nothing unless called from the top to do something
            // Here is also the game instructions
            // do not forget the datatype you are working with and + operater is used to concatinate
            void gameInstruct()
            {
                string name = getName();
                Console.WriteLine("Hi, " + name + "! Lets play the game. All you need to do is guess an number betweeen 1 and 5");
            }

            // lastly but not least the final function
            void RandomGene()
            {
                // in order to generate a random number we have to explicitly create a variable like this
                Random random = new Random();
                // since all we need out of the generated number is an integer
                // we have no choice but to specify the datatype as an int 
                // random.Next(1, 5) randomly give us a different number between 1 and 5 after every game iteration
                int randomNum = random.Next(1, 5);
                int guess = -1;

                // while loop is true(if guess is not equal to random generated number)
                //  ask for another guess from user otherwise get out of loop
                while (guess != randomNum)
                {
                    Console.WriteLine("Whats your guess: ");
                    // we want to return an integer value for guess but 
                    // console.ReadLine will give us the user input as a string
                    // We then have to convert that input to int using int.Parse()
                    guess = int.Parse(Console.ReadLine());

                    // another message we want to include when the user guess wrong
                    if (guess != randomNum)
                    {
                        Console.WriteLine("Wrong!!! Try again");
                    }
                }
                
                // while loop is false print this
                Console.WriteLine("Great!!! You Guessed it. ");
              
            }

        }
    }
}
