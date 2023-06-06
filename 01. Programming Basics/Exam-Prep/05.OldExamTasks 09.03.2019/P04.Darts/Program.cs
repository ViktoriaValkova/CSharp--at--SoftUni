using System;

namespace P04.Darts // 09/10.03.2019 // already done 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string sector = "";
            int points = 301;
            int succShotsCount = 0;
            int unsuccShotsCount = 0;
            // bool legWon = false;
            while ((sector = Console.ReadLine()) != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());

                switch (sector)
                {
                    case "Single":
                        break;
                    case "Double":
                        currentPoints *= 2;
                        break;
                    case "Triple":
                        currentPoints *= 3;
                        break;
                }
                if (currentPoints > points)
                {
                    unsuccShotsCount++;
                    continue;
                }
                else
                {
                    points -= currentPoints;
                    succShotsCount++;
                }
                if (points == 0)
                {
                    break;
                    //legWon |= true;
                }
            }
            if (sector == "Retire")
            {
                Console.WriteLine($"{name} retired after {unsuccShotsCount} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{name} won the leg with {succShotsCount} shots.");
            }

        }
    }
}
