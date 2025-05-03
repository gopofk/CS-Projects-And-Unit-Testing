//Write a program that:

//· Read a list of integers

//· Remove all negative numbers from it

//· Print the remaining elements in reversed order

//· If there are no elements left in the list, print "empty"

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0)
    {
        list.Remove(list[i]);
        i--;
    }
}
if (list.Count == 0)
{
    Console.WriteLine("empty");
    return;
}
list.Reverse();
Console.WriteLine(string.Join(" ", list));