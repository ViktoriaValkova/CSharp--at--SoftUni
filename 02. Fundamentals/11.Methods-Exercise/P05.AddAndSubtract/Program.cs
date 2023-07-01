namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!CorrectLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IncorrectSymbol(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!EnoughDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (!IncorrectSymbol(password) && CorrectLength(password) && EnoughDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool CorrectLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool IncorrectSymbol(string password)
        {
            bool hasIncorrectSymbol = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] < 48 || (password[i] > 57 && password[i] < 65)
                    || (password[i] > 90 && password[i] < 96)
                    || password[i] > 123)
                {
                    hasIncorrectSymbol = true;
                }
            }
            return hasIncorrectSymbol;
        }
        static bool EnoughDigits(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}