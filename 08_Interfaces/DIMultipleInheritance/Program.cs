namespace DIMultipleInheritance
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public class MultiFunctionPrinter(): IPrintable, IScannable
    {

        public void Print()
        {
            Console.WriteLine("Printing a document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning a document");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable printable = new MultiFunctionPrinter();
            IScannable scannable = new MultiFunctionPrinter();

            MultiFunctionPrinter printer = new MultiFunctionPrinter();

            printer.Print();
            printer.Scan();

            Console.ReadKey();
        }
    }
}
