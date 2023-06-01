using System;

namespace P06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int waterBill = 0;
            int internetBill = 0;
            double electricBill = 0.0;
            double others = 0;

            for (int i = 0; i < months; i++)
            {

                electricBill += double.Parse(Console.ReadLine());
                waterBill += 20;
                internetBill += 15;
                others = (electricBill + waterBill + internetBill) + 0.2 * (electricBill + waterBill + internetBill);

            }
            Console.WriteLine($"Electricity: {electricBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {(waterBill + internetBill + electricBill + others) / months:f2} lv");

        }
    }
}
