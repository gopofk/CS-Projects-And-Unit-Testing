double chickenMenu = 10.35;
double fishMenu = 12.40;
double vegMenu = 8.15;
double delivery = 2.50;

double chickenOrder = double.Parse(Console.ReadLine());
double fishOrder = double.Parse(Console.ReadLine());
double vegOrder = double.Parse(Console.ReadLine());

double chickenPrice = chickenMenu * chickenOrder;
double fishPrice = fishMenu * fishOrder;
double vegPrice = vegMenu * vegOrder;

double menusPrice = chickenPrice + fishPrice + vegPrice;

double dessert = menusPrice * 0.2;

double totalBill = menusPrice + dessert;

double totalCost = totalBill + delivery;

Console.WriteLine(totalCost);