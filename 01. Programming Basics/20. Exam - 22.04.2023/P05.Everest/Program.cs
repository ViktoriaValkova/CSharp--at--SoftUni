using System;

namespace P05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int dayCounter = 1;
            int meteresClimbed = 5364;
            while ((command = Console.ReadLine()) != "END")
            {

                if (command == "Yes")
                {
                    dayCounter++;
                }
                if (dayCounter > 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(meteresClimbed);
                    break;
                }
                meteresClimbed += int.Parse(Console.ReadLine());


                if (meteresClimbed >= 8848)
                {
                    Console.WriteLine($"Goal reached for {dayCounter} days!");
                    break;
                }
            }
            if (command == "END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(meteresClimbed);
            }
        }
    }
}
