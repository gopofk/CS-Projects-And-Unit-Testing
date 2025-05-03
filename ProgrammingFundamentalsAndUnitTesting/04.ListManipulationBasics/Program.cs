//using System.Collections.Generic;

//Reads a list of integers

//· Then until you receive "end", you will receive different commands:

//o "Add {number}": add a number to the end of the list

//o "Remove {number}": remove a number from the list

//o "RemoveAt {index}": remove a number at a given index

//o "Insert {number} {index}": insert a number at a given index

//· When you receive the "end" command, print the final state of the list (separated by spaces)

//Note: All the indices will be valid!


List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (true)
{
    string[] commands = Console.ReadLine().Split();

    if (commands[0] == "Add") //"Add {number}": add a number to the end of the list
    {
        int num = int.Parse (commands[1]);
        list.Insert(list.Count, num);
    }

    else if (commands[0] == "Remove") //"Remove {number}": remove a number from the list
    {
        int num = int.Parse(commands[1]);
        list.Remove(num);
    }

    else if (commands[0] == "RemoveAt")//"RemoveAt {index}": remove a number at a given index
    {
        int num = int.Parse(commands[1]);
        list.RemoveAt(num);
    }

    else if (commands[0] == "Insert")//"Insert {number} {index}": insert a number at a given index
    {
        int num = int.Parse(commands[1]);
        int index = int.Parse(commands[2]);
        list.Insert(index, num);
    }

    else if (commands[0] == "end")
    {
        Console.WriteLine(string.Join(" ", list));
        return;
    }
}