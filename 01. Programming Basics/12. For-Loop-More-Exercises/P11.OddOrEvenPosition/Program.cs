using System;

namespace P11.OddOrEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumOdd = 0;
            double maxNumberOdd = int.MinValue;
            double minNumberOdd = int.MaxValue;
            double sumEven = 0;
            double maxNumberEven = int.MinValue;
            double minNumberEven = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0) // even position of the cycle 
                {
                    sumEven += number;
                    if (number > maxNumberEven)
                    {
                        maxNumberEven = number;
                    }
                    if (number < minNumberEven)
                    {
                        minNumberEven = number;
                    }
                }
                else // when position is odd 
                {
                    sumOdd += number;
                    if (number > maxNumberOdd)
                    {
                        maxNumberOdd = number;
                    }
                    if (number < minNumberOdd)
                    {
                        minNumberOdd = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={sumOdd:f2},");
            if (n >= 1)    //check if n=0, there would be no even or odd positions 
            {
                Console.WriteLine($"OddMin={minNumberOdd:f2},");
                Console.WriteLine($"OddMax={maxNumberOdd:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine($"EvenSum={sumEven:f2},");
            if (n > 1)  //check if n = 1, there would ne only one (even position)
            {
                Console.WriteLine($"EvenMin={minNumberEven:f2},");
                Console.WriteLine($"EvenMax={maxNumberEven:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
