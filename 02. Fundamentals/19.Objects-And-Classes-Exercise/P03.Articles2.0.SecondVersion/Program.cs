using System.Dynamic;

namespace P03.Articles2._0.SecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            ArticleCatalog articleCatalog = new ArticleCatalog();
            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(data[0], data[1], data[2]);
                articleCatalog.Articles.Add(article);
            }
            //string command = Console.ReadLine();
            //List<Article> sortedArticles = new List<Article>();
            //if (command == "title")
            //{
            //sortedArticles = articleCatalog.Articles.OrderBy(article => article.Title).ToList();
            //}
            //else if (command == "content")
            //{
            //    sortedArticles = articleCatalog.Articles.OrderBy(article => article.Content).ToList();
            //}
            //else
            //{
            //    sortedArticles=articleCatalog.Articles.OrderBy(article => article.Author).ToList();
            //}

            foreach (var article in articleCatalog.Articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class ArticleCatalog
    {
       public ArticleCatalog()
        {
            this.Articles = new List<Article>();
        }
        
        public List<Article> Articles { get; set; }
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
