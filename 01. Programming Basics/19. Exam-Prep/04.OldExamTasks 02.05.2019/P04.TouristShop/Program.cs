using System;

namespace P04.TouristShop  // 02/03.05.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string product = String.Empty;
            int productCounter = 0;
            double price = 0;
            bool noMoney = false;
            double totalPrice = 0;
            while ((product = Console.ReadLine()) != "Stop")
            {

                price = double.Parse(Console.ReadLine());
                productCounter++;
                if (productCounter % 3 == 0)
                {
                    price /= 2.0;
                }
                if (price > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {price - budget:f2} leva!");
                    noMoney = true;
                    break;
                }
                budget -= price;
                totalPrice += price;
            }
            if (!noMoney)
            {
                Console.WriteLine($"You bought {productCounter} products for {totalPrice:f2} leva.");
            }
        }
    }
}
