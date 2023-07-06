namespace P01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCnt = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double totalFood = foodPerDayPerPerson * days * playersCnt;
            double totalWater = waterPerDayPerPerson * days * playersCnt;

            for (int i = 1; i <= days; i++)
            {
                energy -= double.Parse(Console.ReadLine());
                if (energy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    energy *= 1.05;
                    totalWater *= 0.7;
                }

                if (i % 3 == 0)
                {
                    totalFood -= totalFood / playersCnt;
                    energy *= 1.1;
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
                return;
            }

            Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
        }
    }
}