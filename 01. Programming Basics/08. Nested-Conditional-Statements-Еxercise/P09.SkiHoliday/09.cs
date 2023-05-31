using System;   
namespace _09._Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine())-1;   
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double roomPrice = 0.0;
            if (nights < 10)
            {
                switch (roomType) 
                {
                    case "room for one person":
                        roomPrice = 18;
                        break;
                    case "apartment":
                        roomPrice = 25 * 0.7;
                        break;
                    case "president apartment":
                        roomPrice = 35 * 0.9;
                        break;
                }
            }
            else if (nights >= 10 && nights <= 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        roomPrice = 18;
                        break;
                    case "apartment":
                        roomPrice = 25 * 0.65;
                        break;
                    case "president apartment":
                        roomPrice = 35 * 0.85;
                        break;
                }
            }
            else if (nights > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        roomPrice = 18;
                        break;
                    case "apartment":
                        roomPrice = 25 * 0.5;
                        break;
                    case "president apartment":
                        roomPrice = 35 * 0.8;
                        break;
                }
            }
            if (rating == "positive")
            {
                roomPrice *= 1.25;
            }
            else roomPrice *= 0.9;
            Console.WriteLine($"{roomPrice * nights:f2}");
        }
    }
}