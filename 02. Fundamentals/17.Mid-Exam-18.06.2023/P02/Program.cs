namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersSeq = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] cmdArg = command.Split();
                int value = int.Parse(cmdArg[1]);
                switch (cmdArg[0])
                {
                    case "Add":
                        numbersSeq.Add(value);
                        break;
                    case "Remove":
                        Remove(numbersSeq, value);
                        break;
                    case "Replace":
                        int newNum = int.Parse(cmdArg[2]);
                        Replace(numbersSeq, value, newNum);
                        break;
                    case "Collapse":
                        Collapse(numbersSeq, value);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbersSeq));
        }

        static void Remove(List<int> numbersSeq, int value)
        {
            if (numbersSeq.Contains(value))
            {
                numbersSeq.Remove(value);
            }
        }

        static void Replace(List<int> numbersSeq, int value, int newNum)
        {
            if (numbersSeq.Contains(value))
            {
                int index = numbersSeq.IndexOf(value);
                numbersSeq[index] = newNum;
            }
        }

        static void Collapse(List<int> numbersSeq, int value)
        {
            numbersSeq.RemoveAll(num => num < value);
        }
    }
}