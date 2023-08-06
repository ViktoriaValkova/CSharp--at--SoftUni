namespace P03.HeroesOfCodeAndLogicVII
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            GatherHeroes(heroes);

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArg = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string currHeroName = cmdArg[1];
                Hero currHero = heroes.Where(h => h.Name == currHeroName).FirstOrDefault();
                switch (cmdArg[0])
                {
                    case "CastSpell":
                        int manaNeeded = int.Parse(cmdArg[2]);
                        string spell = cmdArg[3];
                        CastSpell(currHero, manaNeeded, spell);
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(cmdArg[2]);
                        string attacker = cmdArg[3];
                        TakeDamage(currHero, attacker, damage,heroes);
                        break;
                    case "Recharge":
                        int amount = int.Parse(cmdArg[2]);
                        RechargeHero(currHero, amount);
                        break;
                    case "Heal":
                        amount = int.Parse(cmdArg[2]);
                        HealHero(currHero, amount);
                        break;
                }
            }

            foreach (Hero hero in heroes)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.Hit}");
                Console.WriteLine($"  MP: {hero.Mana}");
            }
        }

         static void HealHero(Hero currHero, int amount)
        {
            if (currHero.Hit + amount > 100)
            {
                amount = 100 - currHero.Hit;
                currHero.Hit = 100;
            }
            else
            {
                currHero.Hit += amount;
            }

            Console.WriteLine($"{currHero.Name} healed for {amount} HP!");
        }

        static void RechargeHero(Hero currHero, int amount)
        {
            if (currHero.Mana + amount > 200)
            {
                amount = 200-currHero.Mana;
                currHero.Mana = 200;
            }
            else
            {
                currHero.Mana += amount;
            }

            Console.WriteLine($"{currHero.Name} recharged for {amount} MP!");
        }

        static void TakeDamage(Hero currHero, string attacker, int damage, List<Hero>heroes)
        {
            currHero.Hit -= damage;
            if (currHero.Hit <= 0)
            {
                heroes.Remove(currHero);
                Console.WriteLine($"{currHero.Name} has been killed by {attacker}!");
            }
            else
            {
                Console.WriteLine($"{currHero.Name} was hit for {damage} HP by {attacker} and now has {currHero.Hit} HP left!");
            }
        }

        static void CastSpell(Hero currHero, int manaNeeded, string spell)
        {
           if (currHero.Mana >= manaNeeded)
            {
                currHero.Mana-=manaNeeded;
                Console.WriteLine($"{currHero.Name} has successfully cast {spell} and now has {currHero.Mana} MP!");
            }
           else
            {
                Console.WriteLine($"{currHero.Name} does not have enough MP to cast {spell}!");
            }
        }

         static void GatherHeroes(List<Hero> heroes)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string name = heroInfo[0];
                int hit = int.Parse(heroInfo[1]);
                int mana = int.Parse(heroInfo[2]);

                heroes.Add(new Hero(name, mana, hit));
            }
        }
    }
     class Hero
    {
        public Hero(string name, int mana, int hit)
        {
            Name = name;
            Mana = mana;
            Hit = hit;
        }

        public string Name { get; set; }
        public int Mana { get; set; }
        public int Hit { get; set; }
    }
}