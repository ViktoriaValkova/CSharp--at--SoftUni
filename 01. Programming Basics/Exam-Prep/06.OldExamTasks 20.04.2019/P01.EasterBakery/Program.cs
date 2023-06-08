using System;

namespace P01.EasterBakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double flourPricePerKg = double.Parse(Console.ReadLine());
            double flourAmmountKg = double.Parse(Console.ReadLine());
            double sugarAmmountKg = double.Parse(Console.ReadLine());
            int eggCartonsCnt = int.Parse(Console.ReadLine());
            int heffeCnt = int.Parse(Console.ReadLine());
            double sugarPricePerKg = flourPricePerKg * 0.75;
            double eggCartonPrice = flourPricePerKg * 1.1;
            double heffePrice = sugarPricePerKg * 0.2;
            double finalPrice = flourPricePerKg * flourAmmountKg + sugarAmmountKg * sugarPricePerKg
                               + eggCartonsCnt * eggCartonPrice + heffePrice * heffeCnt;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
