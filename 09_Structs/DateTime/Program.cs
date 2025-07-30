using System;

namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime dateTime = new System.DateTime(2025, 7, 24);

            Console.WriteLine("My birthday is {0}", dateTime);

            // Write today on screem
            Console.WriteLine("Today is: " + System.DateTime.Today);

            // Write current time on a screen
            Console.WriteLine("Now is: " + System.DateTime.Now);

            System.DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the: {0}", tomorrow);

            Console.WriteLine("Today is: {0}", System.DateTime.Today.DayOfWeek);

            Console.WriteLine("First day of the year " + GetFirstDayOfYear(2000));

            int days = System.DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);

            System.DateTime now = System.DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (System.DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                System.TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Dyas passed since {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }



            Console.ReadKey();
        }

        static System.DateTime GetTomorrow()
        {
            return System.DateTime.Today.AddDays(1);
        }

        static System.DateTime GetFirstDayOfYear(int year)
        {
            return new System.DateTime(year, 1, 1);
        }
    }
}
