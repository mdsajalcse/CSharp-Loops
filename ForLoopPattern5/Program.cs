// For Loop Pattern 5

Console.WriteLine("Enter the Number of Rows:");
int rows=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Number of Cols:");
int cols=int.Parse(Console.ReadLine());

for(int x = rows; x >= 1; x--)
{
    for(int y = 1; y <= x; y++)
    {
        Console.Write(y);
    }

    Console.WriteLine();
}
