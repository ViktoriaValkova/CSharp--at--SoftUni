namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] cmdArg = input.Split();

                switch (cmdArg[0])
                {
                    case "Replace":
                        message = message.Replace(cmdArg[1], cmdArg[2]);
                        Console.WriteLine(message);
                        break;
                    case "Cut":
                        message = RemoveSubStr(message, int.Parse(cmdArg[1]), int.Parse(cmdArg[2]));
                        break;
                    case "Make":
                        message = ChangeCase(message, cmdArg[1]);
                        Console.WriteLine(message);
                        break;
                    case "Check":
                        CheckIfContains(message, cmdArg[1]);
                        break;
                    case "Sum":
                        PrintSubStrSum(message, int.Parse(cmdArg[1]), int.Parse(cmdArg[2]));
                        break;
                }
            }
        }

        static string RemoveSubStr(string message, int startIndex, int endIndex)
        {
            if (IndexIsValid(message, startIndex, endIndex))
            {
                message = message.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(message);
            }

            return message;
        }

        static bool IndexIsValid(string message, int startIndex, int endIndex)
        {
            if (startIndex >= 0 && endIndex < message.Length && startIndex <= endIndex)
            {
                return true;
            }

            Console.WriteLine("Invalid indices!");
            return false;
        }

        static string ChangeCase(string message, string newCase)
        {
            if (newCase == "Upper")
            {
                return message.ToUpper();
            }

            return message.ToLower();
        }
        static void CheckIfContains(string message, string subStr)
        {
            if (message.Contains(subStr))
            {
                Console.WriteLine($"Message contains {subStr}");
                return;
            }

            Console.WriteLine($"Message doesn't contain {subStr}");
        }
        static void PrintSubStrSum(string message, int startIndex, int endIndex)
        {
            if (IndexIsValid(message, startIndex, endIndex))
            {
                string subStr = message.Substring(startIndex, endIndex - startIndex + 1);
                double sum = 0;
                foreach (char ch in subStr)
                {
                    sum += ch;
                }

                Console.WriteLine(sum);
            }
        }
    }
}