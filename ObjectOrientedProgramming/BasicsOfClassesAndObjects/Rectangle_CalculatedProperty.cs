using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Rectangle_CalculatedProperty
    {
        // declaration of a filed
        // it needs to get a value in a compile time (we can not use a method)
        // it will have the same for every instance
        public const int NumberOfCorners = 4;

        // declaration of a filed
        // has to be initalized during declaration or in a constructor (can be assigned during a runtime)
        // it can have a different value for each instance
        public readonly string Color;

        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property
        public double Area
        {
            get { return Width * Height; }
        }

        // Method to display details of a Rectangle
        public void DisplayDetails()
        {
            // not possible here
            // Color = "Grey";

            Console.WriteLine($"Color: {Color}, Width: {Width}, " + 
                $"Height: {Height}, Area: {Area}, Number of corners: {NumberOfCorners}");
        }

        // constructor
        public Rectangle_CalculatedProperty(string color)
        {
            Color = color;
        }
    }
}
