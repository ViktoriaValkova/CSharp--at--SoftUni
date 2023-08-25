using System; 
using System.Linq; 
using System.Collections.Generic;

namespace P01.SantasNewList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> presentsByCount = new Dictionary<string, int>(); //present type, cnt presents
            Dictionary<string, int> presentsByChild = new Dictionary<string, int>(); // name, cnt presents

            string info = string.Empty;

            while ((info = Console.ReadLine()) != "END")
            {
                string[] presentInfo = info.Split("->");
                if (presentInfo[0] == "Remove")
                {
                    presentsByChild.Remove(presentInfo[1]);
                    continue;
                }
                string name = presentInfo[0];
                string present = presentInfo[1];
                int count = int.Parse(presentInfo[2]);
                if (!presentsByCount.ContainsKey(present))
                {
                    presentsByCount.Add(present, 0);
                }

                presentsByCount[present] += count;

                if (!presentsByChild.ContainsKey(name))
                {
                    presentsByChild.Add(name, 0);
                }

                presentsByChild[name] += count;
            }

            Console.WriteLine("Children:");
            foreach (var kvp in presentsByChild.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Presents:");

            foreach (var kvp in presentsByCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}