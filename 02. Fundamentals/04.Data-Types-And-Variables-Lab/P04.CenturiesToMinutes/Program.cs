namespace P04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422); // has to be to both, because to (int) refers to the operator 
            long hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}