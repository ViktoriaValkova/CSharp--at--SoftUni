using System;
namespace P07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numberStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = "";
            double pricePerNight = 0;
            if (groupType == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 9.6;
                        sport = "Gymnastics";
                        break;
                    case "Spring":
                        pricePerNight = 7.2;
                        sport = "Athletics";
                        break;
                    case "Summer":
                        pricePerNight = 15.0;
                        sport = "Volleyball";
                        break;

                }
            }
            else if (groupType == "boys")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 9.6;
                        sport = "Judo";
                        break;
                    case "Spring":
                        pricePerNight = 7.2;
                        sport = "Tennis";
                        break;
                    case "Summer":
                        pricePerNight = 15.0;
                        sport = "Football";
                        break;
                }
            }
            else if (groupType == "mixed")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 10.0;
                        sport = "Ski";
                        break;
                    case "Spring":
                        pricePerNight = 9.5;
                        sport = "Cycling";
                        break;
                    case "Summer":
                        pricePerNight = 20.0;
                        sport = "Swimming";
                        break;
                }
            }
            double price = nights * pricePerNight * numberStudents;
            if (numberStudents >= 10 && numberStudents < 20)
            {
                price *= 0.95;
            }
            else if (numberStudents >= 20 && numberStudents < 50)
            {
                price *= 0.85;
            }
            else if (numberStudents >= 50)
            {
                price *= 0.5;

            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}