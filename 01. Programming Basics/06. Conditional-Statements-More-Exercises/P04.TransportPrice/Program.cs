using System;
namespace newProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           int kilometeres = int.Parse(Console.ReadLine());
           string timeOfTravel = Console.ReadLine();
            double price = 0; 
            if (kilometeres >= 100) // only then with train 
            {
                price = 0.06 * kilometeres;
            }
            else if (kilometeres >= 20) // only then with bus 
            {
                price = 0.09 * kilometeres;
            }
            else // with taxi 
            {
                if (timeOfTravel == "day")
                {
                    price = 0.79 * kilometeres+0.7;
                }
                else // at night
                {
                    price = 0.9 * kilometeres + 0.7;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}