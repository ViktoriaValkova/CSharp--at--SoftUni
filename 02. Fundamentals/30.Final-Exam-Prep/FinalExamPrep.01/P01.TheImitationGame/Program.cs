namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArg = command.Split('|').ToArray();

                switch (cmdArg[0])
                {
                    case "Move":
                        encryptedMessage = MoveLetters(encryptedMessage, cmdArg);
                        break;
                    case "Insert":
                        encryptedMessage = InsertValue(encryptedMessage, cmdArg);
                        break;
                    case "ChangeAll":
                        encryptedMessage = ReplaceWithValue(encryptedMessage, cmdArg);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }

        private static string ReplaceWithValue(string encryptedMessage, string[] cmdArg)
        {
            string oldString = cmdArg[1];
            string replacement = cmdArg[2];
            encryptedMessage = encryptedMessage.Replace(oldString, replacement);

            return encryptedMessage;
        }

        private static string InsertValue(string encryptedMessage, string[] cmdArg)
        {
            int index = int.Parse(cmdArg[1]);
            string value = cmdArg[2];
            encryptedMessage = encryptedMessage.Insert(index, value);

            return encryptedMessage;
        }

        private static string MoveLetters(string encryptedMessage, string[] cmdArg)
        {
            int lettersCnt = int.Parse(cmdArg[1]);
            string lastLetters = encryptedMessage.Substring(0, lettersCnt);
            encryptedMessage = encryptedMessage.Remove(0, lettersCnt);

            return encryptedMessage += lastLetters;
        }
    }
}