using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|\s)\+359([ -])(?:\2?2\2?\d{3}\2?\d{4})\b";
            string numbers = Console.ReadLine();
            MatchCollection matchedNumbers = Regex.Matches(numbers, regex);
            Console.WriteLine(string.Join(",", matchedNumbers));
        }
    }
}