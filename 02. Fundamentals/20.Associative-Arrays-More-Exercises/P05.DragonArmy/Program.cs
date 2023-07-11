
namespace P05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDragons = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> dragonsDictionary = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < countDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split();
                string type = dragonInfo[0];
                Dragon currentDragon = new Dragon(dragonInfo);
                if (!dragonsDictionary.ContainsKey(type))
                {
                    dragonsDictionary[type] = new List<Dragon>();
                    dragonsDictionary[type].Add(currentDragon);
                }
                else
                {
                    Dragon sameDragon = dragonsDictionary[type].Where(d => d.Name == dragonInfo[1]).FirstOrDefault();
                    if (sameDragon == null)
                    {
                        dragonsDictionary[type].Add(currentDragon);
                    }
                    else
                    {
                        dragonsDictionary[type].Remove(sameDragon);
                        dragonsDictionary[type].Add(currentDragon);
                    }
                }
            }

            foreach (var kvp in dragonsDictionary)
            {
                double averageArmor = kvp.Value.Average(d => d.Armor);   // this here!
                double averageHealth = kvp.Value.Average(d => d.Health);
                double averageDamage = kvp.Value.Average(d => d.Damage);

                Console.WriteLine($"{kvp.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (Dragon dragon in kvp.Value.OrderBy(d=>d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

    }
    class Dragon
    {
        public Dragon(string[] values)
        {
            Name = values[1];
            if (!int.TryParse(values[2], out int damage))
            {
                damage = Damage;
            }
            if (!int.TryParse(values[3], out int health))
            {
                health = Health;
            }
            if (!int.TryParse(values[4], out int armor))
            {
                armor = Armor;
            }
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public int Damage { get; set; } = 45;
        public int Health { get; set; } = 250;

        public int Armor { get; set; } = 10;

        public string Name { get; set; }
    }
}