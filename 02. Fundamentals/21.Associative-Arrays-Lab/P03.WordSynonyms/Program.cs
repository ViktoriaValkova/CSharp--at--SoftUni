namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymsDictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary.Add(word, new List<string>());
                }

                synonymsDictionary[word].Add(synonym); 
            }

            foreach (var word in synonymsDictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
               


        }
    }
}