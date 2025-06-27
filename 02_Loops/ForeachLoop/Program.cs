using static System.Runtime.InteropServices.JavaScript.JSType;

string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

Console.WriteLine("Length of the 'weekdays' array is: " + weekDays.Length);

foreach (var day in weekDays)
{
    Console.WriteLine(day);
}

// two dimension array

int[,] twoDimensionArray = new int[3, 3];

// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] threeDimensionArray = new int[3, 3, 3];

string[,,] simple3DimensionArray =
{
    {
        { "000", "001" },
        { "010", "011" },
    },
    {
        { "100", "101" },
        { "110", "111" },
    },
};

Console.WriteLine("Three dimension array index 010: " + simple3DimensionArray[0, 1, 0]);

int[,] twoDimensionArrayInitalized =
{
    { 1, 2 },
    { 3, 4 },
};

// [1] [2] // row 0
// [3] [4] // row 1
//  c0  c1

Console.WriteLine(twoDimensionArrayInitalized[0, 0]);

twoDimensionArrayInitalized[0, 0] = 5;

Console.WriteLine(twoDimensionArrayInitalized[0, 0]);

Console.WriteLine(twoDimensionArrayInitalized[1, 0]);

string[,] ticTacToeField =
{
    { "O", "X", "X" },
    { "O", "O", "X" },
    { "X", "X", "O" },
};

Console.WriteLine("Results of an exercise");

int[,] numbers =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

int sum = 0;

for (int i = 0; i < 3; i++)
{
    sum = sum + numbers[0, i];
}

Console.WriteLine(sum);

sum = 0;

for (int i = 0; i < 3; i++)
{
    sum = sum + numbers[1, i];
}

Console.WriteLine(sum);

sum = 0;

for (int i = 0; i < 3; i++)
{
    sum = sum + numbers[2, i];
}

Console.WriteLine(sum);

Console.ReadLine();
