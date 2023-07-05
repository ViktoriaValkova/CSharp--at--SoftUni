using System.Diagnostics.CodeAnalysis;

namespace P02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split('|')
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] cmdArg = input.Split(" ",2);
                string command = cmdArg[0];

                if (command == "Loot")
                {
                    string[] items = cmdArg[1].Split();
                    LootItems(treasureChest, items);
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(cmdArg[1]);
                    DropItem(treasureChest, index);
                }
                else // steal
                {
                    int count = int.Parse(cmdArg[1]);
                    StealItems (treasureChest, count);
                }
            }
            if (treasureChest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }
            double sumLengthItems = SumLength(treasureChest);
            Console.WriteLine($"Average treasure gain: {sumLengthItems/treasureChest.Count:f2} pirate credits.");
        }
        static void LootItems(List<string> treasureChest, string[] items)
        {
            foreach (string item in items)
            {
                if (!treasureChest.Contains(item))
                {
                    treasureChest.Insert(0,item);
                }
            }
        }
        static bool IsIndexValid(List<string> treasureChest, int index)
        {
           if (index < 0 || index >= treasureChest.Count)
           {
               return false;
           }

           return true; 
        }
        static void DropItem(List<string> treasureChest, int index)
        {
            if (!IsIndexValid(treasureChest, index))
            {
                return;
            }

            string currentLoot = treasureChest[index];
            treasureChest.RemoveAt(index);
            treasureChest.Add(currentLoot);
        }
        static void StealItems(List<string> treasureChest, int count)
        {
            if (count > treasureChest.Count)
            {
                count = treasureChest.Count;
            }

            treasureChest.Reverse();
           List<string> removedList = treasureChest.GetRange(0, count);
           treasureChest.RemoveRange(0,count);
           treasureChest.Reverse();
           removedList.Reverse();
           Console.WriteLine(string.Join(", ",removedList));

        }
        static double SumLength(List<string> treasureChest)
        {
            int sum = 0;
            foreach (string treasure in treasureChest)
            {
                sum += treasure.Length;
            }
            return sum;
        }
    }
}