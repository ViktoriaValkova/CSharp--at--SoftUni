using System.Xml.XPath;

namespace P04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dwarf>> dwarvesByHat = new Dictionary<string, List<Dwarf>>();

            string input;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfInfo = input.Split(" <:> ").ToArray();
                string dwarfName = dwarfInfo[0];
                string hatColor = dwarfInfo[1];
                int physic = int.Parse(dwarfInfo[2]);
                Dwarf currDwarf = new Dwarf(dwarfName, hatColor, physic);
                if (!dwarvesByHat.ContainsKey(hatColor))
                {
                    dwarvesByHat[hatColor] = new List<Dwarf>();
                    dwarvesByHat[hatColor].Add(currDwarf);
                }
                if (!dwarvesByHat[hatColor].Exists(d => d.Name == dwarfName))
                {
                    dwarvesByHat[hatColor].Add(currDwarf);
                }

                Dwarf sameNameAndHatDwarf = dwarvesByHat[hatColor].FirstOrDefault(d => d.Name == dwarfName);
                if (sameNameAndHatDwarf != null)
                {
                    if (sameNameAndHatDwarf.Physics < physic)
                    {
                        sameNameAndHatDwarf.Physics= physic;
                    }
                }
            }
            // exctract a list of all dwarfes from each kvp in the dictionary 
            List<Dwarf> orderedDwarfes = dwarvesByHat.Values.SelectMany(d=>d).OrderByDescending(x=>x.Physics).ToList();
            Dictionary<string,int> countByColor = new Dictionary<string, int>();

            foreach (Dwarf dwarf in orderedDwarfes)
            {
                if (countByColor.ContainsKey(dwarf.HatColor))
                {
                    countByColor[dwarf.HatColor]++;
                }
                else
                {
                countByColor[dwarf.HatColor] = 1;
                }
            }
            orderedDwarfes = orderedDwarfes.OrderByDescending(d => d.Physics).ThenByDescending(d => countByColor[d.HatColor]).ToList();

            foreach (Dwarf dwarf in orderedDwarfes)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }

        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
}