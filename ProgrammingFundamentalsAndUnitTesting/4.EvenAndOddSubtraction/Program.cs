int[] numbers = Console.ReadLine()  
                           .Split(' ')      
                           .Select(int.Parse)  
                           .ToArray();
int sumEven = 0;
int sumOdd = 0;
int difference = 0;

for (int i = 0; i < numbers.Length; i++)
{ 
    if (numbers[i] % 2 == 0)
    {
        sumEven += numbers[i];
    }
    
    if (numbers[i] % 2 != 0)
    {
        sumOdd += numbers[i];
    }

    difference = sumEven - sumOdd;
}
Console.WriteLine(difference);
