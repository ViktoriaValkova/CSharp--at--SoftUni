using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"%(?<name>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<count>\d+)\|.*?(?<price>\d+(.\d+)?).*?\$";
            string input = string.Empty;
            double totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match isMatch = Regex.Match(input, pattern);

                if (isMatch.Success)
                {
                   string name = isMatch.Groups["name"].Value;
                   string product = isMatch.Groups["product"].Value;
                   double finalPrice = double.Parse(isMatch.Groups["price"].Value) * double.Parse(isMatch.Groups["count"].Value);
                   totalIncome += finalPrice;
                    Console.WriteLine($"{name}: {product} - {finalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}