using System.Text.RegularExpressions;

namespace P01.WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?<char>([$#@\^])\2{5,9}))";  // using \2 for the group guarantees that the same symbol is used

            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                
                string firstHalf = ticket.Substring(0, 10);
                string secondHalf = ticket.Substring(10, 10);
                Match firstMatch = Regex.Match(firstHalf, pattern);
                Match secondMatch = Regex.Match(secondHalf, pattern);

                if (firstMatch.Success && secondMatch.Success)
                {
                        int winLength =Math.Min(firstMatch.Length,secondMatch.Length);
                        char winSymbol = firstMatch.Groups["char"].Value[0];
                    if (winLength > 5 && winLength < 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {winLength}{winSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {winLength}{winSymbol} Jackpot!");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                
            }
        }
    }
}