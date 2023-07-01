namespace P11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers = ExchangeElements(numbers, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "max" && command[1] == "odd")
                {
                    if (MaxOdd(numbers) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MaxOdd(numbers));
                    }
                }
                else if (command[0] == "max" && command[1] == "even")
                {
                    if (MaxEven(numbers) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MaxEven(numbers));
                    }
                }
                else if (command[0] == "min" && command[1] == "odd")
                {
                    if (MinOdd(numbers) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MinOdd(numbers));
                    }
                }
                else if (command[0] == "min" && command[1] == "even")
                {
                    if (MinEven(numbers) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MinEven(numbers));
                    }
                }
                if (command.Length > 2)
                {
                    int count = int.Parse(command[1]);
                    if (count > numbers.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[0] == "first" && command[2] == "even")
                        {
                            if (FirstNEven(numbers, count).Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", FirstNEven(numbers, count))}]");
                            }
                        }
                        else if (command[0] == "first" && command[2] == "odd")
                        {
                            if (FirstNOdd(numbers, count).Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", FirstNOdd(numbers, count))}]");
                            }
                        }
                        else if (command[0] == "last" && command[2] == "even")
                        {
                            if (LastNEven(numbers, count).Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", LastNEven(numbers, count))}]");
                            }
                        }
                        else if (command[0] == "last" && command[2] == "odd")
                        {
                            if (LastNOdd(numbers, count).Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", LastNOdd(numbers, count))}]");
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        static int[] ExchangeElements(int[] numbers, int index)
        {
            int[] newArr = new int[numbers.Length];
            // puts second part in first
            for (int i = 0; i < newArr.Length - index - 1; i++)
            {
                newArr[i] = numbers[index + i + 1];

            }
            // puts first part in second 
            for (int i = 0; i <= index; i++)
            {
                newArr[newArr.Length - index - 1 + i] = numbers[i];
            }

            return newArr;
        }
        static int MaxOdd(int[] numbers)
        {
            int biggestNum = int.MinValue;
            int bestIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] >= biggestNum)
                {
                    biggestNum = numbers[i];
                    bestIndex = i;
                }
            }
            return bestIndex;

        }
        static int MaxEven(int[] numbers)
        {
            int biggestNum = int.MinValue;
            int bestIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= biggestNum)
                {
                    biggestNum = numbers[i];
                    bestIndex = i;
                }
            }
            return bestIndex;
        }
        static int MinOdd(int[] numbers)
        {
            int smallestNum = int.MaxValue;
            int bestIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= smallestNum)
                {
                    smallestNum = numbers[i];
                    bestIndex = i;
                }
            }
            return bestIndex;
        }
        static int MinEven(int[] numbers)
        {
            int smallestNum = int.MaxValue;
            int bestIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                // Very inportant! <= on roder to get the right most if two , otherwise gets the left most
                if (numbers[i] % 2 == 0 && numbers[i] <= smallestNum)
                {
                    smallestNum = numbers[i];
                    bestIndex = i;
                }
            }
            return bestIndex;
        }
        static int[] FirstNEven(int[] numbers, int count)
        {
            int counter = 0;
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (counter == count)
                {
                    break;
                }
                if (number % 2 == 0)
                {
                    counter++;
                    result.Add(number);
                }
            }
            return result.ToArray();
        }
        static int[] FirstNOdd(int[] numbers, int count)
        {
            int counter = 0;
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (counter == count)
                {
                    break;
                }
                if (number % 2 != 0)
                {
                    counter++;
                    result.Add(number);
                }
            }
            return result.ToArray();
        }
        static int[] LastNEven(int[] numbers, int count)
        {
            int counter = 0;
            List<int> result = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (counter == count)
                {
                    break;
                }
                if (numbers[i] % 2 == 0)
                {
                    counter++;
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            return result.ToArray();
        }
        static int[] LastNOdd(int[] numbers, int count)
        {
            int counter = 0;
            List<int> result = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (counter == count)
                {
                    break;
                }
                if (numbers[i] % 2 != 0)
                {
                    counter++;
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            return result.ToArray();
        }
    }
}