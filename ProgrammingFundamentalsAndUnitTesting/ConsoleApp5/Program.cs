int count = int.Parse(Console.ReadLine());
int sum = 0;

if (count == 0 || count < 0)
{
    Console.WriteLine("0");
        return;
}

for (int i = 0; i < count; i++)
{
    int mils = int.Parse(Console.ReadLine());
    sum += mils;
    Console.WriteLine(sum);
}