using System;
namespace P10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input; 
            while ((input = double.Parse(Console.ReadLine())) >= 0)
            {
                Console.WriteLine($"Result: {input*2:f2}");
            }
            Console.WriteLine("Negative number!");
        }
    }
}