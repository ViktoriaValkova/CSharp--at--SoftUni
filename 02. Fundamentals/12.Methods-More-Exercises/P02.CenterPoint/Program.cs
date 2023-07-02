namespace P02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double firstPointDistance = DistanceToZero(x1, y1);
            double secondPointDistance = DistanceToZero(x2, y2);
            if (firstPointDistance <= secondPointDistance)
            {
                PrintResult(x1, y1);
            }
            else if (firstPointDistance > secondPointDistance)
            {
                PrintResult(x2, y2);
            }
        }
        static double DistanceToZero(double x, double y)
        {
            double distanceSquared =(0-x)*(0-x)+(0-y)*(0-y);
            return distanceSquared;
        }
        static void PrintResult(double x, double y)
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
}