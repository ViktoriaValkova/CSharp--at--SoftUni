namespace P01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();
            if (type == "int")
            {
                PrintInput(int.Parse(input));
            }
            else if (type == "real")
            {
                PrintInput(double.Parse(input));
            }
            else if (type == "string")
            {
                PrintInput(input);
            }
        }
        static void PrintInput(string input)
        {
            Console.WriteLine($"${input}$");
        }
        static void PrintInput(int number)
        {
            number *= 2;
            Console.WriteLine(number);
        }
        static void PrintInput(double number)
        {
            number *= 1.5;
            Console.WriteLine($"{number:f2}");
        }
    }
}