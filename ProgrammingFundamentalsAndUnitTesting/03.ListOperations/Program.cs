using System.Collections.Generic;
using System.Globalization;
//The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.

//The possible commands are:

//· Add {number} – add the given number to the end of the list

//· Insert {number} { index} – insert the number at the given index

//· Remove {index} – remove the number at the given index

//· Shift left {count} – first number becomes last. This has to be repeated the specified number of times

//· Shift right {count} – last number becomes first. To be repeated the specified number of times

//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (true)
{
    string[] commands = Console.ReadLine().Split();

    if (commands[0] == "Add")//Add {number} – add the given number to the end of the list
    {
        int num = int.Parse(commands[1]);
        list.Insert(list.Count,num);
    }
   
    else if (commands[0] == "Insert") //· Insert {number} { index} – insert the number at the given index
    {
        int num = int.Parse(commands[1]);
        int index = int.Parse(commands[2]);
       
        if (index < 0 || index >= list.Count) //Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        list.Insert(index, num);
    }
    
    else if (commands[0] == "Remove")//· Remove {index} – remove the number at the given index
    {
        int index = int.Parse(commands[1]);
        
        if (index < 0 || index >= list.Count)//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
        {
            Console.WriteLine("Invalid index");
            continue;
        }

        list.RemoveAt(index);
    }
   
    else if (commands[0] == "Shift") //· Shift left {count} – first number becomes last. This has to be repeated the specified number of times
    {
        if (commands[1] == "left")
        {
            int shiftLoops = int.Parse(commands[2]);

            for (int i = 0; i < shiftLoops; i++)
            {
                int first = list[0];
                list.RemoveAt(0);
                list.Add(first);
            }
        }
        
        else if (commands[1] == "right")//· Shift right {count} – last number becomes first. To be repeated the specified number of times
        {
            int shiftLoops = int.Parse(commands[2]);

            for (int i = 0; i < shiftLoops; i++)
            {
                int last = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, last);
            }
        }
    }

    else if (commands[0] == "End")
    {
        Console.WriteLine(string.Join(" ", list));
        return;
    }
}


