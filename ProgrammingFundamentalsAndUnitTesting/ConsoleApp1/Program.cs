int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pricePens = pens * 5.8;
double priceMarkers = markers * 7.2;
double priceLiters = liters * 1.2;
double priceMats = pricePens+priceMarkers+priceLiters;
double discountPrice = (priceMats * discount) / 100;

Console.WriteLine(priceMats - discountPrice);
