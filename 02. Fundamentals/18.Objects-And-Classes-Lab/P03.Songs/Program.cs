namespace P03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberSongs; i++)
            {
                string[] info = Console.ReadLine().Split('_');
                Song song = new Song()
                {
                    TypeList = info[0],
                    Name = info[1],
                    Time = info[2]
                };
                songs.Add(song);
            }

            string listType = Console.ReadLine();
            if (listType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == listType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }

    }
}