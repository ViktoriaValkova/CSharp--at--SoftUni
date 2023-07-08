namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Select(x=>x.ToLower()).ToArray();
            Dictionary<string,int> wordsByOccurrences = new Dictionary<string,int>();

            foreach (string word in words)
            {
                if (!wordsByOccurrences.ContainsKey(word))
                {
                    wordsByOccurrences.Add(word, 0);
                }
                wordsByOccurrences[word]++;
            }

            var result = wordsByOccurrences.Where(x => x.Value % 2 != 0);

            foreach (var occurence in result)
            {
                Console.WriteLine($"{occurence.Key} ");
            }
        }
    }
}