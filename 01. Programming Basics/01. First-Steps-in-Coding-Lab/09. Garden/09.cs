using System;
namespace _02._Numbers_1_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"Final price is: {finalPrice}");
            Console.WriteLine($"Discount is: {discount}");
        }
    }
}