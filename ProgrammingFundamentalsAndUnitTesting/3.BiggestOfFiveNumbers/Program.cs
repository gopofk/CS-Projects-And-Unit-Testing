int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());
int four = int.Parse(Console.ReadLine());
int five =  int.Parse(Console.ReadLine());

if ( one >  two && one > three && one > four && one > five)
{
    Console.WriteLine(one);
}
else if ( two > one && two > three && two > four && two > five)
{
    Console.WriteLine(two);
}
else if (three > one && three > two && two > four && two > five)
{
    Console.WriteLine(three);
}
else if (four > one && four > two && four > three && two > five)
{
    Console.WriteLine(two);
}
else 
{
    Console.WriteLine(five);
}

