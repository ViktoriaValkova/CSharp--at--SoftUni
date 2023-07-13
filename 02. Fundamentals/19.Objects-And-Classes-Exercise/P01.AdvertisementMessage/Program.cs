namespace P01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product."
            };
            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int indexPhrases = random.Next(phrases.Length);
                string phrase = phrases[indexPhrases];

                int indexEvents = random.Next(events.Length);
                string currentEvent = events[indexEvents];

                int indexAuthors = random.Next(authors.Length);
                string author = authors[indexAuthors];

                int indexCity = random.Next(cities.Length);
                string city = cities[indexCity];

                Console.WriteLine($"{phrase} {currentEvent} {author} – {city}");
            }
        }
    }
}