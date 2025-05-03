int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    if (i == 2)
    {
        Console.Write(i);
    }
    
    int counter = 0;

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0) 
        { 
            counter++; 
        }
        
    }
    if (counter == 2)
    {
        Console.Write(i+" ");
    }
}