double yearFee = double.Parse(Console.ReadLine());

double sneakers = yearFee - (yearFee * 0.40);
double uniform = sneakers - (sneakers * 0.20);
double ball = uniform / 4;
double accessories = ball / 5;

double totalCost = yearFee + sneakers + uniform + ball + accessories;
Console.WriteLine(totalCost);