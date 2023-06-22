namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte pourCnt = byte.Parse(Console.ReadLine());
            int capacity = 255;
            for (int i = 0; i< pourCnt; i++)
            {
                short pourQuantity = short.Parse(Console.ReadLine());
                if (pourQuantity <= capacity)
                {
                    capacity -= pourQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
           Console.WriteLine($"{255 - capacity}");
        }
    }
}