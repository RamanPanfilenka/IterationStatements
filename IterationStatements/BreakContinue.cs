namespace IterationStatements
{
    internal class BreakContinue
    {
        public void RunExamples() 
        {
            // break
            do
            {
                Console.WriteLine("Enter Q to exit from do:");
                var input = Console.ReadLine();
                if (input == "Q")
                    break;
            } while (true);

           
            for (; ; ) 
            {
                Console.WriteLine("Enter Q to exit from for:");
                var input = Console.ReadLine();
                if (input == "Q")
                    break;

                while (true)
                {
                    Console.WriteLine("Enter Q to exit from while:");
                    var input2 = Console.ReadLine();
                    if (input2 == "Q")
                        break;
                }
            }


            // continue
            var number = 1;
            do
            {
                if (number == 5) 
                {
                    number++;
                    continue;
                }

                Console.WriteLine($"Number in do while: {number}");
                number++;
            } while (number < 10);

            while (number > 1)
            {
                if (number == 5) 
                {
                    number--;
                    continue;
                }

                Console.WriteLine($"Number in while: {number}");
                number--;
            }

            for (; number < 10; number++) 
            {
                if (number == 5)
                    continue;

                Console.WriteLine($"Number in for: {number}");
            }
        }
    }
}
