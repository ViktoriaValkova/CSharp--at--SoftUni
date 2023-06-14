using System;

namespace P05.EasterEggs // Exam 20/21.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            string colour = "";
            int redCount = 0;
            int greenCount = 0;
            int blueCount = 0;
            int orangeCount = 0;
            // int maxCount = 0;

            while (eggsCount > 0)  // can be done with a for loop, and without substr eggs
            {
                colour = Console.ReadLine(); // with if in every case, comparing with maxCount and adding egg colour 
                switch (colour)               // ~ 1h 10 min in video
                {
                    case "red":
                        redCount++; eggsCount--;
                        break;
                    case "orange":
                        orangeCount++; eggsCount--;
                        break;
                    case "blue":
                        blueCount++; eggsCount--;
                        break;
                    case "green":
                        greenCount++; eggsCount--;
                        break;

                }
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            if (redCount > orangeCount && redCount > greenCount && redCount > blueCount)
            {
                Console.WriteLine($"Max eggs: {redCount} -> red");
            }
            if (greenCount > orangeCount && greenCount > blueCount && greenCount > redCount)
            {
                Console.WriteLine($"Max eggs: {greenCount} -> green");
            }
            if (blueCount > orangeCount && blueCount > greenCount && blueCount > redCount)
            {
                Console.WriteLine($"Max eggs: {blueCount} -> blue");
            }
            if (orangeCount > blueCount && orangeCount > greenCount && orangeCount > redCount)
            {
                Console.WriteLine($"Max eggs: {orangeCount} -> orange");
            }
        }
    }
}
