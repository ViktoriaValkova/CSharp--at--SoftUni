namespace P05.PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstCharIndex = int.Parse(Console.ReadLine());
            int secondCharIndex = int.Parse(Console.ReadLine());
            for (int i = firstCharIndex; i <= secondCharIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}