int n = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1 ; i <= n; i++) 
{
   double x = double.Parse(Console.ReadLine());
   sum = sum + x;
}
Console.WriteLine(sum);