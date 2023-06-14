using System;

namespace P01.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyFee = int.Parse(Console.ReadLine());
            double sneakers = yearlyFee * 0.6;
            double clothes = sneakers * 0.8;
            double basketball = clothes * 0.25;
            double accessories = basketball * 0.2;

            Console.WriteLine($"{yearlyFee+sneakers+clothes+basketball+accessories:f2}");
        }
    }
}
