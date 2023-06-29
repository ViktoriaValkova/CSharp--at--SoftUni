namespace P10._SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commandArgs = input.Split(":");
                string command = commandArgs[0];
                string title = commandArgs[1];

                switch (command)
                {
                    case "Add":
                        AddLesson(schedule, title);
                        break;
                    case "Insert":
                        int indexToInsertAt = int.Parse(commandArgs[2]);
                        InsertLessonAtIndex(schedule, title, indexToInsertAt);
                        break;
                    case "Remove":
                        RemoveLesson(schedule, title);
                        break;
                    case "Swap":
                        string secondLesson = commandArgs[2];
                        SwapTwoLessons(schedule, title, secondLesson);
                        break;
                    case "Exercise":
                        AddExcercise(schedule, title);
                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }

        }
        static void AddExcercise(List<string> schedule, string title)
        {
            if (CheckIfTitleExist(schedule, title) && !CheckIfTitleExist(schedule, $"{title}-Exercise"))
            {
                int indexOfLesson = schedule.IndexOf(title);
                schedule.Insert(indexOfLesson + 1, $"{title}-Exercise");
            }
            else if (!CheckIfTitleExist(schedule, title))
            {
                schedule.Add(title);
                schedule.Add($"{title}-Exercise");

            }
        }
        static void AddLesson(List<string> schedule, string lessonTitle)
        {
            if (!CheckIfTitleExist(schedule, lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
        }
        static bool CheckIfTitleExist(List<string> schedule, string title)
        {
            if (schedule.Contains(title))
            {
                return true;
            }
            return false;
        }
        static void RemoveLesson(List<string> schedule, string lessonTitle)
        {
            if (CheckIfTitleExist(schedule, lessonTitle))
            {
                schedule.Remove(lessonTitle);
            }
            if (CheckIfTitleExist(schedule, $"{lessonTitle}-Exercise"))
            {
                schedule.Remove($"{lessonTitle}-Exercise");
            }
        }
        static void InsertLessonAtIndex(List<string> schedule, string lessonTitle, int index)
        {
            if (!CheckIfTitleExist(schedule, lessonTitle))
            {
                schedule.Insert(index, lessonTitle);
            }
        }
        static void SwapTwoLessons(List<string> schedule, string firstLesson, string secondLesson)
        {
            if (CheckIfTitleExist(schedule, firstLesson) && (CheckIfTitleExist(schedule, secondLesson)))
            {
                int indexFirstLesson = schedule.IndexOf(firstLesson);
                int indexSecondLesson = schedule.IndexOf(secondLesson);
                string tempLessonHolder = schedule[indexFirstLesson];
                schedule[indexFirstLesson] = schedule[indexSecondLesson];
                schedule[indexSecondLesson] = tempLessonHolder;
            }
            if (CheckIfTitleExist(schedule, $"{firstLesson}-Exercise"))
            {
                SwapExercises(schedule, firstLesson);
            }
            if (CheckIfTitleExist(schedule, $"{secondLesson}-Exercise"))
            {
                SwapExercises(schedule, secondLesson);
            }
        }
        static void SwapExercises(List<string> schedule, string lesson)
        {
            int indexFirstLesson = schedule.IndexOf(lesson);
            int initialIndexOfExercise = schedule.IndexOf($"{lesson}-Exercise");
            schedule.Insert(indexFirstLesson + 1, $"{lesson}-Exercise");
            schedule.RemoveAt(initialIndexOfExercise + 1);
        }
        //      swap via deconstruction
        //(schedule[indexFirst Lesson], schedule[indexSecondLesson]) = (schedule[indexSecondLesson], schedule//[indexFirstLesson]);
    }
}