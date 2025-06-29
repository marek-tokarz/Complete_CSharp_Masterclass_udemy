namespace BasicsOfClassesAndObjects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            // Creating an object of the Class Car
            // Creating an instance of the Class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            
            Console.WriteLine("Enter the brand name");
            // Setting brand of a car - by property
            audi.Brand = Console.ReadLine();
            

            // Getting a brand of a car - by property
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);
            */

            // EXAMPLES WITH CUSTOMER

            Customer earl = new Customer("Earl");
            Customer marek = new Customer("Marek", "Mainstreet 1", "5551234567");

            Console.WriteLine("Name of a customer is: " + earl.Name);

            Console.ReadKey();
        }
    }
}
