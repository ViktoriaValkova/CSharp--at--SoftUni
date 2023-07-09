namespace P07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeesByCompany = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] employeeInfo = input.Split(" -> ").ToArray();
                string companyName = employeeInfo[0];
                string employeeId = employeeInfo[1];
                if (!employeesByCompany.ContainsKey(companyName))
                {
                    employeesByCompany[companyName] = new List<string>();
                }
                if (!employeesByCompany[companyName].Contains(employeeId))
                {
                    employeesByCompany[companyName].Add(employeeId);
                }
            }

            foreach (var kvp in employeesByCompany)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"-- {string.Join("\n-- ",kvp.Value)}");
            }
        }
    }
}