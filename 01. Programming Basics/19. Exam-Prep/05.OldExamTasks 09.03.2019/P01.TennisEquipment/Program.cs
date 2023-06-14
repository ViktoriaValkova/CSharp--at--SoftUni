using System;

namespace P01.TennisEquipment       // 09/10.03.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine());
            int racketsCount = int.Parse(Console.ReadLine());
            int sneakersCount = int.Parse(Console.ReadLine());
            double sneakersPrice = racketPrice / 6.0;
            double priceSneakersAndRackets = sneakersPrice * sneakersCount + racketPrice * racketsCount;
            double others = priceSneakersAndRackets * 0.2;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor((priceSneakersAndRackets+others)/8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling((priceSneakersAndRackets+others)/8*7)}");
        }
    }
}
