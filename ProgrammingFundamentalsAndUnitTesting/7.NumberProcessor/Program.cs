int initial = int.Parse(Console.ReadLine());

string action = Console.ReadLine();
int sum = initial;

while ( action != "End")
{   
    if ( action == "Inc" )
    {
        sum = sum + 1;
    }
    
    else if ( action == "Dec")
    {
        sum = sum - 1;
    }
    
    action = Console.ReadLine();
}

Console.WriteLine(sum);