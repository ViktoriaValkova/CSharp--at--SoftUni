namespace P05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string header = Console.ReadLine();
           string content= Console.ReadLine();

           string input =string.Empty;
           Console.WriteLine("<h1>");
           Console.WriteLine($"     {header}");
           Console.WriteLine("</h1>");
           Console.WriteLine("<article>");
           Console.WriteLine($"     {content}");
           Console.WriteLine("</article>");

           while ((input = Console.ReadLine()) != "end of comments")
           {
               Console.WriteLine("<div>");
               Console.WriteLine($"     {input}");
               Console.WriteLine("</div>");
           }
        }
    }
}