namespace P06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lettersCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < lettersCnt; i++)
            {
                for (int j = 0; j < lettersCnt; j++)
                {
                    for (int k = 0; k < lettersCnt; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);
                        Console.Write($"{firstChar}{secondChar}{thirdChar}");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}