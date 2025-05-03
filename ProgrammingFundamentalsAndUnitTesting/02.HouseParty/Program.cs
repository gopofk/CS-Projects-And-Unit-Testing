int numLines = int.Parse(Console.ReadLine()); // Read number of commands
List<string> names = new List<string>(); // Guest list

for (int i = 0; i < numLines; i++)
{
    string[] guests = Console.ReadLine().Split(); // Read command input
    string name = guests[0]; // First element is always the guest's name

    if (guests[2] == "going!") // Check if it's an "is going!" command
    {
        if (names.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            names.Add(name); // Add to guest list
        }
    }
    else if (guests[2] == "not") // Check if it's a "is not going!" command
    {
        if (names.Contains(name))
        {
            names.Remove(name); // Remove from the list
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

// Print the final list of guests
foreach (string guest in names)
{
    Console.WriteLine(guest);
}
