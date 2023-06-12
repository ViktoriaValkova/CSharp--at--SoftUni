using System;

namespace P05.EasterBake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int kozunakCnt = int.Parse(Console.ReadLine());
            int sugarInGrams = 0;
            int flourInGrams = 0;
            int maxSugar = 0;
            int maxFlour = 0;
            int sumSugar = 0;
            int sumFlour = 0;
            for (int i = 0; i < kozunakCnt; i++)
            {
                 sugarInGrams = int.Parse(Console.ReadLine());
                sumSugar += sugarInGrams;
                flourInGrams = int.Parse(Console.ReadLine());
                sumFlour += flourInGrams;
                if (sugarInGrams > maxSugar)
                {
                    maxSugar = sugarInGrams;
                }
                if (flourInGrams > maxFlour)
                {
                    maxFlour = flourInGrams;
                }
            }
            double sugarPackets = Math.Ceiling(sumSugar / 950.0);
            double flourPackets = Math.Ceiling(sumFlour / 750.0);
            Console.WriteLine($"Sugar: {sugarPackets}");
            Console.WriteLine($"Flour: {flourPackets}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");


        }
    }
}
