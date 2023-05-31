using System;
namespace newProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double vodaOtPurvaTruba = h * p1;
            double vodaOtVtoraTruba = h * p2;
            double voda = vodaOtPurvaTruba + vodaOtVtoraTruba;
            if (voda <= v)
            {
                double vodaProcent = voda / v * 100.0;
                double vodaProcentP1 = Math.Round(vodaOtPurvaTruba / voda * 100.0, 2);
                double vodaProcentP2 = Math.Round(vodaOtVtoraTruba / voda * 100.0, 2);
                Console.WriteLine($"The pool is {vodaProcent}% full. Pipe 1: {vodaProcentP1}%. Pipe 2: {vodaProcentP2}%.");
            }
            else
            {
                double overflow = voda - v;
                Console.WriteLine($"For {h} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}