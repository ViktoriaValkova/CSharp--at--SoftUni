namespace P01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days =int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double sumPlunder = 0;
            double targetPlunder = double.Parse(Console.ReadLine());

            for (int i = 1; i <= days; i++)
            {
                sumPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    sumPlunder += dailyPlunder * 0.5;
                }

                if (i % 5 == 0)
                {
                    sumPlunder *= 0.7;
                }
            }
            if (sumPlunder >= targetPlunder)
            {
                Console.WriteLine($"Ahoy! {sumPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {sumPlunder/targetPlunder*100:f2}% of the plunder.");
            }
        }
    }
}