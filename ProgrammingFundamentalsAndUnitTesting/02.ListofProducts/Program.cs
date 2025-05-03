int lines = int.Parse(Console.ReadLine());
List<string> list = new List<string>()
    .ToList();

for (int i = 0; i < lines; i++)
{
    list.Add(Console.ReadLine());
}
list.Sort();

for (int i = 0;i < list.Count; i++)
{
    Console.WriteLine($"{i + 1}.{list[i]}");
}


//· Read an integer number n and n lines of products

//· Print a numbered list of all the products ordered by name

//Example

//Input Output

//4

//Potatoes

//Tomatoes

//Onions

//Apples
//
//1.Apples
//2.Onions
//3.Potatoes
//4.Tomatoes