using System.Text.RegularExpressions;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nonNumPattern = @"[^0-9]";
            string nonLetters = @"[^a-zA-Z]";
            List<Racer> racers = new List<Racer>();
            string[] names = Console.ReadLine().Split(", ");
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string currentName = Regex.Replace(input, nonLetters, "");

                int distance = 0;
                if (names.Contains(currentName))
                {
                    char[] numbers = Regex.Replace(input, nonNumPattern, "").ToArray();
                    foreach (char num in numbers)
                    {
                        distance += (int)char.GetNumericValue(num);
                    }

                    Racer existingRacer = racers.FirstOrDefault(r => r.Name == currentName);
                    if (existingRacer == null)
                    {
                        racers.Add(new Racer(currentName, distance));
                    }
                    else
                    {
                        existingRacer.Distance += distance;
                    }
                }
            }

            var bestRacers = racers.OrderByDescending(r => r.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {bestRacers[0].Name}");
            Console.WriteLine($"2nd place: {bestRacers[1].Name}");
            Console.WriteLine($"3rd place: {bestRacers[2].Name}");

        }
    }
    class Racer
    {
        public Racer(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }
        public string Name { get; set; }
        public int Distance { get; set; }
    }
}