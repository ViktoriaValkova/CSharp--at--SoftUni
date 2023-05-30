using System;
namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double razhodNylon = (nylon + 2.0) * 1.5;
            double razhodPaint = (paint + paint * 0.10) * 14.5;
            double razhodRazreditel = razreditel * 5.0;
            double materiali = (razhodNylon + razhodRazreditel + razhodPaint) + 0.4;
            double maistori = (materiali * 0.3) * hours;
            double suma = materiali + maistori;
            Console.WriteLine(suma);
        }
    }
}