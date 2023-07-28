using System.Text.RegularExpressions;

namespace P04.Santa_sSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input= string.Empty;
            string pattern = @".*@(?<name>[a-zA-Z]+)[^@\-!:>]*!(?<beh>[GN])!.*";
            while ((input = Console.ReadLine()) != "end")
            {
                input = string.Concat(input.Select(x => (char)(x - key)).ToArray());

                Match validMatch = Regex.Match(input, pattern);
                if (validMatch.Success)
                {
                    string name = validMatch.Groups["name"].Value;
                    string goodOrBad = validMatch.Groups["beh"].Value; 
                    if (goodOrBad == "G")
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}