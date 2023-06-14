using System;

namespace P03.Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joineryCnt = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string deliveryWay = Console.ReadLine();
            double singlePrice = 0;
            if (joineryCnt <= 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                if (joineryType == "90X130")
                {
                    singlePrice = 110;
                    if (joineryCnt > 60)
                    {
                        singlePrice *= 0.92;
                    }
                    else if (joineryCnt > 30)
                    {
                        singlePrice *= 0.95;
                    }

                }
                else if (joineryType == "100X150")
                {
                    singlePrice = 140;
                    if (joineryCnt > 80)
                    {
                        singlePrice *= 0.90;
                    }
                    else if (joineryCnt > 40)
                    {
                        singlePrice *= 0.94;
                    }

                }
                else if (joineryType == "130X180")
                {
                    singlePrice = 190;
                    if (joineryCnt > 50)
                    {
                        singlePrice *= 0.88;
                    }
                    else if (joineryCnt > 20)
                    {
                        singlePrice *= 0.93;
                    }
                }
                else
                {
                    singlePrice = 250;
                    if (joineryCnt > 50)
                    {
                        singlePrice *= 0.86;
                    }
                    else if (joineryCnt > 25)
                    {
                        singlePrice *= 0.91;
                    }
                }
                double finalPrice = singlePrice * joineryCnt;
                if (deliveryWay == "With delivery")
                {
                    finalPrice += 60;
                }
                if (joineryCnt > 99)
                {
                    finalPrice *= 0.96;
                }
                Console.WriteLine($"{finalPrice:f2} BGN");
            }
        }
    }
}