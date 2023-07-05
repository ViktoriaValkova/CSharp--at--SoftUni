using System.Threading.Channels;

namespace P02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dungeons = Console.ReadLine()
                .Split('|')
                .ToArray();

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < dungeons.Length; i++)
            {
                string[] cmdArg = dungeons[i].Split();
                string command = cmdArg[0];

                if (command == "potion")
                {
                    int potion = int.Parse(cmdArg[1]);
                    TakePotion(ref health, potion);
                }
                else if (command == "chest")
                {
                    bitcoins += int.Parse(cmdArg[1]);
                    Console.WriteLine($"You found {int.Parse(cmdArg[1])} bitcoins.");
                }
                else // monster 
                {
                    int attackPower = int.Parse(cmdArg[1]);

                    if (!FightMonster(ref health, attackPower, command)) 
                    {
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
               
        }
        static bool FightMonster(ref int health, int attackPower, string monster)
        {
            health -= attackPower; 
            if (health <= 0)
            {
                Console.WriteLine($"You died! Killed by {monster}.");
                return false;
            }

            Console.WriteLine($"You slayed {monster}.");
            return true;
        }

        static void TakePotion(ref int  health, int potion)
         {
            int effectivePotion;
            if (health + potion > 100)
            {
                effectivePotion = 100 - health;
                health = 100;
            }
            else
            {
                health += potion;
                effectivePotion = potion;
            }

            Console.WriteLine($"You healed for {effectivePotion} hp.");
             Console.WriteLine($"Current health: {health} hp.");
         }
    }
}