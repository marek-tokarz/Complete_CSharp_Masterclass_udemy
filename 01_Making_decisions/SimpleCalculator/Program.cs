Console.WriteLine("Enter the first number:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation: +, -, *, /");
string operation = Console.ReadLine();
char firstChar = operation[0];

int result;

if (firstChar == '+')
{
    result = number1 + number2;
    Console.WriteLine("Result: " + result);
}
else if(firstChar == '-')
{
    result = number1 - number2;
    Console.WriteLine("Result: " + result);
}
else if(firstChar == '*')
{
    result = number1 * number2;
    Console.WriteLine("Result: " + result);
}
else if (firstChar == '/')
{
    if (number2 == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        result = number1 / number2;
        Console.WriteLine("Result: " + result);
    }
}
else
{
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}
Console.ReadLine();