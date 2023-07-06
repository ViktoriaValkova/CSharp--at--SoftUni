using System;
namespace P01.Santa_sCookies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            const int SingleCookie = 25;
            const int Cup = 140;
            const int SmallSpoon = 10;
            const int BigSpoon = 20;
            const int CookiesPerBox = 5;
            int boxesCounter = 0;

            for (int i = 0; i < batches; i++)
            {
                int flourCups = int.Parse(Console.ReadLine()) / Cup;
                int sugarSpoons = int.Parse(Console.ReadLine()) / BigSpoon;
                int cocoaSpoons = int.Parse(Console.ReadLine()) / SmallSpoon;


                int totalCookiesPerBatch = (Cup + SmallSpoon + BigSpoon)
                    * Math.Min(Math.Min(flourCups, sugarSpoons), cocoaSpoons) / SingleCookie;

                int boxes = totalCookiesPerBatch / CookiesPerBox;
                if (boxes <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    boxesCounter += boxes;
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                }
            }

            Console.WriteLine($"Total boxes: {boxesCounter}");
        }
    }
}