using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string guess;
            string AnimalDescription = "Duck";
            Random randomnumbergenerator = new Random();
            
            // Query the user
            Console.Write("Enter your guess Chicken or Duck (C or D)");
            guess = Console.ReadLine();

            // A random number for the coin flip
            coin = randomnumbergenerator.Next(0,2);


            if (coin == 1){
                AnimalDescription = "Chicken";
            } else {
                AnimalDescription = "Duck";
            }

            if ((coin == 0 && guess == "D") || (coin == 1 && guess == "C"))
            {
                Console.WriteLine("You landed on {0}, you won!", AnimalDescription);
            }
            
            else 
            {
                Console.WriteLine("You landed on {0} you loser!", AnimalDescription);
            }

                Console.ReadLine();

            }
        }
    }

