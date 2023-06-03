using System;
using System.Globalization;

namespace P05.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           
            for (int i= 1111; i <=9999; i++)
            {
                 bool isItSpecial = true;
                int currentNum = i;
                int digit = 0;
                while (currentNum>0)
                {
                    digit = currentNum % 10;
                    currentNum /= 10;
                    if (digit == 0)
                    {
                        isItSpecial = false; break;
                    }

                    if (n % digit != 0)
                    {
                        isItSpecial = false;
                        break;
                    }
                }
                if (isItSpecial) { Console.Write(i+" "); }
            }
            
        }
    }
}
