double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
string action = Console.ReadLine();

if (action == "+")
{
    Console.WriteLine($"{x} + {y} = {x + y:F2}");
}

else if (action == "-")
{
    Console.WriteLine($"{x} - {y} = {x - y:F2}");
}

else if (action == "*")
{
    Console.WriteLine($"{x} * {y} = {x * y:F2}");
}

else if (action == "/")
{
    Console.WriteLine($"{x} / {y} = {x / y:F2}");
}