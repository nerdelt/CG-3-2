using System;

namespace pickanumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess it?");
            Console.Write("Please enter your best guess:  ");
            string guess = Console.ReadLine();

            string message = (guess == "8") ? "You Win!" : "You Lose.";

            Console.WriteLine(message);
            Console.ReadLine();


        }
    }
}
