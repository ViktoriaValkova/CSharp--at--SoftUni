using System;

namespace P04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(string.Join(' ',TribonacciSeq(num)));

        }
        static int [] TribonacciSeq (int num)
        {
            int[] seq = new int[num];
            seq[0] = 1; 
            if (seq.Length > 1)
            {
                seq[1] = 1;
            }
            if (seq.Length > 2)
            {
                seq[1] = 1;
                seq[2] = 2;
                for (int i = 3; i < num; i++)
                {
                    seq[i] = seq[i - 1] + seq[i - 2]+ seq[i-3];
                }
            }  
            return seq;
        }
    }
}