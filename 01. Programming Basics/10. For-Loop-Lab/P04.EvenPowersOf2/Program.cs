using System;

namespace P04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int power = 0; power <=n; power+=2) // with +=2 we guarantee that only even power are looked for
            {                                        // without unnecessary conditions.
                Console.WriteLine(Math.Pow(2, power));            
            }
        }
    }
}
