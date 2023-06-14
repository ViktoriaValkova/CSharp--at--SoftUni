using System;

namespace P03.WorldSnookerChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournamentStage = Console.ReadLine(); // “Quarter final”, “Semi final” или “Final”
            string ticketType = Console.ReadLine(); // “Standard”, “Premium” или “VIP”
            int ticketCount = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (tournamentStage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard": ticketPrice = 55.5;
                            break;
                    case "Premium": ticketPrice = 105.2;
                            break;
                    case "VIP": ticketPrice = 118.9;
                            break;
                }
            }
            else if (tournamentStage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        ticketPrice = 75.88;
                            break;
                    case "Premium":
                        ticketPrice = 125.22;
                            break;
                    case "VIP":
                        ticketPrice = 300.40;
                            break;
                }
            }
            else
            {
                switch (ticketType)
                {
                    case "Standard":
                        ticketPrice = 110.1;
                            break;
                    case "Premium":
                        ticketPrice = 160.66;
                            break;
                    case "VIP":
                        ticketPrice = 400.0;
                            break;
                }
            }
            double sumPrice = ticketPrice * ticketCount;
            int photoPrice = 0;
             if (photo == 'Y')
            {
                photoPrice = 40 * ticketCount;
            }
            else
            {
                photoPrice = 0;
            }
            
            if (sumPrice > 4000)
            {
                sumPrice *= 0.75;
                photoPrice = 0;
            }
            else if (sumPrice > 2500)
            {
                sumPrice *= 0.9;
            }
           
            Console.WriteLine($"{sumPrice+photoPrice:f2}");
        }
    }
}
