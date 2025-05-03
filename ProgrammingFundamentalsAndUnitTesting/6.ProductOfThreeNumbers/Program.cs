double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

// Try to do this without multiplying the numbers.

if (a == 0 ||  b == 0 || c == 0)
{
    Console.WriteLine("zero");
}

else if (a < 0 && b < 0 && c > 0|| a < 0 && c < 0 && b > 0 || b < 0 && c < 0 && a > 0)
{
    Console.WriteLine("positive");
}
else if (a < 0 && b > 0 && c > 0 || a > 0 && c < 0 && b > 0 || b < 0 && c > 0 && a > 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("positive");
}