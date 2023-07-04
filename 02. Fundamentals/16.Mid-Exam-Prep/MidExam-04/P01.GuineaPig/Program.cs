using System.ComponentModel.DataAnnotations;

namespace P01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodQnt = decimal.Parse(Console.ReadLine());
            decimal hayQnt = decimal.Parse(Console.ReadLine());
            decimal coverQnt = decimal.Parse(Console.ReadLine());
            decimal guineaWeight = decimal.Parse(Console.ReadLine());
            bool qntIsEnough = true;
            int daysCnt = 0;

            while (daysCnt<30)
            {
                daysCnt++;
                foodQnt -= 0.3m;
                if (daysCnt % 2 == 0)
                {
                    hayQnt -= foodQnt * 0.05m;
                }
                if (daysCnt % 3 == 0)
                {
                    coverQnt -= guineaWeight / 3;
                }
                if (foodQnt <= 0 || hayQnt <= 0 || coverQnt <= 0)
                {
                    qntIsEnough = false;
                    break;
                }

            }
            if (qntIsEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQnt:f2}, Hay: {hayQnt:f2}, Cover: {coverQnt:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}