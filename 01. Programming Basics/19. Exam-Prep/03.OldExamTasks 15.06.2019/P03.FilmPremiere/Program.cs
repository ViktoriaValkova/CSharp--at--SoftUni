using System;

namespace P03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string moviePacket = Console.ReadLine();
            int ticketsCnt = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (movieName == "John Wick")
            {
                switch (moviePacket)
                {
                    case "Drink": ticketPrice = 12; break;
                    case "Popcorn": ticketPrice = 15; break;
                    case "Menu": ticketPrice = 19; break;
                }
            }
            else if (movieName == "Star Wars")
            {
                switch (moviePacket)
                {
                    case "Drink": ticketPrice = 18; break;
                    case "Popcorn": ticketPrice = 25; break;
                    case "Menu": ticketPrice = 30; break;
                }
            }
            else
            {
                switch (moviePacket)
                {
                    case "Drink": ticketPrice = 9; break;
                    case "Popcorn": ticketPrice = 11; break;
                    case "Menu": ticketPrice = 14; break;
                }
            }
            double finalPrice = ticketPrice * ticketsCnt;
            if (movieName == "Star Wars" && ticketsCnt >= 4)
            {
                finalPrice *= 0.7;
            }
            if (movieName == "Jumanji" && ticketsCnt == 2)
            {
                finalPrice *= 0.85;
            }
            Console.WriteLine($"Your bill is {finalPrice:f2} leva.");
        }
    }
}
