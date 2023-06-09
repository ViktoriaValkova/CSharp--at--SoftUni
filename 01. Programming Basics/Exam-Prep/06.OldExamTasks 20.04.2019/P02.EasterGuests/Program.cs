using System;

namespace P02.EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestCnt = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double kozunakCnt = Math.Ceiling((double)guestCnt / 3);
            double eggsCnt = guestCnt * 2;
            double finalPrice = kozunakCnt * 4 + eggsCnt * 0.45;
            if (finalPrice <= budget)
            {
                Console.WriteLine($"Lyubo bought {kozunakCnt} Easter bread and {eggsCnt} eggs.");
                Console.WriteLine($"He has {budget - finalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {finalPrice - budget:f2} lv. more.");
            }
        }
    }
}
