namespace P03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double firstLineSqrLength = DistanceSquaredBetweenTwoPoints(x1, y1, x2, y2);
            double secondLineSqrLength = DistanceSquaredBetweenTwoPoints(x3, y3, x4, y4);
            if (firstLineSqrLength >= secondLineSqrLength)
            {
                double distanceToZeroPointONe = DistanceSquaredBetweenTwoPoints(x1, y1, 0, 0);
                double distanceToZeroPointTwo = DistanceSquaredBetweenTwoPoints(x2, y2, 0, 0);
                if (distanceToZeroPointONe <= distanceToZeroPointTwo)
                {
                    PrintResult(x1,y1,x2,y2);
                }
                else
                {
                    PrintResult(x2, y2, x1, y1);
                }
            }
            else
            {
                double distanceToZeroPointONe = DistanceSquaredBetweenTwoPoints(x3, y3, 0, 0);
                double distanceToZeroPointTwo = DistanceSquaredBetweenTwoPoints(x4, y4, 0, 0);
                if (distanceToZeroPointONe <= distanceToZeroPointTwo)
                {
                    PrintResult(x3, y3, x4, y4);
                }
                else
                {
                    PrintResult(x4, y4, x3, y3);
                }
            }

        }
        static double DistanceSquaredBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distanceSquared =(x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
            return distanceSquared;
        }

        static void PrintResult(double x1, double y1,double x2, double y2)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }

    }
}