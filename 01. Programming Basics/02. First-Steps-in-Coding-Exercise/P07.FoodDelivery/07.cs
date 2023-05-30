using System;
namespace _07._Food_delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pile = double.Parse(Console.ReadLine());
            double riba = double.Parse(Console.ReadLine());
            double veggie = double.Parse(Console.ReadLine());
            double a = pile * 10.35;
            double b = riba * 12.40;
            double c = veggie * 8.15;
            double dessert = (a + b + c) * 0.2;
            double suma = a + b + c + dessert + 2.5;
            Console.WriteLine(suma);
        }
    }
}