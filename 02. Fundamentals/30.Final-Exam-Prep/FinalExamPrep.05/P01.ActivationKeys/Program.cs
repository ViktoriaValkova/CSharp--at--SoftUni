namespace P01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmdArg = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArg[0])
                {
                    case "Contains":
                        string subStr = cmdArg[1];
                        key = CheckForSubStr(key, subStr);
                        break;
                    case "Flip":
                        int startIndex = int.Parse(cmdArg[2]);
                        int endIndex = int.Parse(cmdArg[3]);
                        if (cmdArg[1] == "Upper")
                        {
                            key = FlipToUpper(key,startIndex, endIndex);
                            continue;
                        }
                        key = FlipLower (key,startIndex, endIndex);
                            break;
                    case "Slice":
                        startIndex = int.Parse(cmdArg[1]);
                        endIndex = int.Parse(cmdArg[2]);
                        key = SliceKey (key, startIndex, endIndex);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

         static string CheckForSubStr(string key, string subStr)
        {
            if (key.Contains(subStr))
            {
                Console.WriteLine($"{key} contains {subStr}");
                return key;
            }

            Console.WriteLine("Substring not found!");
                return key;
        }

         static string FlipToUpper(string key, int startIndex, int endIndex)
        {
            string subStr = key.Substring(startIndex, endIndex-startIndex);
            key = key.Replace(subStr, subStr.ToUpper());
            Console.WriteLine(key);
                return key;
        }

         static string FlipLower(string key, int startIndex, int endIndex)
        {
            string subStr = key.Substring(startIndex, endIndex - startIndex);
            key = key.Replace(subStr, subStr.ToLower());
            Console.WriteLine(key);
                return key;
        }

        private static string SliceKey(string key, int startIndex, int endIndex)
        {
            key = key.Remove(startIndex, endIndex-startIndex);
            Console.WriteLine(key);
                return key;
        }
    }
}