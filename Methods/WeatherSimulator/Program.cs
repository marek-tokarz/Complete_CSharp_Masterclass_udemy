using System.Diagnostics.CodeAnalysis;

namespace WeatherSimulator
{
    internal class Program
    {
        static int calculateAverageTemperature(int[] temperature)
        {
            int sum = 0;
            int counter = 0;
            foreach(var item in temperature)
            {
                sum = sum + item;
                counter++;
            }
            return sum/counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");

            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            int maxTemperature = temperature.Max();
            int minTemperature = temperature.Min();

            Console.WriteLine("Max temperature is: " + maxTemperature);
            Console.WriteLine("Min temperature is: " + minTemperature);

            Console.WriteLine("Average temperature is " + calculateAverageTemperature(temperature));

            Console.ReadLine();
        }
    }
}
