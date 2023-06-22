namespace P03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
           //  double coursesCnt = Math.Ceiling((double)numberPeople / capacity);
           int coursesCnt = (int)Math.Ceiling((double)numberPeople / capacity);
            Console.WriteLine(coursesCnt);
        }
    }
}