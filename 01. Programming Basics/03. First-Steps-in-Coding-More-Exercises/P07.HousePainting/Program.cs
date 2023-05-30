using System;
namespace P07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double paintForRoof = (2 * x * y + x * h) / 4.3;
            double paintForHouse = (x * x + (x * x - 1.2 * 2) + 2 * (x * y - 1.5 * 1.5)) / 3.4;
            Console.WriteLine("{0:f2}", paintForHouse);
            Console.WriteLine("{0:f2}", paintForRoof);
        }
    }
}