using System.Text;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder encryptedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int newValue = message[i]+3;
                encryptedMessage.Append((char)newValue);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}