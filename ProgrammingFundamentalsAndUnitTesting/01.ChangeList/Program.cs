//· Reads a list of integers from the console and receives commands to manipulate the list

//· Then until you receive "end", you will receive different commands:

//o "Delete {element}" – delete all elements in the list, which are equal to the given element

//o "Insert {element} {position}" – insert the element at the given position

//· When you receive the "end" command, print the final state of the list (separated by spaces)




List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

bool check = true;

while (true)
{
    List<string> action = Console.ReadLine()
    .Split()
    .ToList();

    string command = action[0];
    

    if (command == "end")
    {
        Console.WriteLine(string.Join(" ", list));
        return;
    }

    else if (command == "Delete")
    {
        int element = int.Parse(action[1]);
        list.RemoveAll(n => n == element);
        check = true;
    }

    else if (command == "Insert")
    {
        int element = int.Parse(action[1]);
        int position = int.Parse(action[2]);
        list.Insert(position, element);
        check = true;
    }
}