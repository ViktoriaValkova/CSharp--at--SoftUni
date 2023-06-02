using System;

namespace P04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int sequenceNumber = 1;
      
            while (sequenceNumber<=endNumber)
            {
                Console.WriteLine(sequenceNumber);
                sequenceNumber = sequenceNumber * 2 + 1;
            }
        }
    }
}
