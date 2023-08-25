using System;
using System.Linq;
using System.Collections.Generic;
namespace P03.SoftUniKaraoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = string.Empty;
            Dictionary<string, List<string>> awardsBySinger = new Dictionary<string, List<string>>(); // participant, awards
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] performance = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string singer = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (!participants.Contains(singer) || !songs.Contains(song))
                {
                    continue;
                }
                if (!awardsBySinger.ContainsKey(singer))
                {
                    awardsBySinger[singer] = new List<string>();
                }
                if (!awardsBySinger[singer].Contains(award))
                {
                    awardsBySinger[singer].Add(award);
                }
            }

            if (awardsBySinger.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            awardsBySinger = awardsBySinger.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in awardsBySinger)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                foreach (string award in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}