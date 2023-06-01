using System;
namespace P03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else //over 800; 
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(double)p1 /n * 100:f2}%");   // declare the variable as double just for this line 
            Console.WriteLine($"{(double)p2 / n * 100:f2}%");
            Console.WriteLine($"{(double)p3 / n * 100:F2}%");
            Console.WriteLine($"{(double)p4 / n * 100:F2}%");
            Console.WriteLine($"{(double)p5 / n * 100:F2}%");
        }
    }// the variable num can be and should be declared before the for loop:
    // int num; - no initianl value (=0) because we don't need it after the cycle
    // and then in the loop just num = int.Parse Console.Readline ();
}
