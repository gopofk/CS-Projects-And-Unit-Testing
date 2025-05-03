while (true)
{
    int lastDigit = 0;
    int sumOfDigits = 0;
    string end = Console.ReadLine();
    
    if (end == "End")
    {
        break;
    }

    int digits = int.Parse(end);
    
    while (digits > 0)
    {
        lastDigit = digits % 10;
        digits = digits / 10;

        sumOfDigits += lastDigit;
    }
    Console.WriteLine($"Sum of digits = {sumOfDigits}");
}
Console.WriteLine("Goodbye");