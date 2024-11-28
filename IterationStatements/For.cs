namespace IterationStatements
{
    internal class For
    {
        public void RunExamples()
        {
            var index = 0;
            for (; ; ) 
            {
                Console.WriteLine($"Iteration in for {index}");
                index++;

                if (index >= 10)
                    break;
            }

            void LogStartOfFor() 
            { 
                Console.WriteLine("For start");
            }

            void LogIterationOfFor()
            {
                Console.WriteLine("Iteration ended");
            }

            bool IsIndexInRange(int index) 
            { 
                return index < 10 && index >= 0;
            }
        }
    }
}
