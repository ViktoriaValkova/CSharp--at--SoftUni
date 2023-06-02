using System;

namespace P02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username= Console.ReadLine();
            string password= Console.ReadLine();
            string tryPassword = Console.ReadLine();
            while (tryPassword != password)
            {
                tryPassword = Console.ReadLine();
            }
           Console.WriteLine($"Welcome {username}!");
        }
    }
}
