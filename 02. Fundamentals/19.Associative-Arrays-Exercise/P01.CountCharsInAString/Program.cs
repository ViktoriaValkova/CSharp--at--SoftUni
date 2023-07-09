namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().Where(x => x != ' ').ToArray();
            Dictionary<char, int> charsOccurrances = new Dictionary<char, int>();
            // can be done without Where, just with if(ch!=' ') in the foreach
            // would be even better, because you wouldnt modify the input 
            foreach (char individualChar in chars)
            {
                if (!charsOccurrances.ContainsKey(individualChar))
                {
                    charsOccurrances.Add(individualChar, 0);
                }

                charsOccurrances[individualChar]++;
            }

            foreach (var charCnt in charsOccurrances)
            {
                Console.WriteLine($"{charCnt.Key} -> {charCnt.Value}");
            }
        }
    }
}