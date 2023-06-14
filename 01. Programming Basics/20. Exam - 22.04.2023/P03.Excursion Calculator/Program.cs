using System;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int peopleCnt = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0; 
            if (peopleCnt <= 5)
            {
                switch (season)
                {
                    case "spring": price = peopleCnt * 50.0; break;
                    case "summer": price = peopleCnt* 48.50*0.85; break;
                    case "autumn": price = peopleCnt * 60.0; break;
                    case "winter": price = peopleCnt * 86.0*1.08; break;
                }
            }
            else // above 5 
            {
                switch (season)
                {
                    case "spring": price = peopleCnt * 48.0 ; break;
                    case "summer": price = peopleCnt *45*0.85 ; break;
                    case "autumn": price = peopleCnt * 49.5; break;
                    case "winter": price = peopleCnt * 85*1.08 ; break;
                }
            }
            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
