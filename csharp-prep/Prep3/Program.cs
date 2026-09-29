using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // Console.WriteLine("What is the magic number?");
        // string magicNumberStr = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberStr);
        int guess; 
        do
        {
            Console.WriteLine("What is your Guess? ");
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {    
            Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}