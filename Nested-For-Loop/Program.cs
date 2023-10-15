// See https://aka.ms/new-console-template for more information
//Nested For Loop

for (int i = 1; i <= 2; i++)
{
    Console.WriteLine("Outer:" + i);
    Console.WriteLine("=========");

    for(int j = 1; j <= 3; j++)
    {
        Console.WriteLine("Inner:" + j);
        Console.WriteLine("=========");

        for(int k = 1; k <= 3; k++)
        {
            Console.WriteLine("Second Inner: "+k);
            Console.WriteLine("==========");
            for(int l = 1; l <= 3; l++)
            {
                Console.WriteLine("Third Inner: "+l);

            }

        }
    }
}

