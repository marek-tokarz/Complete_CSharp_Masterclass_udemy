namespace BasicsOfCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initalizing a List
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            Console.WriteLine("Colors in a list:");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadLine();
        }
    }
}
