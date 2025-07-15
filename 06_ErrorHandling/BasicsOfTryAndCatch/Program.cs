namespace BasicsOfTryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                Console.WriteLine("Please enter a number");

                int num1 = 0;
                int num2 = 2;

                result = num2 / num1;
                // above line causes exception:
                // System.DivideByZeroException: „Attempted to divide by zero.”
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }
}
