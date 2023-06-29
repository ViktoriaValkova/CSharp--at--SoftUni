namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNum = input[0];
            int powerCnt = input[1];

            while (numbers.Contains(specialNum))
            {
                int originalSpecialNumIndex = numbers.IndexOf(specialNum);
                for (int i = 0; i < powerCnt; i++)
                {
                    if (originalSpecialNumIndex - 1 - i >= 0 && originalSpecialNumIndex - 1 - i < numbers.Count)
                    {
                        numbers[originalSpecialNumIndex - 1 - i] = 0;
                    }
                    if (originalSpecialNumIndex + 1 + i >= 0 && originalSpecialNumIndex + 1 + i < numbers.Count)
                    {
                        numbers[originalSpecialNumIndex + 1 + i] = 0;
                    }
                }
                numbers.RemoveAll(num => num == 0);
                numbers.Remove(specialNum);

            }

            int result = numbers.Sum();
            Console.WriteLine(result);
        }
    }
}