using System;

namespace P06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string language = string.Empty;
            switch (countryName)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish"; 
                    break;
                default: language = "unknown";break;
            }
            Console.WriteLine(language);
        }
    }
}
