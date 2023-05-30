using System;
namespace newProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());
            double prihodLeva = priceFruit * kgFruit + priceVeg * kgVeg;
            double prihodEuro = prihodLeva / 1.94;
            Console.WriteLine("{0:F2}", prihodEuro);
        }
    }
}