using System;   
namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartmentRent = 0.0;
            double studioRent = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studioRent = 50;
                    apartmentRent = 65;
                    if (nights > 7 && nights <= 14)
                    { studioRent *= 0.95; }
                    if (nights > 14)
                    { studioRent *= 0.70; }                   
                    break;
                case "June":
                case "September":
                    studioRent = 75.2;
                    apartmentRent = 68.7;
                    if (nights > 14)
                    { studioRent *= 0.80; }
                    break;
                case "July":
                case "August":
                    studioRent = 76.0;
                    apartmentRent = 77.0;
                    break;
            }
           if (nights > 14) 
            {
                apartmentRent *= 0.90;
            }
            Console.WriteLine($"Apartment: {nights*apartmentRent:f2} lv.");
            Console.WriteLine($"Studio: {nights*studioRent:f2} lv.");
        }
    }
}