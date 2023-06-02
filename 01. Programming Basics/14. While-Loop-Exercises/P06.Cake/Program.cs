using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int slices = width * height;
            string input = "";
            bool isCakeGone = false;
            while ((input = Console.ReadLine()) !="STOP")
            {
                    slices -= int.Parse (input);
                if (slices <= 0)
                {
                    isCakeGone = true;
                    break;
                }
            }
            if (isCakeGone)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(slices)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{slices} pieces are left." );
            }

        }
    }
}
