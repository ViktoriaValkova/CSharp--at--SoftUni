using System;

namespace P01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLiveBy = int.Parse(Console.ReadLine());
            double moneySpent = 0.0;
            for (int i = 1800; i <= yearToLiveBy; i++)
            {

                if (i % 2 == 0)
                {
                    moneySpent += 12000;
                }
                else
                {
                    moneySpent += 12000 + 50 * (i - 1782);
                }
            }
            if (moneySpent <= inheritedMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney - moneySpent:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneySpent - inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
