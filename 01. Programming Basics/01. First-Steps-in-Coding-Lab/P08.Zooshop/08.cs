using System;
namespace _08._Zooshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double result = (dogFood * 2.5) + (catFood * 4);
            Console.WriteLine(result + " lv.");
        }
    }
}