using System.Numerics;

namespace P02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= input; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}