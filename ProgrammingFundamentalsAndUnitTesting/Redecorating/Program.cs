double nylon = 1.50;
double paint = 14.50;
double thinner = 5.00;
double bags = 0.40; 

double nylonAmount = double.Parse(Console.ReadLine());
double paintAmount = double.Parse(Console.ReadLine());
double thinnerAmount = double.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

double nylonPrice = nylon * (nylonAmount + 2);
double paintPrice = paint * (paintAmount + (paintAmount * 0.10));
double thinnerPrice = thinner * thinnerAmount;
double matPrice = nylonPrice + paintPrice + thinnerPrice + bags;

double craftsmen = (matPrice * 0.30) * hours;

double totalPrice = craftsmen + matPrice;

Console.WriteLine(totalPrice);
