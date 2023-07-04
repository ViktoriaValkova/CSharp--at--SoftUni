namespace P02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targetSequence = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            string input = string.Empty;
            // what if target already -1? -doesnt apply
            int shotTargets = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex >= targetSequence.Length
                   || targetSequence[targetIndex] == -1
                || targetIndex < 0)
                {
                    continue;
                }
                else
                {
                    shotTargets++;
                    for (int i = 0; i < targetSequence.Length; i++)
                    {
                        if (targetSequence[i] == -1 || i == targetIndex)
                        {
                            continue;
                        }
                        else if (targetSequence[i] > targetSequence[targetIndex])
                        {
                            targetSequence[i] -= targetSequence[targetIndex];
                        }
                        else
                        {
                            targetSequence[i] += targetSequence[targetIndex];
                        }
                    }
                    targetSequence[targetIndex] = -1;
                }
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(' ', targetSequence)}");
        }
    }
}