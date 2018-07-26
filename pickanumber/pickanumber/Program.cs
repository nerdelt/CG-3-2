using System;

namespace pickanumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains game to user and asks for user input.
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess it?");
            Console.Write("Please enter your best guess:  ");
            string guess = Console.ReadLine();

            // This is the inline statement. It is a true/false scenario. 
            // If the user inputs 8, (true), they win. If they put in anything else (false), they loose.
            string message = (guess == "8") ? "You Win!" : "You Lose.";

            // This lets the user know if they won or lost. 
            Console.WriteLine(message);
            Console.ReadLine();


        }
    }
}
