using System;

namespace P04.BachelorParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyForSinger = int.Parse(Console.ReadLine());
            int moneyCollected = 0;
            int allGuests = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "The restaurant is full")
            {
                int currentGuestCnt = int.Parse(command);
                allGuests += currentGuestCnt;
                if (currentGuestCnt < 5)
                {
                    moneyCollected += currentGuestCnt * 100;
                }
                else
                {
                    moneyCollected += currentGuestCnt * 70;
                }
            }
            if (moneyCollected >= moneyForSinger)
            {
                Console.WriteLine($"You have {allGuests} guests and {moneyCollected - moneyForSinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {allGuests} guests and {moneyCollected} leva income, but no singer.");
            }
        }
    }
}
