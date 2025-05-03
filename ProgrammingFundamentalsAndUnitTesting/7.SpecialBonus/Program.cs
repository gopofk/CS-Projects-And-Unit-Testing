int stopNum = int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
double lastNum = 0;

while (num != stopNum)
{
    num = int.Parse(Console.ReadLine());
    if (num == stopNum)
    {
        break;
    }
    
    lastNum = num + (num * 0.2);
}
Console.WriteLine(lastNum);