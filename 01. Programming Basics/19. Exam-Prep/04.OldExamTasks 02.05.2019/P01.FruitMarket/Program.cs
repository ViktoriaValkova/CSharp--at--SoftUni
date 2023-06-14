using System;
using System.Transactions;

namespace P01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberryPrice * 0.5;
            double orangesPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;

            double finalPrice = strawberriesKg * strawberryPrice + raspberriesPrice * raspberriesKg
                                + orangesKg * orangesPrice + bananasKg * bananasPrice;
            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}
