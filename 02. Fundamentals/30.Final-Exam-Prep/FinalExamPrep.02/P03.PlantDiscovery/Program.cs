namespace P03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> plantsByRarity = new Dictionary<string, double>();  // name, rarety
            Dictionary<string, List<double>> plantsByRating = new Dictionary<string, List<double>>(); // name, list of ratings 
            for (int i = 0; i < count; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->").ToArray();
                string plantName = plantInfo[0];
                double rarity = double.Parse(plantInfo[1]);
                if (!plantsByRarity.ContainsKey(plantName))
                {
                    plantsByRarity[plantName] = 0;
                }

                RemoveRarity(plantsByRarity, plantName);
                plantsByRarity[plantName] = rarity;
                plantsByRating[plantName] = new List<double>();
            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArg = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = cmdArg[1];
                if (!plantsByRating.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (cmdArg[0])
                {
                    case "Rate:":
                        plantsByRating[plant].Add(double.Parse(cmdArg[2]));
                        break;
                    case "Update:":
                        RemoveRarity(plantsByRarity, plant);
                        plantsByRarity[plant] = double.Parse(cmdArg[2]);
                        break;
                    case "Reset:":
                        plantsByRating[plant].Clear();
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsByRating)
            {
                string plantName = plant.Key;
                double rarity = plantsByRarity[plantName];
                Console.Write($"- {plantName}; Rarity: {rarity}; Rating: ");
                if (plant.Value.Count == 0)
                {
                    Console.WriteLine("0.00");
                }
                else
                {
                    Console.WriteLine($"{plant.Value.Average():f2}");
                }
            }
        }

        private static void RemoveRarity(Dictionary<string, double> plantsByRating, string plantName)
        {
            plantsByRating[plantName] = 0;
        }
    }
}