namespace P02.OddOccurrences.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Select(x => x.ToLower()).ToArray();
            Dictionary<string, int> wordsByOccurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordsByOccurrences.ContainsKey(word))
                {
                    wordsByOccurrences.Add(word, 0);
                }
                wordsByOccurrences[word]++;
            }

            string[] oddCounts = wordsByOccurrences.Where(w => w.Value % 2 != 0).Select(w => w.Key).ToArray();

            Console.WriteLine(String.Join(" ", oddCounts));
        }
    }
}