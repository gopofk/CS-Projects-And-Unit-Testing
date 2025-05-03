int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int magicN = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++) // Ensure j > i to avoid duplicate pairs
    {
        if (numbers[i] + numbers[j] == magicN)
        {
            Console.WriteLine($"{numbers[i]} {numbers[j]}");
        }
    }
}