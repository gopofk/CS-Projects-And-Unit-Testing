List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> bombPower = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int bomb = bombPower[0];
int power = bombPower[1];

// правим while цикъл докато нямаме повече бомби в листа
// правим цикъл от началото на листа - до бомбата 
// локализираме числата преди бомбата, които са {power} на брой 
// правим проверка дали имаме толкова числа
// и ги вадим от листа
// правим втори цикъл от бомбата до края на листа
// проверяваме дали имаме нужните числа и ги вадим

List<int> allBombs = new List<int>();
List<int> allPowers = new List<int>();

while (list.Contains(bomb))
{
    int indexOfBomb = list.IndexOf(bomb);
    int leftIndex = indexOfBomb - power;
    int rightIndex = indexOfBomb + power;

    if (leftIndex < 0)
    {
        leftIndex = 0;
    }

    if (rightIndex > list.Count)
    {
        rightIndex = list.Count - 1;
    }

    for (int i = leftIndex; i <= rightIndex; i++)
    {
        list.RemoveAt(leftIndex);
    }
}

int sum = 0;
foreach (int i in list)
{
    sum += i; 
}
Console.Write(sum);
