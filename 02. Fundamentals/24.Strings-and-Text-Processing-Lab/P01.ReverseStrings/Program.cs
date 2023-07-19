namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "end")
            {
                string reversedStr = string.Empty;
                for (int i = input.Length-1; i >= 0; i--)
                {
                    reversedStr += input[i];
                }

                Console.WriteLine($"{input} = {reversedStr}");
            }
        }
    }
}