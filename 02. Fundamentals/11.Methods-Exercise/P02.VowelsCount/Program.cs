namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NumberVowels(input);
        }
        static void NumberVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u' ||
                    input[i] == 'A' || input[i] == 'O' || input[i] == 'E' || input[i] == 'I' || input[i] == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}