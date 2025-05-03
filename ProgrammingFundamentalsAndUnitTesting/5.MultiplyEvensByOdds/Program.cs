int number = int.Parse(Console.ReadLine());
number = Math.Abs(number); //for negative nummbers

//calling out the methods
int multiple = GetMultipleOfEvenAndOdds(number);
int sumOfEvens = GetSumOfEvenDigits(number);
int sumOfOdds = GetSumOfOddDigits(number);

Console.WriteLine(multiple);

//creating the methods
static int GetMultipleOfEvenAndOdds(int number)
{
    int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);


    return result;
}

static int GetSumOfEvenDigits(int number)
{
    int result = 0;

    while (number > 0)
    {
        int digit = number % 10; // Extract last digit
        if (digit % 2 == 0) // Check if even
        {
            result += digit;      
        }
        number /= 10; //to remove the last digit
    }

    return result;
}

static int GetSumOfOddDigits(int number)
{
    int result = 0;

    while (number > 0)
    {
        int digit = number % 10; // Extract last digit
        if (digit % 2 != 0) // Check if odd
        {
            result += digit;
        }
        number /= 10; //to remove the last digit
    }
    return result;
}