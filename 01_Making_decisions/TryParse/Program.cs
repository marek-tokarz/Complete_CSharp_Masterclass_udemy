Console.WriteLine("Enter a number");
string input1 = Console.ReadLine();

int num1 = int.Parse(input1);
Console.WriteLine("User entered number = " + num1);
// above code will throw an exception if a Parse() can not parse a string to an int

Console.WriteLine("Enter another number");
string input2 = Console.ReadLine();
int num2;
bool isNumber = int.TryParse(input2, out num2);
if (isNumber )
{
    Console.WriteLine("It was a number");
}
else
{
    Console.WriteLine("It was not a number");
}
    Console.WriteLine("User entered number = " + num2);

Console.ReadKey();