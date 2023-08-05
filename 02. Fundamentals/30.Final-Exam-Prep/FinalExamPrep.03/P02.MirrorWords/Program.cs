using System.Text.RegularExpressions;

namespace P02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<wordOne>[a-zA-Z]{3,})\1\1(?<wordTwo>[a-zA-Z]{3,})\1";
            string input = Console.ReadLine();

            List<string> mirrorWOrds = new List<string>();

            MatchCollection validPairs = Regex.Matches(input, pattern);
            foreach (Match match in validPairs)
            {
                string firstWord = match.Groups["wordOne"].Value;
                string secondWord = match.Groups["wordTwo"].Value;
                char[] reversedStringAsArr = secondWord.Reverse().ToArray();
                string reversedString = string.Join("", reversedStringAsArr);
                if (firstWord == reversedString)
                {
                    mirrorWOrds.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (validPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }
            if (mirrorWOrds.Count ==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWOrds));
            }
        }
    }
}