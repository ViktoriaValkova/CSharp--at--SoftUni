namespace P04._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!IsLengthValid(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyNumbersAndLetters(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainsMoreThanOneDigit(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsLengthValid(input) && OnlyNumbersAndLetters(input) && ContainsMoreThanOneDigit(input))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool IsLengthValid(string text)
        {
            bool isValid = text.Length >= 6 && text.Length <= 10;
            return isValid;
        }
        static bool OnlyNumbersAndLetters(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ContainsMoreThanOneDigit(string text)
        {
            int digitCnt = 0;

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digitCnt++;
                }
            }
            return digitCnt > 1;
        }
    }
}