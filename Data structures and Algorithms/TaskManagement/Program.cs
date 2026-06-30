using System;

namespace TaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskLinkedList taskList = new TaskLinkedList();

            while (true)
            {
                Console.WriteLine("\n===== Task Management System =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Display Tasks");
                Console.WriteLine("3. Search Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Task ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Task Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Status: ");
                        string status = Console.ReadLine();

                        taskList.AddTask(new TaskItem(id, name, status));

                        Console.WriteLine("Task Added Successfully.");

                        break;

                    case 2:

                        taskList.DisplayTasks();

                        break;

                    case 3:

                        Console.Write("Enter Task ID: ");

                        taskList.SearchTask(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 4:

                        Console.Write("Enter Task ID: ");

                        taskList.DeleteTask(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 5:

                        Console.WriteLine("Thank You!");

                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");

                        break;
                }
            }
        }
    }
}