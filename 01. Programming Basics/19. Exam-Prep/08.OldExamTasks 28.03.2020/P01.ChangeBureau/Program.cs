using System;

namespace P01.ChangeBureau        // 28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitCoinCount = int.Parse(Console.ReadLine());
            double chineseJoanCount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine()); // from sum in EUR

            double inLeva = bitCoinCount * 1168 + chineseJoanCount * 0.15 * 1.76;
            double inEur = inLeva / 1.95;
            Console.WriteLine($"{inEur - commission/100*inEur:f2}");
        }
    }
}
