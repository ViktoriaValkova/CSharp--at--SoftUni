namespace P01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeCnt = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();
            for (int i = 0; i < employeeCnt; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                if (!departments.Any(d => d.Name == department))
                {
                    departments.Add((new Department(department)));
                }
                departments.Find(d => d.Name == department).AddEmployee(salary,name);
            }
            Department bestDepartment = departments.OrderByDescending(d => d.SumSalary).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");

            foreach (Employee employee in bestDepartment.Employees.OrderByDescending(emp => emp.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Department
    {
        public Department(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Employee> Employees = new List<Employee>();
        public decimal SumSalary { get; set; }

        public void AddEmployee(decimal salary, string name)
        {
            SumSalary += salary;
            Employees.Add(new Employee(name,salary));
        }
    }
}