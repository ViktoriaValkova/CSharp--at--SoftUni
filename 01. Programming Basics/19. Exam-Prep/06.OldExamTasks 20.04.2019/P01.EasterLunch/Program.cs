using System;

namespace P01.EasterLunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunakCnt = int.Parse(Console.ReadLine());
            int eggCartons = int.Parse(Console.ReadLine());
            int cookieKgs = int.Parse(Console.ReadLine());
            double eggsPrice = eggCartons * 4.35 + eggCartons * 12 * 0.15;
            double price = kozunakCnt * 3.2 + eggsPrice + cookieKgs * 5.4;
            Console.WriteLine($"{price:f2}");
        }
    }
}
