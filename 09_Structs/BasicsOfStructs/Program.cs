namespace BasicsOfStructs
{
    public struct Point
    {
        
        public double X { get; set; }
        public double Y { get; set; }
        
        /*
        public int X;
        public int Y;
        */

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Point p1 = new Point(); - struct has also a default constructor
            Point p1 = new Point(10,20);
            p1.Display();

            /* does not work with properties, so 'x' and 'y' were changed to the fields
            Point p2;
            p2.X = 10;
            p2.Y = 20;
            */

            // with properties values must be assigned at initalization
            Point p2 = new Point(1,2);
            p2.X = 1;
            p2.Y = 2;
            p2.Display();

            Point p3;
            // structs are a value types
            p3 = p1;
            p3.X = 50;
            p3.Display();

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between points: {distance:F2}");
            
            Console.ReadKey();
        }
    }
}
