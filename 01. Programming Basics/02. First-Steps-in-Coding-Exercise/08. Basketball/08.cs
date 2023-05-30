using System;
namespace _08._Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double shoes = tax - tax * 0.4;
            double clothes = shoes - shoes * 0.2;
            double ball = clothes / 4.0;
            double other = ball / 5.0;
            double razhod = tax + shoes + clothes + ball + other;
            Console.WriteLine(razhod);
        }
    }
}