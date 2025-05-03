int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

string sign = MultiplicationSign(num1, num2, num3);
Console.WriteLine(sign);
static string MultiplicationSign(int num1, int num2, int num3)
{
    string sign = "zero";
    
    int product = num1 * num2 * num3;
    if (product == 0)
    {
        sign = "zero";
    }
    else if (product > 0)
    {
        sign = "positive";
    }
    else if (product < 0)
    {
        sign = "negative";
    }
    return sign;
}
