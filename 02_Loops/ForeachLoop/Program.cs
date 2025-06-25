string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

Console.WriteLine("Length of the 'weekdays' array is: " + weekDays.Length);

foreach(var day in weekDays)
{
    Console.WriteLine(day);
}    

// two dimension array

int[,] twoDimensionArray = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] threeDimensionArray = new int[3, 3, 3];

int[,] twoDimensionArrayInitalized = { { 1, 2 }, { 3, 4 } };
// [1] [2] // row 0
// [3] [4] // row 1
//  c0  c1

Console.WriteLine(twoDimensionArrayInitalized[0,0]);

twoDimensionArrayInitalized[0, 0] = 5;

Console.WriteLine(twoDimensionArrayInitalized[0, 0]);

Console.WriteLine(twoDimensionArrayInitalized[1, 0]);

string[,] ticTacToeField =
{
    {"O", "X", "X" },
    {"O", "O", "X" },
    {"X", "X", "O" },
};

Console.ReadLine();