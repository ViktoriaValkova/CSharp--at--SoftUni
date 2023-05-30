using System;
namespace P08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double parameter =Math.PI * r*2;
            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", parameter);
        }
    }
}