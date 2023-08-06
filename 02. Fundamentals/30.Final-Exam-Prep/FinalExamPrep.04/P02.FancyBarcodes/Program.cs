using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace P02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(@#+)(?<product>[A-Z][a-zA-Z\d]{4,}[A-Z])(@#+)$";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();

                Match validBarcode = Regex.Match(barcode, pattern);

                if (validBarcode.Success)
                {
                    string productGroup = FindGroup(validBarcode);
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
               
        }

         static string FindGroup(Match validBarcode)
         {
             string productGroup = string.Empty;
             string productName = validBarcode.Groups["product"].Value;
             foreach (char ch in productName)
             {
                 if (char.IsDigit(ch))
                {
                    productGroup += ch;
                }
             }
             if (productGroup == string.Empty)
             {
                 productGroup = "00";
             }

             return productGroup;
         }
    }
}