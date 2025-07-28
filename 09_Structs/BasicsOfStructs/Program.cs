namespace BasicsOfStructs
{
    public struct Point
    {
        /*
        public int X { get; set; }
        public int Y { get; set; }
         */

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
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

            Point p2;
            p2.X = 1;
            p2.Y = 2;
            p2.Display();

            Point p3;
            // structs are a value types
            p3 = p1;
            p3.X = 50;
            p3.Display();

            Console.ReadKey();
        }
    }
}
