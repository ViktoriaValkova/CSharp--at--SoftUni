using System;

namespace P05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            double sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum/n:f2}");
        }
    }
}
