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

                int num1 = int.Parse(Console.ReadLine());
                // int num1 = 0;
                int num2 = 2;

                result = num2 / num1;
                // above line causes exception:
                // System.DivideByZeroException: „Attempted to divide by zero.”
            } // Managing specific exceptions
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            } // Default exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
            
            // 'throw' keyword, throwing own exceptions

            Console.WriteLine("Enter your age");
            int age = GetUserAge(Console.ReadLine());

            Console.ReadKey();
        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }
    }
}
