using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string message = Console.ReadLine();
                int cypher = 0;
                foreach (char ch in message.ToLower())
                {
                    if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                    {
                        cypher++;
                    }
                }

                string decrypted = string.Empty;
                for (int j = 0; j < message.Length; j++)
                {
                    decrypted += (char)(message[j] - cypher);
                }
                // to be correct, the capturing group has to be without () 
                string regex = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)\2*!(?<type>[AD])!([^@\-!:>]*)\2*->(?<count>[0-9]+)";
                Match validMessage = Regex.Match(decrypted, regex);
                if (validMessage.Success)
                {
                    string planetName = validMessage.Groups["planet"].Value;
                    if (validMessage.Groups["type"].Value == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine($"-> {string.Join("\n-> ", attackedPlanets)}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine($"-> {string.Join("\n-> ", destroyedPlanets)}");
            }
        }
    }
}