namespace BasicsOfClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the Class Car
            // Creating an instance of the Class Car
            Car audi = new Car("A3", "Audi");

            Car bmw = new Car("i7", "BMW");

            Console.WriteLine("Enter the brand name");
            // Setting brand of a car - by property
            audi.Brand = Console.ReadLine();

            // Getting a brand of a car - by property
            Console.WriteLine("Brand is " + audi.Brand);

            Console.ReadKey();
        }
    }
}
