using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names,regex);
            Console.WriteLine(string.Join(" ", matchedNames));
            
        }
    }
}