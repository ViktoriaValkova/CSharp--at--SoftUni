namespace P01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string locations = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] cmdArg = input.Split(':');

                switch (cmdArg[0])
                {
                    case "Add Stop":
                        locations = AddStop(locations,cmdArg);
                        break;
                    case "Remove Stop":
                        locations = RemoveStop(locations,cmdArg);
                        break;
                    case "Switch":
                        locations = SwitchStop(locations,cmdArg);
                        break;
                }

                Console.WriteLine(locations);
            }
        Console.WriteLine($"Ready for world tour! Planned stops: {locations}");
        }

         static string AddStop(string locations, string[] cmdArg)
        {
            int index = int.Parse(cmdArg[1]);
            string value = cmdArg[2];
            if (IsIndexValid(locations,index))
            {
                locations = locations.Insert(index,value);
            }
            return locations;
        }

         static bool IsIndexValid(string locations, int index)
        {
            return index >= 0 && index < locations.Length;
        }

         static string RemoveStop(string locations, string[] cmdArg)
        {
           int firstIndex = int.Parse(cmdArg[1]);
           int secondIndex = int.Parse(cmdArg[2]);
           if (IsIndexValid(locations, firstIndex) && IsIndexValid(locations, secondIndex))
           {
               locations= locations.Remove(firstIndex,secondIndex-firstIndex+1);
           }

           return locations;
        }

         static string SwitchStop(string? locations, string[] cmdArg)
         {
             string oldString = cmdArg[1];
             string newString = cmdArg[2];
             return locations = locations.Replace(oldString, newString);
         }
    }
}