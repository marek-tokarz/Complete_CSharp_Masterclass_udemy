using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        // Read-only instance field initalized from the constructor
        private readonly int _id;

        // Read only property
        public int Id { 
            get
                { return _id; }
        } // there is no 'set' here

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        // Default constructor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "None";
        }

        /* not needed - because we have created a custom constructor with optional parameters:
         * public Customer(string name, string addres = "NA", string contacNumber = "NA") ...
        // Custom Constructor
        public Customer(string name, string address, string contacNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contacNumber;
        }
        */

        public Customer(string name, string addres = "NA", string contacNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = addres;
            ContactNumber = contacNumber;
        }
        // Last parameter is an optional parameter
        public void SetDetails(string name, string address, string contacNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contacNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about customer: Name is {Name} and Id is {_id}");
        }

    }
}
