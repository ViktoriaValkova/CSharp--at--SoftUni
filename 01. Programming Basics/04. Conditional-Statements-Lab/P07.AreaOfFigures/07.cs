using System;
namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();
            if (figura == "square")
            {
                double squareSideLength = double.Parse(Console.ReadLine());
                double areaSquare = squareSideLength * squareSideLength;
                Console.WriteLine("{0:F3}", areaSquare);
            }

            else if (figura == "triangle")
            {
                double triangleSideLength = double.Parse(Console.ReadLine());
                double triangleHigth = double.Parse(Console.ReadLine());
                double areaTriangle = triangleHigth * triangleSideLength / 2;

                Console.WriteLine("{0:F3}", areaTriangle);
            }
            else if (figura == "rectangle")
            {
                double rectangleLength = double.Parse(Console.ReadLine());
                double rectangleHeigth = double.Parse(Console.ReadLine());
                double areaRectangle = (rectangleHeigth * rectangleLength);
                Console.WriteLine("{0:F3}", areaRectangle);
            }
            else if (figura == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                double areaCircle = pi * circleRadius * circleRadius;
                Console.WriteLine("{0:F3}", areaCircle);
            }
        }
    }
}