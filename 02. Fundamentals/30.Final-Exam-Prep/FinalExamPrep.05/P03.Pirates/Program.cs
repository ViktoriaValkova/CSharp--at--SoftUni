namespace P03.Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Town> towns = new List<Town>();
            FillTownsList(towns);

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split("=>");
                Town foundTown = towns.Where(t => t.Name == cmdArg[1]).FirstOrDefault();
                switch (cmdArg[0])
                {
                    case "Plunder":
                        int people = int.Parse(cmdArg[2]);
                        int gold = int.Parse(cmdArg[3]);
                        PlunderTheTown(towns, foundTown, people, gold);
                        break;
                    case "Prosper":
                        gold= int.Parse(cmdArg[2]);
                        TownProspers (foundTown,gold);
                        break;
                }
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (Town town in towns)
                {
                    Console.WriteLine(town);
                }

                return;
            }

            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }

         static void TownProspers(Town foundTown, int gold)
        {
            if (gold > 0)
            {
                foundTown.Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {foundTown.Name} now has {foundTown.Gold} gold.");
                return;
            }

            Console.WriteLine("Gold added cannot be a negative number!");
        }

        static void PlunderTheTown(List<Town> towns, Town foundTown, int people, int gold)
        {
            foundTown.Gold -= gold;
            foundTown.Population -= people;
            Console.WriteLine($"{foundTown.Name} plundered! {gold} gold stolen, {people} citizens killed.");

            if (foundTown.Gold == 0 || foundTown.Population == 0)
            {
                Console.WriteLine($"{foundTown.Name} has been wiped off the map!");
                towns.Remove(foundTown);
            }
        }

        static void FillTownsList(List<Town> towns)
        {
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cmdArg = input.Split("||");

                string town = cmdArg[0];
                long population = long.Parse(cmdArg[1]);
                long gold = long.Parse(cmdArg[2]);

                Town currentTown = towns.Where(t => t.Name == town).FirstOrDefault();
                if (currentTown == null)
                {
                    towns.Add(new Town(town, population, gold));
                }
                else
                {
                    currentTown.Gold += gold;
                    currentTown.Population += population;
                }
            }
        }
    }
    class Town
    {
        public Town(string name, long population, long gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public long Population { get; set; }
        public long Gold { get; set; }

        public override string ToString()
        {
            return $"{this.Name} -> Population: {this.Population} citizens, Gold: {this.Gold} kg";
        }
    }
}