using System;

namespace P03.PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColor = Console.ReadLine();
            int batchCnt = int.Parse(Console.ReadLine());
            int batchPrice = 0;
            if (eggSize == "Large")
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 16; break;
                    case "Green": batchPrice = 12; break;
                    case "Yellow": batchPrice = 9; break;
                }
            }
            else if (eggSize == "Medium")
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 13; break;
                    case "Green": batchPrice = 9; break;
                    case "Yellow": batchPrice = 7; break;
                }
            }
            else
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 9; break;
                    case "Green": batchPrice = 8; break;
                    case "Yellow": batchPrice = 5; break;
                }
            }
            int price = batchPrice * batchCnt;
            double finalIncome =price * 0.65;
            Console.WriteLine($"{finalIncome:f2} leva.");
        }
    }
}
