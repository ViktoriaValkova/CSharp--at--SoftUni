using System;

namespace P04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int voucher = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int price = 0;
            int ticketCnt = 0;
            int othersCnt = 0; 
            bool isItTicket = false;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Length <= 8) // not a movie 
                {
                    price = input[0];                 
                }
                else // movie 
                {
                    price = input[0] + input[1];
                    isItTicket = true;
                }
                if (price > voucher)
                {
                     break ; 
                }
                voucher -= price;
                if (isItTicket)
                {
                    ticketCnt++;
                    isItTicket = false;
                }
                else
                {
                    othersCnt++;
                }
            }
            Console.WriteLine(ticketCnt);
            Console.WriteLine(othersCnt);
        }
    }
}
