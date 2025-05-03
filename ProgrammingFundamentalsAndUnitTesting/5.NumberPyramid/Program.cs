int n = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 1; i <= n; i++)
{
    if (counter == n)
    {
        break;
    }
   for (int j = 1; j <= i; j++)
    {
        counter = counter + 1;
        Console.Write($"{counter} ");
        if (counter == n)
        {
            break;
        }
    }
    Console.WriteLine();
}
