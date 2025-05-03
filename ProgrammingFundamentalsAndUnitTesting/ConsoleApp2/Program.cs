int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());

switch (numOne < numTwo && numTwo < numThree) 
{
    case true:
        Console.WriteLine("Ascending");
        break;

    case false:
       if (numOne > numTwo && numTwo > numThree)
            Console.WriteLine("Descending");
       
        else
            Console.WriteLine("Not sorted");
        break;
}