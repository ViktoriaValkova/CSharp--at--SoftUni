namespace P03
{
    internal class Program
    {
        static Dictionary<string, List<string>> mealsByGuest = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            string input;
            int dislikedCnt = 0;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = input.Split("-");
                string guest = cmdArg[1];
                string meal = cmdArg[2];
                switch (cmdArg[0])
                {
                    case "Like":
                        AddGuestAndMeal(guest, meal);
                        break;
                    case "Dislike":
                        RemoveMeal(guest, meal, ref dislikedCnt);
                        break;
                }
            }

            foreach (var kvp in mealsByGuest)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {dislikedCnt}");
        }

        static void AddGuestAndMeal(string guest, string meal)
        {
            if (!mealsByGuest.ContainsKey(guest))
            {
                mealsByGuest[guest] = new List<string>();
            }
            if (!mealsByGuest[guest].Contains(meal))
            {
                mealsByGuest[guest].Add(meal);
            }
        }

        static void RemoveMeal(string guest, string meal, ref int dislikedCnt)
        {
            if (!mealsByGuest.ContainsKey(guest))
            {
                Console.WriteLine($"{guest} is not at the party.");
            }
            else if (!mealsByGuest[guest].Contains(meal))
            {
                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
            }
            else
            {
                Console.WriteLine($"{guest} doesn't like the {meal}.");
                mealsByGuest[guest].Remove(meal);
                dislikedCnt++;
            }
        }
    }
}