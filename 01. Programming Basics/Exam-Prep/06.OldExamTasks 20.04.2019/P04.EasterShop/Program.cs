using System;

namespace P04.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsInShopCnt = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int soldEggsounter = 0;
            while ((command = Console.ReadLine()) != "Close")
            {
                int currentCntEggs = int.Parse(Console.ReadLine());
                if (command == "Buy")
                {
                    if (currentCntEggs > eggsInShopCnt)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInShopCnt}.");
                        break;
                    }
                    eggsInShopCnt -= currentCntEggs;
                    soldEggsounter += currentCntEggs;
                }
                else
                {
                    eggsInShopCnt += currentCntEggs;
                }
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggsounter} eggs sold.");
            }
        }
    }
}
