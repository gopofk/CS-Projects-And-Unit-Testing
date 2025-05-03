string text = Console.ReadLine();
int repeat = int.Parse(Console.ReadLine());

RepeatString(text, repeat);

static void RepeatString(string text, int repeat)
{
    for (int i = 1; i <= repeat; i++)
    {
        Console.Write(text);
    }
}
