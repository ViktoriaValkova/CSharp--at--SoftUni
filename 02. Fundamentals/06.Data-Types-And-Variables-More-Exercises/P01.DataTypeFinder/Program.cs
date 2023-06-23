namespace P01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int value))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double floating))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char ch))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool YesOrNo))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}