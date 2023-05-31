using System; 
namespace _02._Summer_Clothes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothes="a";
            string shoes="b"; 
            if (degrees>=10 && degrees<=18)
            { 
                switch (timeOfDay)
                {
                    case "Morning":
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                         clothes = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Evening":
                         clothes = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            if (degrees >= 25)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
                    Console.WriteLine($"It's {degrees} degrees, get your {clothes} and {shoes}.");
        }
    }
}