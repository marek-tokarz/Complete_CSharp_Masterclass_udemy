using System.Diagnostics;

namespace BasicsOfTryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Debug.WriteLine("Main method is running");

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
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }
}
