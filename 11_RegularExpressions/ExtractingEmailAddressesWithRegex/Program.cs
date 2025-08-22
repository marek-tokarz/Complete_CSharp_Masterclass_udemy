using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ExtractingEmailAddressesWithRegex
{
    public class Exercise
    {
        public void ExtractPatterns(string input)
        {
            string pattern = @"\w+@\w+\.\w+";
            
            // Implement the method to extract and print email addresses using regex
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count, input);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            string testInput = "Contact us at support@example.com or sales@example.org.1234";
            exercise.ExtractPatterns(testInput);

            Console.ReadKey();
        }
    }
}
