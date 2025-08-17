namespace BasicsOfGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] stringArray = { "One", "Two", "Three", "Four" };

            PrintArray(intArray);
            PrintArray(stringArray);

            Console.ReadLine();
        }

        // a generci Method, that accepts a generic datatype
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
