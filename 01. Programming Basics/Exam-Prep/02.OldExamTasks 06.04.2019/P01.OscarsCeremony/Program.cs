using System;

namespace P01 //Oscars 6/7.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statues = (double) rent * 0.7;
            double catering = statues * 0.85;
            double soundSystems = catering / 2.0;
            Console.WriteLine($"{ rent + statues + catering + soundSystems:f2}");
        }
    }
}
