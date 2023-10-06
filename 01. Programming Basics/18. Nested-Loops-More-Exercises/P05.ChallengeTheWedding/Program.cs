using System;

namespace P05.ChallengeTheWedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    if (counter < tables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                        counter++;
                    }


                }
            }
        }
    }
}
