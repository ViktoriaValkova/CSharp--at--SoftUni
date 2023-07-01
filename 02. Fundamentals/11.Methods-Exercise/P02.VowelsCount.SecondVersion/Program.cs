namespace P02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetVowelCount(input));
        }

        static int GetVowelCount(string text)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}