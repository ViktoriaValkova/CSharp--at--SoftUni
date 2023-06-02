using System;

namespace P05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double inCoins = Math.Round(change * 100.0);// can be done with decimal instead of double
            int coins = 0;
            // problem can be done without turning input into coins
            // problem can also be done with switch/case  
            while (inCoins > 0)
            {
                if (inCoins >= 200)
                {

                    inCoins -= 200;
                }
                else if (inCoins >= 100)
                {

                    inCoins -= 100;
                }   //else if, so it can return 2 2 leva coins, instead of 1 2 and 2 one
                else if (inCoins >= 50)
                {
                    inCoins -= 50;
                }
                else if (inCoins >= 20)
                {
                    inCoins -= 20;
                }
                else if (inCoins >= 10)
                {
                    inCoins -= 10;
                }
                else if (inCoins >= 5)
                {
                    inCoins -= 5;
                }
                else if (inCoins >= 2)
                {
                    inCoins -= 2;
                }
                else
                {
                    inCoins -= 1;
                }
                coins++;
            }
            Console.WriteLine(coins);
        }
    }
}
