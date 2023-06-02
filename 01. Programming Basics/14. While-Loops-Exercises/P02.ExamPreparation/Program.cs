using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unssatisfactoryGrades = int.Parse(Console.ReadLine());
            int numBadGrades = 0;
            int numberOfTasks = 0;
            double sumGrades = 0;
            string lastProblem = "";
            bool didTheyFail = true;


            while (numBadGrades < unssatisfactoryGrades)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    didTheyFail = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numBadGrades++;
                }
                sumGrades += grade;
                numberOfTasks++;
                lastProblem = taskName;
            }
            if (didTheyFail)
            {
                Console.WriteLine($"You need a break, {numBadGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumGrades / numberOfTasks:f2}");
                Console.WriteLine($"Number of problems: {numberOfTasks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
