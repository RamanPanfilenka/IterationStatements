using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class While
    {
        public void RunExamples() 
        {
            var count = 10;
            while (count > 0) 
            {
                Console.WriteLine($"Iteration in while with simple condition {count}");
                count--;
            }

            Console.Write("Enter number of iterations: ");
            var countImput = Console.ReadLine();
            if (int.TryParse(countImput, out var value)) 
            { 
                while (value > 0) 
                {
                    Console.WriteLine($"Iteration in while with custom number {value}");
                    value--;
                }
            }

            int number = 5;
            while ((number > 0 && number < 10) || (number > 90 && number < 100))
            {
                number++;
            }

            while (IsNumberCorrect(number)) 
            {
                number++;
            }

            bool IsNumberCorrect(int number) 
            { 
                return (number > 0 && number < 10) || (number > 90 && number < 100);
            }


            while (IsNumberCorrect2(number)) 
            { 
                Console.WriteLine("iteration with while false");
            }

            bool IsNumberCorrect2(int number)
            {
                return false;
            }

            var input = string.Empty;
            while (input != "Q") 
            {
                Console.WriteLine("Enter the message or the Q for exit");
                input = Console.ReadLine();

                if (input != "Q")
                    Console.WriteLine("Message sent");
            }
        }
    }
}
