//For Loop Pattern 4


Console.WriteLine("Enter Number of Rows::");
int rows=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Number of Columns::");
int  cols=int.Parse(Console.ReadLine());

for(int i = 1; i <= rows; i++)
{
    for(int j = 1; j <= cols; j++)
    {
        Console.Write(cols);
    }
    Console.WriteLine();
}
