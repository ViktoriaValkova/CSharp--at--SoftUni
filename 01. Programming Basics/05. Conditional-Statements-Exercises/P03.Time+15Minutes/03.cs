using System;
namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int allInMinutes = hour * 60 + minutes;
            int addedMinutes = allInMinutes + 15;
            int hourNew = addedMinutes / 60;
            int minutesNew = addedMinutes % 60;
            if (hourNew > 23)
            {
                hourNew -= 24;
            }
            if (minutesNew < 10)
            {
                Console.WriteLine($"{hourNew}:0{minutesNew}");
            }
            else 
            {
                Console.WriteLine($"{hourNew}:{minutesNew}"); 
            }
        }
    }
}