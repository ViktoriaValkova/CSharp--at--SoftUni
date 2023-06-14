using System;

namespace P03.OscarsWeekInCinema     // 06/07.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
           
            if (typeHall == "normal")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born":
                        ticketPrice = 7.5;
                        break;
                    case "Bohemian Rhapsody":
                        ticketPrice = 7.35;
                        break;
                    case "Green Book":
                        ticketPrice = 8.15;
                        break;
                    case "The Favourite":
                        ticketPrice = 8.75;
                        break;
                }

            }
            if (typeHall == "luxury")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born":
                        ticketPrice = 10.5;
                        break;
                    case "Bohemian Rhapsody":
                        ticketPrice = 9.45;
                        break;
                    case "Green Book":
                        ticketPrice =10.25;
                        break;
                    case "The Favourite":
                        ticketPrice = 11.55;
                        break;
                }
            }
            if (typeHall == "ultra luxury")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born":
                        ticketPrice = 13.5;
                        break;
                    case "Bohemian Rhapsody":
                        ticketPrice = 12.75;
                        break;
                    case "Green Book":
                        ticketPrice = 13.25;
                        break;
                    case "The Favourite":
                        ticketPrice = 13.95;
                        break;
                }
            }
            double income = ticketPrice * numberOfTickets;
            Console.WriteLine($"{nameOfMovie} -> {income:f2} lv.");
        }
    }
}
