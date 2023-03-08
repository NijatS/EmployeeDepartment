using EmployeeDepartment.Models;

Department department = new Department("Department1");
bool status = true;
while (status)
{
    Console.WriteLine("\n1.Add Employee\n" +
        "2.Show Employees\n" +
        "q Quit");
    Console.Write("Please enter step Number : ");
    string step = Console.ReadLine();


    switch (step)
    {
        case "1":
            if (department.EmployeeCount == department.EmployeeLimit)
            {
                Console.WriteLine("Limite catdiniz!!!");
                break;
            }
            department.AddEmployee();
            Console.WriteLine("Added Employee");
            break;
        case "2":
            if (department.EmployeeCount == 0)
            {
                Console.WriteLine("Count of Employees is null.Please add Employee");
                break;
            }
            department.ShowEmployee();
            break;
        case "q":
            Console.WriteLine("Exiting....");
            status = false;
            break;
        default:
            break;
    }
}



