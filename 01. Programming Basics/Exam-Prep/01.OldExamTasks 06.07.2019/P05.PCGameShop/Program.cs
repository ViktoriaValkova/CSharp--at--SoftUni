using System;

namespace P05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberGamesSold  = int.Parse(Console.ReadLine());
            int hearthstoneCnt = 0;
            int forniteCnt = 0;
            int overwatchCnt = 0 ;
            int othersCnt = 0 ;
            for (int i = 0; i < numberGamesSold; i++)
            {
                string gameName = Console.ReadLine();
                if (gameName == "Hearthstone")
                {
                    hearthstoneCnt++;
                }
                else if (gameName == "Fornite")
                {
                    forniteCnt++;
                }
                else if (gameName == "Overwatch")
                {
                    overwatchCnt++;
                }
                else
                {
                    othersCnt++;
                }
            }
            Console.WriteLine($"Hearthstone - {(double)hearthstoneCnt/numberGamesSold*100:f2}%");         
            Console.WriteLine($"Fornite - {(double)forniteCnt/numberGamesSold*100:f2}%");         
            Console.WriteLine($"Overwatch - {(double)overwatchCnt/numberGamesSold*100:f2}%");         
            Console.WriteLine($"Others - {(double)othersCnt/numberGamesSold*100:f2}%");         
        }
    }
}
