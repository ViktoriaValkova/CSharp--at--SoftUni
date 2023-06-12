using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = string.Empty;
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickeys = 0;
            int kidTickets = 0;
            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int emptySeats = int.Parse(Console.ReadLine());
                string ticketType = string.Empty;
                int soldTickets = 0;
                while ((ticketType = Console.ReadLine()) != "End")
                {
                    soldTickets++;
                    totalTickets ++;
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard": standardTickeys++; break;
                        case "kid": kidTickets++; break;
                    }

                    if (soldTickets == emptySeats)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movieName} - {(double)soldTickets / emptySeats * 100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickeys / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
