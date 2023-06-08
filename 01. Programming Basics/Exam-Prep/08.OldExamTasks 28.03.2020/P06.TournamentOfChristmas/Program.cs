using System;

namespace P06.TournamentOfChristmas    // 28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string sport = String.Empty;

            int winCount = 0;
            int losesCount = 0;
            double allMoney = 0;
            for (int day = 1; day <= days; day++)
            {
                int winCountDaily = 0;
                int losesCountDaily = 0;
                double money = 0;
                while ((sport = Console.ReadLine()) != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        money += 20;
                        winCountDaily++;
                    }
                    else   //lose
                    {
                        losesCountDaily++;
                    }
                }
                winCount += winCountDaily;
                losesCount += losesCountDaily;
                if (winCountDaily > losesCountDaily)
                {
                    money *= 1.1;
                }
                allMoney += money;
            }
            if (winCount > losesCount)
            {
                allMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allMoney:f2}");
            }
        }
    }
}
