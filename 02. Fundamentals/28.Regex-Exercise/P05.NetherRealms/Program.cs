using System.Text.RegularExpressions;

namespace P05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char []{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            string patternHealth = @"([-.+*\/]*)([0-9]*)";
            string patternBaseDamage = @"[+-]?\d+[.]?\d*"; // correct double nums,to get as a whole 
            List<Demon> demons = new List<Demon>();
            foreach (string str in input)
            {
                int sumHealth = 0;
                double baseDamageSum = 0;
                string health = Regex.Replace(str, patternHealth, "");
                foreach (char ch in health)
                {
                    sumHealth += ch;
                }

                MatchCollection baseDamage = Regex.Matches(str, patternBaseDamage);
                foreach (Match num in baseDamage)
                {
                    baseDamageSum += double.Parse(num.Value);
                }

                foreach (char ch in str)
                {
                    if (ch == '/')
                    {
                        baseDamageSum /= 2;
                    }
                    else if (ch == '*')
                    {
                        baseDamageSum *= 2;
                    }
                }
                demons.Add(new Demon(str, sumHealth, baseDamageSum));
            }

            demons = demons.OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join("\n",demons));
        }
    }
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }


        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Health} health, {this.Damage:f2} damage";
        }
    }
}