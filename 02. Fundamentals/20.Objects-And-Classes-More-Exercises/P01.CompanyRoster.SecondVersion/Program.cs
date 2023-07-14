using System.ComponentModel.DataAnnotations;

namespace P01.SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Department> departmentList = new List<Department>();

            AddEmployees(count, departmentList);

            Console.WriteLine();
        }

        private static void AddEmployees(int count, List<Department> departmentList)
        {
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                double salary = double.Parse(info[1]);
                string departmentInfo = info[2];

                Employee currentEmployee = new Employee(name, salary);
                Department soughtDepartment = departmentList.FirstOrDefault(d => d.Name == departmentInfo);

                AddToCorrectDep(departmentList, soughtDepartment, departmentInfo, currentEmployee, salary);

            }

            PrintBestDep(departmentList);
        }

        private static void PrintBestDep(List<Department> departmentList)
        {
            Department bestDepartment = departmentList.OrderByDescending(d => d.SumSalary).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");
            foreach (Employee employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }

        private static void AddToCorrectDep(List<Department> departmentList, Department soughtDepartment, string departmentInfo, Employee currentEmployee,double salary)
        {
            if (soughtDepartment == null)
            {
                Department department = new Department(departmentInfo);
                department.Employees.Add(currentEmployee);
                department.AddToSalary(salary);
                departmentList.Add(department);
                
            }
            else
            {
                soughtDepartment.Employees.Add(currentEmployee);
                soughtDepartment.AddToSalary(salary);
            }
        }

        class Department
        {
            public Department(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
            public double SumSalary { get; set; }
            public List<Employee> Employees = new List<Employee>();
            public void AddToSalary(double salary)   // dont forget this method to add to sumSalary!
            {
                SumSalary += salary;
            }
        }

        class Employee
        {
            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public string Name { get; set; }
            public double Salary { get; set; }

        }
    }
}