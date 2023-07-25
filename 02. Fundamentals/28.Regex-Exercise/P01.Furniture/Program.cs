using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>{2}(?<furniture>[A-Za-z]+)<{2}(?<price>\d+(.\d+)?)!(?<cnt>\d+)\b";
            string input = string.Empty;
            List<string> validFurnitures = new List<string>();
            double totalSum = 0;
                Regex regex = new Regex(pattern);
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    validFurnitures.Add(match.Groups["furniture"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["cnt"].Value);
                    totalSum += (price * quantity);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string data in validFurnitures)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}