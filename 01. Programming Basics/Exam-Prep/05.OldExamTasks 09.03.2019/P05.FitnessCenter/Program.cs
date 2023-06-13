using System;

namespace P05.FitnessCenter   // 09/10.03.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string activity = String.Empty;
            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int proteinShakeCount = 0;
            int proteinBarCount = 0;

            for (int i = 0; i < peopleCount; i++)
            {
                activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        backCount++;
                        break;
                    case "Chest": chestCount++; break;
                    case "Legs": legsCount++; break;
                    case "Abs": absCount++; break;
                    case "Protein shake": proteinShakeCount++; break;
                    case "Protein bar": proteinBarCount++; break;
                }
            }
            double percentageProtein = ((double)proteinBarCount + proteinShakeCount) / peopleCount * 100;
            double percentageTraining = ((double)backCount + legsCount + chestCount + absCount) / peopleCount * 100;
            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            Console.WriteLine($"{percentageTraining:f2}% - work out");
            Console.WriteLine($"{percentageProtein:f2}% - protein");
        }
    }
}
