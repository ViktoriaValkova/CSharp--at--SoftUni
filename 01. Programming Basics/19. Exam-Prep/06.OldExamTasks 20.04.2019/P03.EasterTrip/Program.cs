using System;

namespace P03.EasterTrip // Exam 20/21.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string vacationPeriod = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            int pricePerNight = 0;

            if (vacationPeriod == "21-23")
            {
                switch (destination)
                {
                    case "France":
                        pricePerNight = 30;
                        break;
                    case "Italy":
                        pricePerNight = 28;
                        break;
                    case "Germany":
                        pricePerNight = 32;
                        break;
                }
            }
            else if (vacationPeriod == "24-27")
            {
                switch (destination)
                {
                    case "France":
                        pricePerNight = 35;
                        break;
                    case "Italy":
                        pricePerNight = 32;
                        break;
                    case "Germany":
                        pricePerNight = 37;
                        break;
                }
            }
            else
            {
                switch (destination)
                {
                    case "France":
                        pricePerNight = 40;
                        break;
                    case "Italy":
                        pricePerNight = 39;
                        break;
                    case "Germany":
                        pricePerNight = 43;
                        break;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {nightsCount*pricePerNight:f2} leva.");
        }
    }
}
