int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

while (numbers.Length > 1)
{
    int[] newArray = new int[numbers.Length - 1];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = numbers[i] + numbers[i + 1];
    }
    numbers = newArray;
}
Console.WriteLine(numbers[0]);