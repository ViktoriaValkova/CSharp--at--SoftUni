using System;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberJudges = int.Parse(Console.ReadLine());
            string text = "";
            double mark = 0;
            double sumMarksTask = 0;
            double sumAllMarks = 0;
            int numOfMarks = 0;
            while ((text = Console.ReadLine()) != "Finish")
            {

                for (int i = 0; i < numberJudges; i++)
                {
                    mark = double.Parse(Console.ReadLine());
                    sumMarksTask += mark;
                    numOfMarks++;
                }
                Console.WriteLine($"{text} - {sumMarksTask/numberJudges:f2}.");
                sumAllMarks += sumMarksTask;
                sumMarksTask = 0;

            }
            Console.WriteLine($"Student's final assessment is {sumAllMarks / numOfMarks:f2}.");
        }
    }
}
