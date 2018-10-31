using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter numbers and press Return:");
            
            string userInput = Console.ReadLine();
            string message = "";

            if (userInput == "4 8 15 16 23 42")
                message = "Recalibrating energy core ... Complete!";
            else
                Console.Beep(50, 500);
                
                message = "FAILURE!";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
