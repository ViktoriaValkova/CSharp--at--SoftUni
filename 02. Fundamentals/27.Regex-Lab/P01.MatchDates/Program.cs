using System;
using System.Text.RegularExpressions;

namespace P01.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-./])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string dates = Console.ReadLine();
            MatchCollection correctDates = Regex.Matches(dates, regex);
            foreach (Match date in correctDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}