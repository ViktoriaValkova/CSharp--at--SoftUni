using System;
namespace newProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int count = puzzleCount + dollCount + bearCount + minionsCount + truckCount;

            double prihodPoruchka = (puzzleCount * 2.60) + (dollCount * 3.00) + (bearCount * 4.10) + (minionsCount * 8.20) + (truckCount * 2.00);



            /*double otstupka = 0;
            if (count >= 50)
            {
                otstupka = prihodPoruchka * 0.25;
            }
            double prihodKraen = prihodPoruchka - otstupka;
            double ostatukSledNaem = prihodKraen - prihodKraen * 0.1;
                Tuk prihodSledNaem bi bil Ostatuk sled Naem*/

            if (count >= 50)
            {
                prihodPoruchka = prihodPoruchka * 0.75;
            }
            double prihodSledNaem = prihodPoruchka * 0.9;

            if (prihodSledNaem >= priceExcursion)
            {
                ;
                Console.WriteLine($"Yes! {prihodSledNaem - priceExcursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceExcursion - prihodSledNaem:f2} lv needed.");
            }

        }
    }
}
