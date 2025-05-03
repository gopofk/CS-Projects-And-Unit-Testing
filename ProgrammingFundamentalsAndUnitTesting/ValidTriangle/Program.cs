int sideOne = int.Parse(Console.ReadLine());
int sideTwo = int.Parse(Console.ReadLine());
int sideThree = int.Parse(Console.ReadLine());

if (sideOne < sideTwo + sideThree && sideTwo < sideOne + sideThree && sideThree < sideOne + sideTwo)
    Console.WriteLine("Valid Triangle");

else Console.WriteLine("Invalid Triangle");