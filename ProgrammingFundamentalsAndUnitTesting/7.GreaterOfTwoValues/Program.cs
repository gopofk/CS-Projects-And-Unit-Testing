string type = Console.ReadLine();
string first = Console.ReadLine();
string second = Console.ReadLine();

Compare(type, first, second);
static void Compare(string type, string first, string second)
{
    if (type == "int")
    {
        int x = int.Parse(first);
        int y = int.Parse(second);

        int biggest = CompareTwoIntegers(x, y);

        Console.WriteLine(biggest);
    }

    else if (type == "char") 
    { 
        char x = char.Parse(first);
        char y = char.Parse(second);

        char biggest = CompareTwoChars(x, y);

        Console.WriteLine(biggest);
    }

    else if (type == "string")
    {
        string biggest = CompareTwoStrings(first, second);

        Console.WriteLine(biggest);
    }
}

static int CompareTwoIntegers(int x, int y)
{
    if (x > y)
    {
        return x;
    }

    return y;
}

static char CompareTwoChars(char x, char y)
{
    if (x > y)
    {
        return x;
    }
    return y;
}

static string CompareTwoStrings(string first, string second)
{
    int result = first.CompareTo(second);
    
    if (result > 0)
    {
        return first;
    }
    return second;
}