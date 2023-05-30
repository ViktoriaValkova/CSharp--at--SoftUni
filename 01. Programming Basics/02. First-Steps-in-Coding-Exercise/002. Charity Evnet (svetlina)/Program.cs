namespace _002._Charity_Evnet__svetlina_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double prihod = (cakes * 45 + pancakes * 3.2 + waffles * 5.8)*days*bakers;
            double nettoPrihod = prihod - prihod / 8;
            Console.WriteLine(nettoPrihod);
        }
    }
}