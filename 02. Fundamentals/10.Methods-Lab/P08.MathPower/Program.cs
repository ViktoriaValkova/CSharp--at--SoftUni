namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powerNUm = int.Parse(Console.ReadLine());

            Console.WriteLine(NumPowered(baseNum,powerNUm));    
        }

         static double NumPowered(double baseNum, int powerNum)
        {
            double sum = baseNum;
            for (int i = 1; i < powerNum; i++)
            {
                 sum *= baseNum;
            }
            return sum;
        }
    }
}