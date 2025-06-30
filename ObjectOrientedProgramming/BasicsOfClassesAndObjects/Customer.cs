using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Customer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        // Default constructor
        public Customer()
        {
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
            Name = name;
        }
        // Last parameter is an optional parameter
        public void SetDetails(string name, string address, string contacNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contacNumber;
        }

    }
}
