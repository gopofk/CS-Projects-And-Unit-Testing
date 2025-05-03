int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int totalSeconds = first + second + third;
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

if (seconds < 10)
{
    Console.WriteLine((minutes)+ ":" + "0" + (seconds));
}
else
{
    Console.WriteLine((minutes) + ":" + (seconds));
}
