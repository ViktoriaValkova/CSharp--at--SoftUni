using System;

namespace P04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallHeigt = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int percentegeNotPainted  = int.Parse(Console.ReadLine());
            double surfaceToBePainted = wallHeigt * wallWidth * 4;
            surfaceToBePainted -=surfaceToBePainted * (percentegeNotPainted / 100.0);
            surfaceToBePainted = Math.Ceiling(surfaceToBePainted);
            string command = string.Empty;
            int surfacePainted = 0;
            while ((command = Console.ReadLine()) != "Tired!")
            {
                int paintInLiters = int.Parse(command);
                surfacePainted += paintInLiters;
                if (surfacePainted > surfaceToBePainted )
                {
                    Console.WriteLine($"All walls are painted and you have {surfacePainted-surfaceToBePainted} l paint left!");
                    break;
                }
                if (surfaceToBePainted == surfacePainted)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
            }
            if (command == "Tired!")
            {
                Console.WriteLine($"{surfaceToBePainted-surfacePainted} quadratic m left.");
            }

        }
    }
}
