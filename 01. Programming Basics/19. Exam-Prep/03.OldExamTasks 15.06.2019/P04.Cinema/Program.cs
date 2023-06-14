using System;

namespace P04.Cinema        // 15/16.06.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int roomCapacity = int.Parse(Console.ReadLine());
            string input = String.Empty;
            int allPeople = 0;
            int sumIncome = 0;
            while ((input = Console.ReadLine()) != "Movie time!")
            {
                int people = int.Parse(input);
                allPeople += people;
                if (allPeople > roomCapacity)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }
                int ticketsPrice = people * 5;
                if (people % 3 == 0)
                {
                    ticketsPrice -= 5;
                }
                sumIncome += ticketsPrice;
            }
            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {roomCapacity-allPeople} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {sumIncome} lv.");
        }
    }
}
