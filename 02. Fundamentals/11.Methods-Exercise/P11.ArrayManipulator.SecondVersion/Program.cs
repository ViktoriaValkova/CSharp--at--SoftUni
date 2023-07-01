namespace P11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                string commandType = command[0];

                if (commandType == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers = ExchangedArray(numbers, index);
                }
                else if (commandType == "max" || commandType == "min")
                {
                    string evenOrOdd = command[1];
                    int indexOfElement;
                    if (commandType == "max")
                    {
                        indexOfElement = IndexOfMaxEvenOrOddElement(numbers, evenOrOdd);
                    }
                    else
                    {
                        indexOfElement = IndexOfMinEvenOrOddElement(numbers, evenOrOdd);
                    }
                    if (indexOfElement == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfElement);
                }
                else if (commandType == "last" || commandType == "first")
                {
                    int count = int.Parse(command[1]);
                    string evenOrdOdd = command[2];
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;
                    if (commandType == "first")
                    {
                        elements = FirstEvenOrOddElements(numbers, count, evenOrdOdd);
                    }
                    else
                    {
                        elements = LastEvenOrOddElements(numbers, count, evenOrdOdd);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(numbers);
        }

        static int[] ExchangedArray(int[] numbers, int index)
        {
            int[] exchangedArr = new int[numbers.Length];
            int modifiedIndex = 0; // index for the modifed array 

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangedArr[modifiedIndex] = numbers[i];
                modifiedIndex++; // can be done on l.74 simultainosly 

            }
            for (int i = 0; i <= index; i++)
            {
                exchangedArr[modifiedIndex] = numbers[i];
                modifiedIndex++;
            }
            return exchangedArr;
        }
        static int IndexOfMaxEvenOrOddElement(int[] numbers, string evenOrOdd)
        {
            int maxIndex = -1;
            int maxNum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (evenOrOdd == "even" && numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxNum)
                    {
                        maxNum = numbers[i];
                        maxIndex = i;
                    }
                }
                else if (evenOrOdd == "odd" && numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxNum)
                    {
                        maxNum = numbers[i];
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }
        static int IndexOfMinEvenOrOddElement(int[] numbers, string evenOrOdd)
        {
            int minIndex = -1;
            int minNum = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (evenOrOdd == "even" && numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minNum)
                    {
                        minNum = numbers[i];
                        minIndex = i;
                    }
                }
                else if (evenOrOdd == "odd" && numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minNum)
                    {
                        minNum = numbers[i];
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }

        static int[] FirstEvenOrOddElements(int[] numbers, int count, string evenOrOdd)
        {
            int[] firstElements = new int[count];
            int firstElementsCnt = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (firstElementsCnt >= count)
                {
                    break;
                }
                int currentNum = numbers[i];
                if (evenOrOdd == "even" && currentNum % 2 == 0)
                {
                    firstElements[firstElementsCnt++] = currentNum;
                }
                else if (evenOrOdd == "odd" && currentNum % 2 != 0)
                {
                    firstElements[firstElementsCnt++] = currentNum;
                }
            }
            if (firstElementsCnt < count)
            {
                firstElements = ArrayResizer(firstElements, firstElementsCnt);
            }
            return firstElements;
        }
        static int[] LastEvenOrOddElements(int[] numbers, int count, string evenOrOdd)
        {
            int[] lastElements = new int[count];
            int lastElementsCnt = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (lastElementsCnt >= count)
                {
                    break;
                }
                int currentNum = numbers[i];
                if (evenOrOdd == "even" && currentNum % 2 == 0)
                {
                    lastElements[lastElementsCnt++] = currentNum;
                }
                else if (evenOrOdd == "odd" && currentNum % 2 != 0)
                {
                    lastElements[lastElementsCnt++] = currentNum;
                }
            }
            if (lastElementsCnt < count)
            {
                lastElements = ArrayResizer(lastElements, lastElementsCnt);
            }
            lastElements = ReverseArray(lastElements);
            return lastElements;
        }

        static int[] ArrayResizer(int[] elements, int firstElCnt)
        {
            int[] resizedArr = new int[firstElCnt];

            for (int i = 0; i < firstElCnt; i++)
            {
                resizedArr[i] = elements[i];
            }
            return resizedArr;
        }
        static int[] ReverseArray(int[] elements)
        {
            int[] reversed = new int[elements.Length];
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - 1 - i] = elements[i];
            }
            return reversed;
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

    }
}