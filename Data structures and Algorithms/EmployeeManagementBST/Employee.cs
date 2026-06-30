namespace EmployeeManagementBST
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, string department, double salary)
        {
            EmployeeId = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}