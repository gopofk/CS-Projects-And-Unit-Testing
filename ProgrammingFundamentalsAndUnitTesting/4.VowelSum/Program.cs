int charCount = int.Parse(Console.ReadLine());
int sum = 0;
int value = 0;

for (int i = 1;  i <= charCount; i++)
{
    char characters = char.Parse(Console.ReadLine()); 
    
    switch (characters)
    {
        case 'a':
            value = 1;
            break;

        case 'e':
            value = 2;
            break;

        case 'i':
            value = 3;
            break;

        case 'o':
            value = 4;
            break;

        case 'u':
            value = 5;
            break;

        default:
            value = 0;
            break;
    }

    sum = sum + value;
}

Console.WriteLine(sum);