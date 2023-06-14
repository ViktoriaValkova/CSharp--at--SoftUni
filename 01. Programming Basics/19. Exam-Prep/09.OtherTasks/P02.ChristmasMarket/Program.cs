using System;

namespace P02.ChristmasMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyGoal = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());

            double moneyGathered = (fantasyBooks * 14.9 + horrorBooks * 9.8 + romanticBooks * 4.3) * 0.8;
            if (moneyGoal > moneyGathered)
            {
                Console.WriteLine($"{moneyGoal - moneyGathered:f2} money needed.");
            }
            else
            {
                double moneyForSellers = Math.Floor((moneyGathered-moneyGoal) * 0.1);
                moneyGathered -= moneyForSellers;
                Console.WriteLine($"{moneyGathered:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {moneyForSellers:f2} leva.");
            }
        }
    }
}
