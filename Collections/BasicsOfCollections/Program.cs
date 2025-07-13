using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace BasicsOfCollections
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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

            List<int> numbers = new List<int> {10, 5, 15, 3, 9, 21, 16,33};

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
            Predicate<int> isGreaterThanTen = IsGreaterThanTen;

            // This will return a list of numbers that are higher and equal to 10
            List<int> higher10 = numbers.FindAll(isGreaterThanTen);

            Console.WriteLine("List of numbers higher 10");
            foreach (int number in higher10)
            {
                Console.WriteLine(number);
            }

            // Predciate with a method 'Any()'

            bool hasNumberHigherThan20 = numbers.Any(x => x > 20);

            if (hasNumberHigherThan20)
            {
                Console.WriteLine("There are numbers higher than 20");
            }
            else
            {
                Console.WriteLine("There is no numbers higher than 20");
            }
            */

            /*
            // Using Lists with Complex Objects

            List<Product> products = new List<Product>
            { 
                new Product { Name = "Apple", Price = 0.80},
                new Product {Name = "Banana", Price = 0.30},
                new Product {Name = "Cherry", Price = 3.80},
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine("Available products:");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            // Turning interface I<Enumerable> to a List
            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Products for less than 1$:");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }
            */

            // ArrayList

            // declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();

            // declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(21);

            // deletes a specific element
            myArrayList.Remove(13);

            // deletes an element at a specific position 
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj); 
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("Sum is: " + sum);

            Console.ReadLine();  
        }

        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
    }
}
