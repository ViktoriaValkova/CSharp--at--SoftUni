using System;
namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sand = double.Parse(Console.ReadLine()) / 100.0;
            double obem = (length * height * width) / 1000.0;
            double voda = obem - obem * sand;
            Console.WriteLine(voda);
        }
    }
}