namespace BasicsOfCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initalizing a List
            List<string> colors = ["Red", "Green", "Blue", "Red"];

            Console.WriteLine("Colors in a list:");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Deletes a first occurence of a specific object
            bool isDeleteSuccesful = colors.Remove("Red");

            Console.WriteLine("Delete returned (before loop): " + isDeleteSuccesful);

            // will remove all "Red" from a list 
            while (isDeleteSuccesful)
            {
                isDeleteSuccesful = colors.Remove("Red");
            }

            Console.WriteLine("Delete returned (after a loop): " + isDeleteSuccesful);

            Console.WriteLine("Colors in a list:");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Sorting a list with method

            List<int> numbers = new List<int> {10,5,15,3,9};

            Console.WriteLine("Unsorted");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Finding elements in a list

            // Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x > 10;

            // This will return a list of numbers that are higher and equal to 10
            List<int> higher10 = numbers.FindAll(isGreaterThanTen);

            Console.WriteLine("List of numbers higher than 10");
            foreach (int number in higher10)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
