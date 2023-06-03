using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine(); //until "Finish"
            int avaliableSeatsCurrentMovie = 0;
            string ticketType = ""; // until "End" 
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTicketsCurrMovie = 0;
            int totalTickets = 0;  // can be avoided, by just adding the tickets for each group overall

            while (movieName != "Finish")
            {
                avaliableSeatsCurrentMovie = int.Parse(Console.ReadLine());
                while ((ticketType = Console.ReadLine()) != "End") 
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++; 
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++; 
                            break;
                    }
                    totalTicketsCurrMovie++;
                    totalTickets++;
                    if (totalTicketsCurrMovie == avaliableSeatsCurrentMovie)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movieName} - {totalTicketsCurrMovie * 100.0 / avaliableSeatsCurrentMovie:f2}% full.");
                totalTicketsCurrMovie = 0;
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}
