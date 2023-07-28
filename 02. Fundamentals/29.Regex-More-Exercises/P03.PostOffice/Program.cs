using System.Text.RegularExpressions;

namespace P03.PostOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternCapAZ = @"([#$%*&])(?<capL>[A-Z]+)\1";
            string patternNums = @"(?<ascii>\d+):(?<length>\d{2})+";

            string[] input = Console.ReadLine().Split('|').ToArray();

            Match letters = Regex.Match(input[0], patternCapAZ);

            char[] lettersInArr = letters.Groups[2].Value.ToCharArray();
            MatchCollection nums = Regex.Matches(input[1], patternNums);

            string[] wordsInArr = input[2].Split(" ").ToArray();
            Dictionary<char, int> lengthForCHar = new Dictionary<char, int>();
            foreach (Match num in nums)
            {
                int asciiNum = int.Parse(num.Groups["ascii"].Value);
                char ch = (char)asciiNum;
                int length = int.Parse(num.Groups["length"].Value);
                if (!lengthForCHar.ContainsKey(ch))
                {
                lengthForCHar.Add(ch, length);
                }
            }

            foreach (char ch in lettersInArr)
            {
                var foundPair = lengthForCHar.Where(p => p.Key == ch).First();
                foreach (string word in wordsInArr)
                {
                    if(word[0] == ch && word.Length == foundPair.Value+ 1)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}