using System.Net;

namespace P03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < count; i++)
            {
            string[] data = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(data[0], data[1], data[2]);
                articles.Add(article);
            }

            Console.Write(string.Join(Environment.NewLine,articles));
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}