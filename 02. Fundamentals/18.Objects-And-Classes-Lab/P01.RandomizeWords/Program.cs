namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();
            random.Next();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);

                (words[i], words[randomIndex]) = (words[randomIndex], words[i]);
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}