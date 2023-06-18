namespace P05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine()!;
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            string tryPass = string.Empty;
            int counter = 0;
            while ((tryPass = Console.ReadLine()!) != password)
            {
                               counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
 
                Console.WriteLine("Incorrect password. Try again.");

            }
            if (tryPass == password)
            {
                Console.WriteLine($"User {userName} logged in.");
            }

            //string username = Console.ReadLine();
            //string expectedPassword = new string(userName.Reverse().ToArray());
        }
    }
}
