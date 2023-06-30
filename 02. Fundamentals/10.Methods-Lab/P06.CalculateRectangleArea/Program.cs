namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = Area (height,width);
            Console.WriteLine(area);
        }
         static double Area(double height, double width)
        {
            return height * width;
           
        }
    }
}