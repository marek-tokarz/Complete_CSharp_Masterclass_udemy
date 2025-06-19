/*
Console.WriteLine("Enter a number");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);
Console.WriteLine("User entered number = " + num1);
// above code will throw an exception if a Parse() can not parse a string to an int
*/

// instance of the Random Class
Random random = new Random();

// random number between 1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess a number");
string input2 = Console.ReadLine();
int num2;
bool isNumber = int.TryParse(input2, out num2);
if (isNumber )
{
    Console.WriteLine("It was a number");
    if (randomNumber == num2)
    {
        Console.WriteLine("You guessed a number");
    }
    else
    {
        Console.WriteLine("You have not guessed the number");
    }
}
else
{
    Console.WriteLine("It was not a number");
}
Console.WriteLine("User entered number = " + num2);
Console.ReadKey();