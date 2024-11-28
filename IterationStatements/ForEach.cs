using System.Collections;

namespace IterationStatements
{
    internal class ForEach
    {
        public void RunExamples()
        {
            var numbers = new int[] { 1, 2, 4, 6, 7 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            PrintDaysInWhile(new Weekdays());
            Console.WriteLine("/////////////////");
            PrintDaysInWhile(new WorkWeekdays());
            Console.WriteLine("/////////////////");
            PrintDaysInWhile(new HolidaykWeekdays());

            var list = new List<int>() { 1, 2, 3 };
            foreach (int number in list) 
            { 
                Console.WriteLine($"{number}");
            }

            void PrintDays(Weekdays week) 
            { 
                foreach(var day in week) 
                {
                    Console.WriteLine(day);
                }
            }

            void PrintDaysInWhile(Weekdays week)
            {
                var enumerator = week.GetEnumerator();
                while (enumerator.MoveNext()) 
                { 
                    var day = enumerator.Current;
                    
                    //Block in foreach
                    Console.WriteLine(day);
                    //End of block
                }
            }
        }
    }

    internal class Weekdays : List<string>
    {
        protected string[] _days = new string[] { "Monday", "Tuesday", "Wensday", 
            "Thursday", "Friday", "Saturday", "Sunday" };

        public virtual IEnumerator<string> GetEnumerator() 
        {
            return new WeekdaysEnumerator(_days);
        }
    }

    internal class WorkWeekdays : Weekdays
    {
        public override IEnumerator<string> GetEnumerator()
        {
            return new WorkWeekDaysEnumerator(_days);
        }
    }

    internal class HolidaykWeekdays : Weekdays
    {
        public override IEnumerator<string> GetEnumerator()
        {
            return new HolidayWeekDaysEnumerator(_days);
        }
    }

    internal class WeekdaysEnumerator : IEnumerator<string>
    {
        private string[] _days;
        public int position = -1;

        public WeekdaysEnumerator(string[] days) 
        {
            _days = days;
        }

        public string Current 
        {
            get 
            { 
                if (position == -1 || position > _days.Length)
                    throw new InvalidOperationException();

                return _days[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            position++;

            if(position >= _days.Length)
                return false;

            return true;
        }

        public void Reset() => position = -1;

        public void Dispose()
        {
        }
    }

    internal class WorkWeekDaysEnumerator : IEnumerator<string>
    {
        private string[] _days;
        public int position = -1;

        public WorkWeekDaysEnumerator(string[] days)
        {
            _days = days;
        }

        public string Current
        {
            get
            {
                if (position == -1 || position > _days.Length)
                    throw new InvalidOperationException();

                return _days[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            position++;

            if (position >= _days.Length || position > 4)
                return false;

            return true;
        }

        public void Reset() => position = -1;

        public void Dispose()
        {
        }
    }

    internal class HolidayWeekDaysEnumerator : IEnumerator<string>
    {
        private string[] _days;
        public int position = 4;

        public HolidayWeekDaysEnumerator(string[] days)
        {
            _days = days;
        }

        public string Current
        {
            get
            {
                if (position == -1 || position > _days.Length)
                    throw new InvalidOperationException();

                return _days[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            position++;

            if (position >= _days.Length)
                return false;

            return true;
        }

        public void Reset() => position = 4;

        public void Dispose()
        {
        }
    }
}
