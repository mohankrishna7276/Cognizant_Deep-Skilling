using System;

namespace EmployeeManagementBST
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBST tree = new EmployeeBST();

            tree.Insert(new Employee(105, "Mohan", "AI", 80000));
            tree.Insert(new Employee(101, "Rahul", "HR", 50000));
            tree.Insert(new Employee(110, "Priya", "Finance", 90000));
            tree.Insert(new Employee(103, "Anjali", "Testing", 60000));
            tree.Insert(new Employee(108, "Kiran", "Development", 85000));

            while (true)
            {
                Console.WriteLine("\n===== Employee Management =====");
                Console.WriteLine("1. Display Employees");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Exit");

                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        tree.Display();

                        break;

                    case 2:

                        Console.Write("Enter Employee ID : ");

                        int id = Convert.ToInt32(Console.ReadLine());

                        Employee employee = tree.Search(id);

                        if (employee != null)
                        {
                            Console.WriteLine("\nEmployee Found");
                            Console.WriteLine($"ID : {employee.EmployeeId}");
                            Console.WriteLine($"Name : {employee.Name}");
                            Console.WriteLine($"Department : {employee.Department}");
                            Console.WriteLine($"Salary : ₹{employee.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee Not Found");
                        }

                        break;

                    case 3:

                        return;
                }
            }
        }
    }
}