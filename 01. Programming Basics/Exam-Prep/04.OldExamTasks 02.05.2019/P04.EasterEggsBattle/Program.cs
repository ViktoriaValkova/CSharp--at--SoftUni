using System;

namespace P04.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int eggCntOne = int.Parse(Console.ReadLine());
           int eggCntTwo = int.Parse(Console.ReadLine());
            string winner= string.Empty;
            while ((winner = Console.ReadLine()) != "End")
            {
                if (winner == "one")
                {
                    eggCntTwo--;
                }
                else if (winner == "two")
                {
                    eggCntOne--;
                }
                if (eggCntOne == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggCntTwo} eggs left.");
                    break;
                }
                if (eggCntTwo == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggCntOne} eggs left.");
                    break;
                }
            }
            if (winner == "End")
            {
                Console.WriteLine($"Player one has {eggCntOne} eggs left.");
                Console.WriteLine($"Player two has {eggCntTwo} eggs left.");
            }
        }
    }
}
