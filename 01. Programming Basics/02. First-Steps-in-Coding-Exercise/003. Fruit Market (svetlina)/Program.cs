using System;
namespace _003._Fruit_Market__svetlina_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double strawberryPrice = double.Parse(Console.ReadLine());
            double banana = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());    
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            double raspberryPrice = strawberryPrice * 0.5;
            double orangesPrice = raspberryPrice * 0.6;
            double bananaPrice = raspberryPrice * 0.2;
            double priceAll = strawberryPrice * strawberries + oranges * orangesPrice + bananaPrice * banana + raspberryPrice * raspberries;
            Console.WriteLine("{0:f2}",priceAll);
        }
    }
}