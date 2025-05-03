int givenNumbers = int.Parse(Console.ReadLine());
int biggestNumber = 0;

for ( int i = 1; i <= givenNumbers; i++)
{
   int number = int.Parse(Console.ReadLine());
    if (biggestNumber < number)
    {
        biggestNumber = number;
    }

}
Console.WriteLine(biggestNumber);