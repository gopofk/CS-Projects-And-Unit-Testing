//My code

//int[] first = Console.ReadLine()
//    .Split(" ")
//    .Select(int.Parse)
//    .ToArray();

//int[] second = Console.ReadLine()
//    .Split(" ")
//    .Select(int.Parse)
//    .ToArray();

//int equal = 0;
//int place = 0;

//foreach (int i in first)
//{
//    foreach (int j in second)
//    {
//        if (i == j)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}


//ChatGPT code

int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

// Find common elements using Intersect()
int[] commonElements = first.Intersect(second).ToArray();

// Print result
Console.WriteLine(string.Join(" ", commonElements));
