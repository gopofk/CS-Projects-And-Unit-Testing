string text = Console.ReadLine();
int result = VowelCount(text);
Console.WriteLine(result);
static int VowelCount(string text)
{
    int vowelCount = 0;
 
    for (int i = 0; i < text.Length; i++)
    {
        switch (text[i])
        {
            case 'a':
                vowelCount += 1;
                break;
            case 'e':
                vowelCount += 1;
                break;
            case 'i':
                vowelCount += 1;
                break;
            case 'o':
                vowelCount += 1;
                break;
            case 'u':
                vowelCount += 1;
                break;
            case 'A':
                vowelCount += 1;
                break;
            case 'E':
                vowelCount += 1;
                break;
            case 'I':
                vowelCount += 1;
                break;
            case 'O':
                vowelCount += 1;
                break;
            case 'U':
                vowelCount += 1;
                break;
        }
    }
    return vowelCount;
}
