namespace P05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLetters = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 0; i < numberLetters; i++)
            {
                string number = Console.ReadLine();
                int numberDigits = number.Length;
                int mainDigit = int.Parse(number) % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + numberDigits - 1;
                int letter = letterIndex + 97;
                if (mainDigit == 0)
                {
                    letter = 32;
                }
                char letterToChar = (char)letter;
                output += letterToChar;

            }
            Console.Write(output);

        }
    }
}