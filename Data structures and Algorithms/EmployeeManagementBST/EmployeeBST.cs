using System;

namespace EmployeeManagementBST
{
    public class EmployeeBST
    {
        private EmployeeNode root;

        public void Insert(Employee employee)
        {
            root = InsertRec(root, employee);
        }

        private EmployeeNode InsertRec(EmployeeNode root, Employee employee)
        {
            if (root == null)
                return new EmployeeNode(employee);

            if (employee.EmployeeId < root.Data.EmployeeId)
                root.Left = InsertRec(root.Left, employee);

            else if (employee.EmployeeId > root.Data.EmployeeId)
                root.Right = InsertRec(root.Right, employee);

            return root;
        }

        public Employee Search(int id)
        {
            return SearchRec(root, id);
        }

        private Employee SearchRec(EmployeeNode root, int id)
        {
            if (root == null)
                return null;

            if (root.Data.EmployeeId == id)
                return root.Data;

            if (id < root.Data.EmployeeId)
                return SearchRec(root.Left, id);

            return SearchRec(root.Right, id);
        }

        public void Display()
        {
            Console.WriteLine("\nEmployee List (Sorted)\n");
            InOrder(root);
        }

        private void InOrder(EmployeeNode root)
        {
            if (root == null)
                return;

            InOrder(root.Left);

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"ID : {root.Data.EmployeeId}");
            Console.WriteLine($"Name : {root.Data.Name}");
            Console.WriteLine($"Department : {root.Data.Department}");
            Console.WriteLine($"Salary : ₹{root.Data.Salary}");

            InOrder(root.Right);
        }
    }
}