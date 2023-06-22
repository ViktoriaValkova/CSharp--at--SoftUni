namespace P04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte charCnt = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < charCnt; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}