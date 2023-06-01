using System;

namespace P03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loadCount = int.Parse(Console.ReadLine());
            int microbusWeight = 0;
            int truckWeight=0; 
            int trainWeight = 0;
            int price = 0;
            int sumWeight = 0;
            for (int i = 1; i <= loadCount; i++)
            {
                int loadWeight = int.Parse(Console.ReadLine());
                sumWeight += loadWeight;
            if (loadWeight <= 3)
                {
                    microbusWeight += loadWeight; 
                    price += 200*loadWeight;
                    
                }
            else if (loadWeight <= 11)
                {
                    price += loadWeight*175;
                    truckWeight += loadWeight;
                }
            else
                {
                    price += loadWeight*120;
                    trainWeight += loadWeight;
                }            
            }
            Console.WriteLine($"{price*1.0/sumWeight:f2}");
            Console.WriteLine($"{ microbusWeight*1.0/ sumWeight * 100:f2}%");
            Console.WriteLine($"{truckWeight * 1.0 / sumWeight * 100:f2}%");
            Console.WriteLine($"{trainWeight * 1.0 / sumWeight * 100:f2}%");
        }
    }
}
