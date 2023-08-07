using System.Numerics;
using System.Text.RegularExpressions;

namespace P02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();

            BigInteger coolTreshhold = 1;
            coolTreshhold = FindCoolTreshhold(input, coolTreshhold);

            MatchCollection validEmojis = Regex.Matches(input, pattern);

            Console.WriteLine($"Cool threshold: {coolTreshhold}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");

            FindCoolEmojis(validEmojis, coolTreshhold);

            
        }

        private static void FindCoolEmojis(MatchCollection validEmojis, BigInteger coolTreshhold)
        {
            foreach (Match emoji in validEmojis)
            {
                int currentCoolSum = 0;
                string currentWord = emoji.Groups["emoji"].Value;
                foreach (char ch in currentWord)
                {
                    if (char.IsLetter(ch))
                    {
                        currentCoolSum += ch;
                    }
                }

                if (currentCoolSum > coolTreshhold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }

        private static BigInteger FindCoolTreshhold(string input, BigInteger coolTreshhold)
        {
            string numPattern = @"\d";
            MatchCollection numbers = Regex.Matches(input, numPattern);
            foreach (Match number in numbers)
            {
                coolTreshhold *= int.Parse(number.ToString());
            }

            return coolTreshhold;
        }
    }
}