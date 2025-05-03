int initial = int.Parse(Console.ReadLine());

double devideByTwo = 0;
double devideByThree = 0;
double devideByFour = 0;

for (int i = 1;  i <= initial; i++)
{
    int number = int.Parse(Console.ReadLine());
    
    if (number % 2 == 0)
    {
        devideByTwo += 1;
        
        if (number % 3 == 0)
        {
            devideByThree += 1;
        }           
        
        else if (number % 4 == 0)
        {
            devideByFour += 1;
        }            
    } 

    else if (number % 3 == 0)
    {
        devideByThree += 1;

        if (number % 4 == 0)
        {
            devideByFour += 1;
        }
    }

    else if (number % 4 == 0)
    {
        devideByFour += 1;
    }
}
double devideByTwoPercentage = (devideByTwo * 100) / initial;
double devideByThreePercentage = (devideByThree * 100) / initial;
double devideByFourPercentage = (devideByFour * 100) / initial;

Console.WriteLine($"{devideByTwoPercentage:F2}%");
Console.WriteLine($"{devideByThreePercentage:F2}%");
Console.WriteLine($"{devideByFourPercentage:F2}%");