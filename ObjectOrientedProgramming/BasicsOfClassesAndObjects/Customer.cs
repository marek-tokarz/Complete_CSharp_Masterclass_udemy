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

        // Custom Constructor
        public Customer(string name, string address, string contacNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contacNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }

    }
}
