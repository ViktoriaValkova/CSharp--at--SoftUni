using System;

namespace P05.DivisionWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine ());
            int dividedByTwo = 0;
            int dividedByThree = 0;
            int dividedByFour = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    dividedByTwo++;
                }
                if (currentNumber % 3 == 0)
                {
                    dividedByThree++;
                }
                if (currentNumber % 4 == 0)
                {
                    dividedByFour++;
                }
            }
            Console.WriteLine($"{(double)dividedByTwo/n*100:f2}%");
            Console.WriteLine($"{(double)dividedByThree/n*100:f2}%");
            Console.WriteLine($"{(double)dividedByFour/n*100:f2}%");
        }
    }
}
