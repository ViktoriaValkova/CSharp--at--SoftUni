using System;

namespace P01.PoolDay        // 06/07.07.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryFee = double.Parse(Console.ReadLine());
            double sheslongPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());
            double sheslongFinalPrice = Math.Ceiling(people * 0.75) * sheslongPrice;
            double umbrellaFinalPrice = Math.Ceiling(people / 2.0) * umbrellaPrice;
            double finalPrice = people * entryFee + sheslongFinalPrice + umbrellaFinalPrice;
            Console.WriteLine($"{finalPrice:f2} lv.");

        }
    }
}
