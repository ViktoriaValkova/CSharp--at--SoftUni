using System;
namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int totalTime = a + b + c;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            // int seconds = totalTime – (minutes*60); 
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}