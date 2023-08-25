using System.Text.RegularExpressions;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[a-zA-Z]+ [a-zA-Z]+)#";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match validMatch = Regex.Match(input, pattern);

                if (validMatch.Success)
                {
                    string name = validMatch.Groups["name"].Value;
                    string title = validMatch.Groups["title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                    continue;
                }

                Console.WriteLine("Access denied!");
            }
               
        }
    }
}