int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int result = FactorialDivision(first, second);
Console.WriteLine(result);


static int FactorialDivision (int first, int second)
{
    int resultFirst = first;
    for (int i = first - 1; i > 0; i--)
    {
        resultFirst *= i;
    }

    int resultSecond = second;
    for (int i = second - 1; i > 0; i--)
    {
        resultSecond *= i;
    }

    int divisionResult = resultFirst / resultSecond;
    return divisionResult;
}