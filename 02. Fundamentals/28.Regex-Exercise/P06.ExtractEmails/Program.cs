using System.Text.RegularExpressions;

namespace P06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"(?:\s+|^)(?!_)(?<email>[a-zA-z0-9]+[.\-_]*[a-zA-z0-9]+@([a-zA-Z0-9]+[-]?[a-zA-Z0-9]+)(?:\.\w+)+)";

            string text = Console.ReadLine();

            MatchCollection validEmails = Regex.Matches(text, pattern);

            foreach (Match match in validEmails)
            {
                Console.WriteLine(match.Groups["email"].Value);
            }
        }
    }
}