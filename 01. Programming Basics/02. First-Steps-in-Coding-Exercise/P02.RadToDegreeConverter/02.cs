using System;
namespace _02._Rad_to_degree_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = rad * 180 / Math.PI;
            Console.WriteLine(Math.Floor(grad));
        }
    }
}