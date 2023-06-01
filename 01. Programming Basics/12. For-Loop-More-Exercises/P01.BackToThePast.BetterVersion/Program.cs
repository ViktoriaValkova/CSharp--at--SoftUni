using System;

namespace P01.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLiveBy = int.Parse(Console.ReadLine());
            double moneySpent = 0;
            int age = 18;
            int n = yearToLiveBy - 1800;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpent += 12000;
                    age++;
                }
                else
                {
                    moneySpent += 12000 + 50 * age;
                    age++;
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
