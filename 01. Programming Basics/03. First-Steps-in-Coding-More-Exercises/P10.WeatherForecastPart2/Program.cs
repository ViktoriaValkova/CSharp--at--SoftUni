using System;
namespace P10.WeatherForecastPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            if (degrees >= 5 && degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees <= 35.00) 
            {
                Console.WriteLine("Hot");
            }
            else { Console.WriteLine("unknown"); }
        }
    }
}