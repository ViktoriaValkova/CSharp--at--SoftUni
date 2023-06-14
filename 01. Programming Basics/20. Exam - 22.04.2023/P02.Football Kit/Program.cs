using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double sumNeededForBall = double.Parse(Console.ReadLine());

            double shortsPrice = shirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double shoesPrice = (shirtPrice + shortsPrice) * 2.0;
            double sumPrice = (shoesPrice + shortsPrice + socksPrice + shirtPrice) * 0.85;
            if (sumPrice >= sumNeededForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumNeededForBall-sumPrice:f2} lv. more.");
            }
        }
    }
}
