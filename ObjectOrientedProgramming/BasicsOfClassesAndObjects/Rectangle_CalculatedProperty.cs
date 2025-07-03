using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfClassesAndObjects
{
    internal class Rectangle_CalculatedProperty
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property
        public double Area
        {
            get {  return Width * Height; }
        }
    }
}
