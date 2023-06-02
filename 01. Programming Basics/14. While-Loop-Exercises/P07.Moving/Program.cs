using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cubicMeters = width * depth * height;
            string input = "";
            bool noSpaceLeft = false;
            while ((input = Console.ReadLine()) != "Done")
            {
                cubicMeters -= int.Parse(input);
                if (cubicMeters <= 0)
                {
                    noSpaceLeft = true;
                    break;
                }
            }
            if (noSpaceLeft)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeters)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{cubicMeters} Cubic meters left.");
            }
        }
    }
}
