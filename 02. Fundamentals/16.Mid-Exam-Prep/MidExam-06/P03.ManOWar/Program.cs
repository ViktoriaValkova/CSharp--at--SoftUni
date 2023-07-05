namespace P03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] pirateShip = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToArray();

            int [] warship = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToArray();

            int maxHealth = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] cmdArg =input.Split();

                string command = cmdArg[0];

                if (command == "Fire")
                {
                    int index = int.Parse(cmdArg[1]);
                    int damage = int.Parse(cmdArg[2]);
                    if (!PiratesAttackWarship (warship,  index, damage))
                    {
                        return;
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    int damage = int.Parse(cmdArg[3]);
                    if (!WarshipAttacksPirates(pirateShip, startIndex, endIndex, damage))
                    {
                        return;
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(cmdArg[1]);
                    int health = int.Parse(cmdArg[2]);
                    RepairPirateShip(pirateShip, index, health, maxHealth);
                }
                else // status 
                {
                    PirateShipStatus(pirateShip, maxHealth);
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }



         static void PirateShipStatus(int[] pirateShip, int maxHealth)
         {
             int counter = 0; 
            foreach (int section in pirateShip)
            {
                if (section < maxHealth * 0.2)
                {
                    counter++;
                }
            }

            Console.WriteLine($"{counter} sections need repair.");
        }

        static void RepairPirateShip(int[] pirateShip, int index, int health, int maxHealth)
        {
            if (CheckIndex(pirateShip, index))
            {
                pirateShip[index] += health;
                if (pirateShip[index] > maxHealth)
                {
                    pirateShip[index] = maxHealth;
                }
            }
        }

        static bool CheckIndex(int [] warship, int index)
         {
             if (index < 0 || index >= warship.Length)
             {
                return false;
             }
             return true;
         }

        static bool WarshipAttacksPirates(int[] pirateShip, int startIndex, int endIndex, int damage)
        {
            if (CheckIndex(pirateShip, startIndex) && (CheckIndex(pirateShip, endIndex)))
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    pirateShip[i] -= damage;
                    if (pirateShip[i] <= 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        return false;
                    }
                }
            }

            return true;
        }

        static bool PiratesAttackWarship(int [] warship, int index, int damage)
        {
            if (CheckIndex(warship, index))
            {
                warship[index] -= damage;
                if (warship[index] <= 0)
                {
                    Console.WriteLine($"You won! The enemy ship has sunken.");
                    return false;
                }
            }

            return true;
        }

    }
}