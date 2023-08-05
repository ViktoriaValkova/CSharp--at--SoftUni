using Microsoft.Win32.SafeHandles;

namespace P01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();
            string input;
            bool errorDetected = false;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArg = input.Split(":|:");

                switch (cmdArg[0])
                {
                    case "InsertSpace":
                        message = InsertSpace(message, int.Parse(cmdArg[1]));
                        break;
                    case "Reverse":
                        if (message.Contains(cmdArg[1]))
                        {
                            message = Reverse(message, cmdArg[1]);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            errorDetected = true;
                        }
                        break;
                    case "ChangeAll":
                        message = ChangeSubString(message, cmdArg[1], cmdArg[2]);
                        break;
                }
                if (!errorDetected)
                {
                Console.WriteLine(message);
                }

                errorDetected = false;
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        static string InsertSpace(string message, int index)
        {
            return message.Insert(index, " ");
        }

        static string Reverse(string message, string subString)
        {
            int index = message.IndexOf(subString);
            message = message.Remove(index, subString.Length);
            for (int i = subString.Length - 1; i >= 0; i--)
            {
                message += subString[i];
            }

            return message;
        }

        static string ChangeSubString(string message, string subString, string replacement)
        {

            return message.Replace(subString, replacement);
        }
    }

}