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
                switch (action)
                {
                    case "spend": daysSpending++;
                        moneyPresent -= money;
                        break;
                    case "save": moneyPresent += money;
                        daysSpending = 0; break;
                }
                if (daysSpending >= 5)
                {
                    cantSave = true;
                   
                    break;
                }  
                if (moneyPresent < 0)
                {
                    moneyPresent = 0;
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
