using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyPresent = double.Parse(Console.ReadLine());
            int daysSpending = 0;
            int days = 0;
            bool cantSave = false;

            while (moneyPresent < moneyNeeded)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (action == "spend")
                {
                    daysSpending++;
                    moneyPresent -= money;
                    if (moneyPresent < 0)
                    {
                        moneyPresent = 0;
                    }
                    if (daysSpending >= 5)
                    {
                        cantSave = true;
                        break;
                    }
                }
                else //save
                {
                    daysSpending = 0;
                    moneyPresent += money;
                }
            }
            if (cantSave)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
