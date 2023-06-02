using System;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumSteps = 0;
            string input = "";
            while (sumSteps < 10_000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {

                    sumSteps += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    sumSteps += int.Parse(input);
                }
            }
            if (sumSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
            }
        }
    }
}
