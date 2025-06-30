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
            /*
            Customer earl = new Customer("Earl");
            Customer marek = new Customer("Marek", "Mainstreet 1", "5551234567");

            Console.WriteLine("Name of a customer is: " + earl.Name);

            Customer myCustomer = new Customer();
            Console.WriteLine("Details about customer: " + myCustomer.Name);
            */

            Car myAudi = new Car("A3", "Audi", false);

            myAudi.Drive();

            Car myBMW = new Car("i7", "BMW", true);

            myBMW.Drive();

            Customer myCustomer = new Customer();
            myCustomer.SetDetails("Tom", "Sunnystreet 5", "5451234567");

            // Creating a customer and setting his details with one detail being optional
            Customer myCustomer2 = new Customer();
            myCustomer2.SetDetails("Frank", "Cloudystreet 5");

            Console.WriteLine("Contact number of a Frank 'myCustomer2' is " + myCustomer2.ContactNumber);

            Console.ReadKey();
        }
    }
}
