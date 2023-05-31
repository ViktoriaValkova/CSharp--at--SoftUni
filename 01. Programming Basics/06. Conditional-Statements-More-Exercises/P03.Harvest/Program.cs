using System;
namespace P03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());    
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double litersProduced = x * 0.4 * y / 2.5; 
            if (litersProduced < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - litersProduced),0} liters wine needed.");
            }
            if (litersProduced >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersProduced),0} liters.");
                Console.WriteLine($"{Math.Ceiling(litersProduced - z)} liters left -> {Math.Ceiling((litersProduced - z) / workers)} liters per person.");
            }
        }
    }
}