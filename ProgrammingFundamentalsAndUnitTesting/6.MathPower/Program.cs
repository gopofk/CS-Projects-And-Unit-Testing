namespace _6.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseN = int.Parse(Console.ReadLine());
            int powerN = int.Parse(Console.ReadLine());
            MathPower(baseN, powerN);
            
            static void MathPower(int baseN, int powerN)
            {
                int result = baseN;
                for (int i = 1; i < powerN; i++)
                {
                    result *= baseN;
                }
                Console.WriteLine(result);
            }  
        }
    }
}
