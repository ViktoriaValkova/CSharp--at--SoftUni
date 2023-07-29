using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#||])(?<name>[a-zA-Z ]+)\1(?<date>([0-9]\/*){6})\1(?<kcal>\d+)\1"; 
            string info = Console.ReadLine();
            MatchCollection validFoods = Regex.Matches(info, pattern);
            int kcalSum = 0;

            foreach (Match match in validFoods)
            {
                int kcal = int.Parse(match.Groups["kcal"].Value);
                kcalSum += kcal;
            }
            int days = kcalSum / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in validFoods)
            {
                string item = match.Groups["name"].Value;
                string bestBefore = match.Groups["date"].Value;
                int kcal = int.Parse(match.Groups["kcal"].Value);
                Console.WriteLine($"Item: {item}, Best before: {bestBefore}, Nutrition: {kcal}");

            }
        }
    }
}