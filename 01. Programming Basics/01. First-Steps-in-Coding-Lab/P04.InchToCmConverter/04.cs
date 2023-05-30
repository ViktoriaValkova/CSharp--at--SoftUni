using System;
namespace _04._Inch_to_Cm_converte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 2.54;
            Console.WriteLine(b);
        }
    }
}