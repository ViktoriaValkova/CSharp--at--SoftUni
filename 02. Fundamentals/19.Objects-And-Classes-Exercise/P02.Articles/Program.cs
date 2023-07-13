
namespace P02.Articles
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(data[0], data[1], data[2]);

            int numberCmds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCmds; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ");

                switch (cmdArg[0])
                {
                    case "Edit":
                        article.Edit(cmdArg[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(cmdArg[1]);
                        break;
                    case "Rename":
                        article.Rename(cmdArg[1]);
                        break;
                }
            }

            Console.Write(article);
        }
    }
     class Article
    {
        public Article(string title, string content, string author)
        {
            this.Author= author;
            this.Title= title;
            this.Content= content;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent )
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}