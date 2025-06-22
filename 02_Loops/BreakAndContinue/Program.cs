Console.WriteLine("A for loop with break:");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if(i==3)
    {
        Console.WriteLine("Loop finished");
        break;
    }
}

Console.WriteLine("A for loop with continue:");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        Console.WriteLine("C O N T I N U E");
        continue;
    }
    Console.WriteLine("Only if not 'continue'");
}
Console.ReadKey();