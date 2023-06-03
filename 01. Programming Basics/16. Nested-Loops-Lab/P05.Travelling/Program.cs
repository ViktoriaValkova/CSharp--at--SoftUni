using System;
namespace P05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination ="";
            double budget = 0;
            double sumAdded = 0;

            while ((destination=Console.ReadLine())  != "End")
            {
                budget = double.Parse(Console.ReadLine());
                while (sumAdded < budget)
                {
                    sumAdded += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                sumAdded = 0;
            }

        }
    }
}
