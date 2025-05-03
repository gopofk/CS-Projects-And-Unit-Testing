string destination = Console.ReadLine();
double neededBudget = double.Parse(Console.ReadLine());
double budget = 0;
double goal = 0;

while (destination != "End")
{
    while (goal < neededBudget)
    {
        budget = double.Parse(Console.ReadLine());
        goal = goal + budget;
        Console.WriteLine($"Collected: {goal:F2}");
    }
    Console.WriteLine($"Going to {destination}!");
    budget = 0;
    goal = 0;
    destination = Console.ReadLine();
    if (destination == "End")
    {
        break;
    }
    neededBudget = double.Parse(Console.ReadLine());
}