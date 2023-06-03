using System;

namespace P02.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleCnt = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine()) * peopleCnt;
            if (peopleCnt > 150)
            {
                clothesPrice *= 0.9;
            }
            double decorPrice = budget * 0.1;
            double finalPrice = decorPrice + clothesPrice;
            if (finalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - finalPrice:f2} leva left.");
            }
        }
    }
}
