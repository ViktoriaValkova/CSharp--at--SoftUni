namespace P02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dolllars = 1.31f * pounds;
            Console.WriteLine($"{dolllars:f3}");
        }
    }
}