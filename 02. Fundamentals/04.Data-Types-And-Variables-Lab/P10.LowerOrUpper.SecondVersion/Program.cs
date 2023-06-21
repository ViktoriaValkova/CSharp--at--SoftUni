namespace P10.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char test = char.Parse(Console.ReadLine());
            if (char.IsLower(test))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}