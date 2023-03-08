using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
    internal class Employee
    {
        private int _salary;
        public string Name;
        public string Surname;
        public int Salary
        {
            get => _salary; set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string Name, string Surname, int Salary)
        {
            
                this.Name = Name;
                this.Surname = Surname;
                this.Salary = Salary;
            
        }
        
    }


}
