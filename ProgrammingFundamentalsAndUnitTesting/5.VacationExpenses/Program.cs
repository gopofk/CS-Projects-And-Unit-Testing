string season = Console.ReadLine();
string accomodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double price = 0;
double discount = 0;

if  (season == "Spring")
{
    discount = 0.2;
    if (accomodation == "Hotel")
    {
        price = 30;
    }
    else if (accomodation == "Camping")
    {
        price = 10;
    }
}
else if (season == "Summer")
{
    discount = 0;
    if (accomodation == "Hotel")
    {
        price = 50;
    }
    else if (accomodation == "Camping")
    {
        price = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3;
    if (accomodation == "Hotel")
    {
        price = 20;
    }
    else if (accomodation == "Camping")
    {
        price = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1;
    if (accomodation == "Hotel")
    {
        price = 40;
    }
    else if (accomodation == "Camping")
    {
        price = 10;
    }
}

double cost = days * price;
double endCost = cost - (cost * discount);

Console.WriteLine($"{endCost:F2}");