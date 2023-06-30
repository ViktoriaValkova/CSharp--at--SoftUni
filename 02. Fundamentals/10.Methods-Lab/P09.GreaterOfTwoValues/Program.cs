namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string firstElement = Console.ReadLine();
            string secondElement = Console.ReadLine();
            switch (valueType)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(firstElement), int.Parse(secondElement))); break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(firstElement),char.Parse( secondElement))); break;
                case "string":
                    Console.WriteLine(GetMax(firstElement, secondElement)); break;
            }
        }

        static int GetMax(int firstElement, int secondElement)
        {
            if (firstElement > secondElement)
            {
                return firstElement;
            }
                return secondElement; // no need for else, as if it oes into the if, return will exit the method
            
        }
        static char GetMax(char firstElement, char secondElement)
        {
            if (firstElement > secondElement)
            {
                return firstElement;
            }
                return secondElement;

        }
        static string GetMax(string firstElement, string secondElement)
        {
            int result = firstElement.CompareTo(secondElement);
           
            if (result>0)
            {
                return firstElement;
            }
                return secondElement; 
        }
    }
}