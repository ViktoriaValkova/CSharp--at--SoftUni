namespace P01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmdArg = input.Split();

                switch (cmdArg[0])
                {
                    case "TakeOdd":
                        password = OldIndicesConcat(password);
                        break;
                    case "Cut":
                        int index = int.Parse(cmdArg[1]);
                        int length = int.Parse(cmdArg[2]);
                        password = CutPart(password, index, length);
                        break;
                    case "Substitute":
                        string oldString = cmdArg[1];
                        string newString = cmdArg[2];
                        password = SubstituteStringPart(password, oldString, newString);
                        break;
                }

            }
            Console.WriteLine($"Your password is: {password}");
        }

        static string OldIndicesConcat(string password)
        {
            string newPass = string.Empty;
            for (int i = 1; i < password.Length; i+=2)
            {
                    newPass += password[i];
            }
            Console.WriteLine(newPass);
            return newPass;
        }

        static string CutPart(string password, int index, int length)
        {
            password = password.Remove(index, length);
            Console.WriteLine(password);
            return password;
        }

        static string SubstituteStringPart(string password, string oldString, string newString)
        {
            if (password.Contains(oldString))
            {
                password = password.Replace(oldString, newString);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }
    }
}