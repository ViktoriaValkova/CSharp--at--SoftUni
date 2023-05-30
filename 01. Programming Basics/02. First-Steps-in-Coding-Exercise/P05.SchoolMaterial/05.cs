using System;
namespace _05._School_material
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int cleaningSolution = int.Parse(Console.ReadLine());
            double otstupka = double.Parse(Console.ReadLine()) / 100.0;
            double a = pen * 5.8;
            double b = marker * 7.2;
            double c = cleaningSolution * 1.2;
            double bezOtstupka = a + b + c;
            double suma = bezOtstupka - (bezOtstupka * otstupka);
            Console.WriteLine(suma);
        }
    }
}