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

        // Constructor
        public Car(string model) 
        {
            _model = model;
            Console.WriteLine("A car of the model " + _model + " has been created");
        }
    }
}
