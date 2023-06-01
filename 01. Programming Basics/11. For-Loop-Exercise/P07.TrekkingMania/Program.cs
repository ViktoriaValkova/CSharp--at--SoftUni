using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGroups = int .Parse(Console.ReadLine());
            int musala = 0; 
            int monblanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            int numberPeople = 0;
            for (int i = 1; i <= numberGroups; i++)
            {
                numberPeople = int.Parse(Console.ReadLine());
                if (numberPeople <= 5)
                {
                    musala+=numberPeople;
                }
                else if (numberPeople >5 && numberPeople<= 12)
                {
                    monblanc+=numberPeople;
                }
                else if (numberPeople >12 && numberPeople <= 25)
                {
                    kilimanjaro += numberPeople;
                }
                else if (numberPeople > 25 && numberPeople <= 40)
                {
                    k2 += numberPeople;
                }
                else if (numberPeople >40)
                    { 
                    everest += numberPeople;
                }
            }
            int sumPeople = musala + monblanc + kilimanjaro+k2+everest;    
            Console.WriteLine($"{(double)musala / (double) sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)monblanc / (double)sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)kilimanjaro / (double)sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)k2 / (double)sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)everest / (double)sumPeople * 100:f2}%");
        }// like Histogram 
    }
}
