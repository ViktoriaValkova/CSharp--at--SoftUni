namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Dictionary<int, int> countOfNums = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!countOfNums.ContainsKey(number))
                {
                    countOfNums.Add(number, 0);
                }
                    countOfNums[number]++;

            }
            // can be done with SortedDictionary 
           countOfNums = countOfNums.OrderBy(c => c.Key).ToDictionary(c=>c.Key, c=>c.Value);

            foreach (var pair in countOfNums)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}