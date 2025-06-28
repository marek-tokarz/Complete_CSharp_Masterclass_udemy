using System.Diagnostics.CodeAnalysis;

namespace WeatherSimulator
{
    internal class Program
    {
        
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

            Console.WriteLine("Most common weather condiditon: " + MostCommonCondition(conditions));

            Console.ReadLine();
        }

        static int calculateAverageTemperature(int[] temperature)
        {
            int sum = 0;
            int counter = 0;
            foreach (var item in temperature)
            {
                sum = sum + item;
                counter++;
            }
            return sum / counter;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }
    }
}