double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volumeCm = length *  width * height;
double volumeLiters = volumeCm * 0.001;
double occupied = volumeLiters * (percentage/100);
double litersNeeded = volumeLiters -  occupied;

Console.WriteLine($"{litersNeeded:F2}");