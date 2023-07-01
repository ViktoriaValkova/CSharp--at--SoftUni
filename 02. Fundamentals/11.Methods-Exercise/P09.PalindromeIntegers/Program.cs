namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsItPalindrome(input));
            }

        }
        static bool IsItPalindrome(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}