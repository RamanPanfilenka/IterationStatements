using System;
using System.Collections.Generic;
namespace IterationStatements
{
    internal class DoWhile
    {
        public void RunExamples() 
        {
            var startNumber = 0;
            do 
            {
                Console.Write("Enter your number: ");
                var userNumber = Console.ReadLine();
                if (int.TryParse(userNumber, out var value)) 
                {
                    startNumber += value;
                }
            } while (startNumber < 100);

            var input = string.Empty;
            do
            {
                Console.WriteLine("Enter the message or the Q for exit");
                input = Console.ReadLine();
                if (input != "Q")
                    Console.WriteLine("Message sent");

            } while (input != "Q" || input == "exit");

            do
            {
                Console.WriteLine("Enter the message or the Q for exit");
                input = Console.ReadLine();
                if (input != "Q")
                    Console.WriteLine("Message sent");

            } while (IsUserInputHasExitCommand(input));

            do 
            {
                Console.WriteLine("Some action in do while with false");
            } while (false);

            Console.WriteLine("Some action in do while with false");

            bool IsUserInputHasExitCommand(string input) 
            { 
                return input == "Q" || input == "exit" || input == "quit";
            }
        }
    }
}
