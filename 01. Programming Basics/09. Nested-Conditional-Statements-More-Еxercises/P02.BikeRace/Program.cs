using System;
namespace P02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int junorCyclists = int.Parse(Console.ReadLine());
            int seniorCyclists = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();
            double taxForJunior = 0;
            double taxForSenior = 0;
            switch (raceType)
            {
                case"trail":
                    taxForJunior = 5.5;
                    taxForSenior = 7.0;
                    break;
                case "cross-country":
                    taxForJunior =8.0;
                    taxForSenior = 9.5;
                    break;
                case "downhill":
                    taxForJunior = 12.25;
                    taxForSenior = 13.75;
                    break;
                case "road":
                    taxForJunior = 20;
                    taxForSenior = 21.5;
                    break;         
            }
            if (junorCyclists + seniorCyclists >= 50)
            {
               if (raceType == "cross-country")
                {
                    taxForSenior *= 0.75;
                    taxForJunior *= 0.75;
                }
            }
            double moneyCollected = (seniorCyclists * taxForSenior + junorCyclists * taxForJunior) * 0.95;
            Console.WriteLine($"{moneyCollected:f2}");
        }
    }
}