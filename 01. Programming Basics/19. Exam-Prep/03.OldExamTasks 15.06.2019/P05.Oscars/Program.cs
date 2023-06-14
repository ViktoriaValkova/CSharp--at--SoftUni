using System;

namespace P05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judgeCount = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < judgeCount; i++)
            {
                string judgeName = Console.ReadLine();
                double pointsAwarded = double.Parse(Console.ReadLine());
                points += (pointsAwarded * judgeName.Length / 2);
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5-points:f1} more!");
            }

        }
    }
}
