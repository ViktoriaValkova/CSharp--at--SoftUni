using System.Text.RegularExpressions;

namespace P02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            string pattern = @"([=/])(?<destination>[A-Z][a-zA-Z]{2,})\1";

            MatchCollection validDestinations = Regex.Matches(info, pattern);
            List<string> destinations = new List<string>();
            int points = 0;
            foreach (Match match in validDestinations)
            {
                destinations.Add(match.Groups["destination"].Value);
                points += match.Groups["destination"].Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}