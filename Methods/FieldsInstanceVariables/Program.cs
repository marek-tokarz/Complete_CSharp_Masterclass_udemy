namespace FieldsInstanceVariables
{
    internal class Program
    {
        // Field (or instance variable)
        static int myResult;

        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            Console.WriteLine("AddTwoValues method result: " + AddTwoValues(a, b));
            Console.WriteLine("SubtractTwoValues method result: " + SubtractTwoValues(a, b));

            Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }

        static int SubtractTwoValues(int value1, int value2)
        {
            myResult = (value1 - value2);
            return myResult;
        }
    }
}
