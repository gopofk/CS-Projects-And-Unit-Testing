int temp = int.Parse(Console.ReadLine());
string time = Console.ReadLine();

string clothing;
string shoes;

if (10 <= temp && temp <= 18)
{
    switch (time)
    {
        case "Morning":
            clothing = "Sweatshirt";
            shoes = "Sneakers";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
                break;
        
        case "Afternoon":
            clothing = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
                break;
        
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;
    }
}
else if (18 < temp && temp <= 24)
{
    switch (time)
    {
        case "Morning":
            clothing = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;

        case "Afternoon":
            clothing = "T-Shirt";
            shoes = "Sandals";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;

        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;
    }
}
else if (temp >= 25)
{
    switch (time)
    {
        case "Morning":
            clothing = "T-Shirt";
            shoes = "Sandals";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;

        case "Afternoon":
            clothing = "Swim Suit";
            shoes = "Barefoot";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;

        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine("It's " + (temp) + " degrees, get your " + (clothing) + " and " + (shoes) + ".");
            break;
    }
}
