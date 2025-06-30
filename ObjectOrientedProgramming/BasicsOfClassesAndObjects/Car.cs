using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Car
    {
        // member variables
        // 'private' hides a variable from other classes
        // Backing fields of the properties 
        // private string _model = "";

        private string _brand = "";

        private bool _isLuxury;

        // default property - a backing field is then unnecessary
        public string Model { get; set; }

        //Properties

        // Property with lambda expressions
        // public string Model { get => _model; set => _model = value; } // comented because we defined a default property: public string Model { get; set; }

        // Property without lambda expressions
        /*
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        */
        public string Brand
        {
            get
            {
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
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
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructor
        public Car(string model, string brand, bool isLuxury) 
        {
            // only properties can modify this fields
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the " + Brand + " brand and model "
                + Model + " has been created");
        }

        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }
    }
}
