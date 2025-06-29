using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Car
    {
        // member variable
        // 'private' hides a variable from other classes
        private string _model = "";
        private string _brand = "";

        //Property
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You have entered nothing!");
                    _brand = "Default value";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        // Constructor
        public Car(string model, string brand) 
        {
            // only properties can modify this fields
            Model = model;
            Brand = brand;
            Console.WriteLine("A car of the " + Brand + " brand and model "
                + Model + " has been created");
        }
    }
}
