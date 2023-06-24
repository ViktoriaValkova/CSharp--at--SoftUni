using System;
using System.Linq;
namespace P03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers =
                Console.ReadLine()
            .Split()
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int rounded = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {rounded}");
            }

        }
    }
}