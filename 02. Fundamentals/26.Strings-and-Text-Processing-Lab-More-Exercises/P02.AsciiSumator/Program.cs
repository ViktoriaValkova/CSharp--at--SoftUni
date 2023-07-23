namespace P02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startCh = char.Parse(Console.ReadLine()); 
            char endCh = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char ch in input)
            {
                if (ch > startCh && ch < endCh)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);

        }
    }
}