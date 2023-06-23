namespace P05.DecryptingMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < numberLines; i++)
            {
                char currentCh = char.Parse(Console.ReadLine());
                int charAsInt = (int)currentCh + key;
                 result += (char)charAsInt;
            }
            Console.WriteLine(result);
        }
    }
}