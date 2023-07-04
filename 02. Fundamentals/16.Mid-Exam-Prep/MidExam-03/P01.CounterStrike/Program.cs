namespace P01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int battlesCount = 0;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distanceOfEnemy = int.Parse(input);
                if (distanceOfEnemy <= energy)
                {
                    battlesCount++;
                    energy -= distanceOfEnemy;
                    if (battlesCount % 3 == 0)
                    {
                        energy += battlesCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesCount} won battles and {energy} energy");
                    break;
                }
            }
            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesCount}. Energy left: {energy}");
            }
        }
    }
}