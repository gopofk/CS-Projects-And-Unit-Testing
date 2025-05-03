using System;

int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1)
    {
        Console.Write(string.Join(" ", array[i]));
        return;
    }
    
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] < array[j])
        {
            break;
        }
        
        if (j == array.Length - 1)
        {
            if (array [i] > array[j])
            {
                Console.Write(string.Join(" ", array[i]) + " ");
                break;
            }   
        }
    }
}

//int[] numbers = Console.ReadLine()
//              .Split()
//              .Select(int.Parse)
//              .ToArray();

//// 5 2 8
//for (int i = 0; i < numbers.Length; i++)
//{
//    int currentNumber = numbers[i]; // 5
//    bool isTopNumber = true;
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        int nextNumber = numbers[j]; // 2
//        if (currentNumber <= nextNumber)
//        {
//            isTopNumber = false;
//            break;
//        }
//    }

//    if (isTopNumber)
//    {
//        Console.Write($"{currentNumber} ");
//    }