using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
    internal class Department
    {
        public string Name;
        public readonly int EmployeeLimit = 2;
        public readonly int SalaryLimit = 250;
        public Employee[] employees = { };
        public int EmployeeCount = 0;

        public Department(string Name)
        {
            this.Name = Name;

        }
        public Employee[] AddEmployee()
        {

            Array.Resize(ref employees, EmployeeCount + 1);
            Console.Write("Please enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter SurName : ");
            string surname = Console.ReadLine();
            Console.Write("Please enter Salary : ");
            int salary = 0;
            try
            {
                 salary = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Salary must be digits");
            }
            while (!CheckName(name, surname) || !CheckSalary(salary))
            {
                Console.WriteLine("Again!!!");
                Console.Write("Please enter Name : ");
                name = Console.ReadLine();
                Console.Write("Please enter SurName : ");
                surname = Console.ReadLine();
                Console.Write("Please enter Salary : ");
                try
                {
                    salary = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Salary must be digits");
                }
            }
            employees[EmployeeCount] = new Employee(name, surname, salary);
            EmployeeCount++;

            return employees;
        }
        public void ShowEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name : " + employee.Name + " Surname : " + employee.Surname + " Salary : " + employee.Salary);
            }
        }
        bool CheckName(string name, string surname)
        {
            if (!char.IsUpper(name[0]) || !char.IsUpper(surname[0]))
            {
                return false;
            }
            if (!name.All(char.IsLetter) || !surname.All(char.IsLetter))
            {
                return false;
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)) { return false; }
            return true;
        }
        bool CheckSalary(int salary)
        {
            if (salary >= SalaryLimit)
            {
                return true;
            }
            return false;
        }
    }
}
