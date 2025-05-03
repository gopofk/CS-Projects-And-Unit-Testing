string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double result = Order(product, quantity);
Console.WriteLine($"{result:F2}");

static double Order(string product, int quantity)
{
    double result = 0;
    double price = 0;
  
    if (product == "coffee")
    {
        price = 1.5;
    }
    if (product == "water")
    {
        price = 1;
    }
    if (product == "coke")
    {
        price = 1.4;
    }
    if (product == "snacks")
    {
        price = 2;
    }

    result = price * quantity;

    return result;
}