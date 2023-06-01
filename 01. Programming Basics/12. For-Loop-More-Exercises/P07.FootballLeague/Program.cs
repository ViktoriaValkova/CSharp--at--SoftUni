using System;

namespace P07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int sumFans = int.Parse(Console.ReadLine());
            int sectorA = 0; int sectorB = 0; int sectorV = 0; int sectorG = 0;
            for (int i = 0; i < sumFans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A": sectorA++; break;
                    case "B": sectorB++; break;
                    case "V": sectorV++; break;
                    case "G": sectorG++; break;
                }
            }
            Console.WriteLine($"{sectorA * 1.0 / sumFans * 100:f2}%");
            Console.WriteLine($"{sectorB * 1.0 / sumFans * 100:f2}%");
            Console.WriteLine($"{sectorV * 1.0 / sumFans * 100:f2}%");
            Console.WriteLine($"{sectorG * 1.0 / sumFans * 100:f2}%");
            Console.WriteLine($"{sumFans * 1.0 / capacity * 100:f2}%");
        }
    }
}
