namespace P02.TheLift.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int[] liftState = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < liftState.Length; i++)
            {
                for (int j = liftState[i]; j < 4; j++)
                {
                    liftState[i]++;
                    peopleCnt--;
                    if (peopleCnt == 0)
                    {
                        if (liftState.Sum() < liftState.Length * 4)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(" ",liftState));
                        return;
                    }
                }
               
            }
            Console.WriteLine($"There isn't enough space! {peopleCnt} people in a queue!");
            Console.WriteLine(string.Join(" ", liftState));
        }
    }
}