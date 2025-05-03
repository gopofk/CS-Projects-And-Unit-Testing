int num = int.Parse(Console.ReadLine());
int newNum = num;
int lastDigit = 0;
bool numIsSpecial = true;

while (newNum > 0 && numIsSpecial == true)
{
    lastDigit = newNum % 10;
    if (num % lastDigit != 0)
    {
        numIsSpecial = false;
        Console.WriteLine(num + " is not special");
        break;
    }
    
    newNum = newNum / 10;
}
if (numIsSpecial == true)
{
    Console.WriteLine(num + " is special");
}