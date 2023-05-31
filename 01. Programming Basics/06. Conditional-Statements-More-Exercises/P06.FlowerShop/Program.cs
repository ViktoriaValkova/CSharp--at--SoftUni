using System;
namespace P06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactei = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());
            double incomeFromOrder = (magnolii * 3.25 + zumbuli * 4.0 + roses * 3.5 + cactei * 8.0) * 0.95;
            if (incomeFromOrder >= priceOfGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(incomeFromOrder - priceOfGift)} leva.");            
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceOfGift - incomeFromOrder)} leva.");
            }
        }
    }
}