using System;

namespace P04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newTime = hours * 60 + minutes + 30;
            int newHours = newTime / 60;
            int newMinutes = newTime % 60;
            if (newHours > 23)
            {
                newHours = 0;
            }
            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}
