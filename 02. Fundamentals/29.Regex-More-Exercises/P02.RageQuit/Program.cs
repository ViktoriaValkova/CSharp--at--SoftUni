using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<string>[^0-9]+)(?<count>[0-9]+)";

            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
               string str = match.Groups["string"].Value;
               int count = int.Parse(match.Groups["count"].Value);

               for (int i = 0; i < count; i++)
               {
                   result.Append(str.ToUpper());
               }
               
            }
            List<char> uniqueSymboles = result.ToString().Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {uniqueSymboles.Count}");
            Console.WriteLine(result);
        }
    }
}