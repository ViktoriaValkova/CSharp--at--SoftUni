namespace P04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()!);
            int secondNum = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = firstNum; i<=secondNum; i++) 
            {
                Console.Write(i+" ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

           //var sequence = Enumerable.Range(firstNum, secondNum - firstNum + 1);
           //Console.WriteLine(string.Join(' ', sequence));
           //Console.WriteLine($"Sum: {sequence.Sum()}");
        }
    }
}