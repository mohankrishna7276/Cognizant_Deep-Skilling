using System;

namespace TaskManagement
{
    public class TaskLinkedList
    {
        private TaskNode head;

        // Add Task
        public void AddTask(TaskItem task)
        {
            TaskNode newNode = new TaskNode(task);

            if (head == null)
            {
                head = newNode;
                return;
            }

            TaskNode current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // Display Tasks
        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No Tasks Available.");
                return;
            }

            TaskNode current = head;

            Console.WriteLine("\n------ Task List ------");

            while (current != null)
            {
                Console.WriteLine($"Task ID : {current.Data.TaskId}");
                Console.WriteLine($"Task Name : {current.Data.TaskName}");
                Console.WriteLine($"Status : {current.Data.Status}");
                Console.WriteLine("-------------------------");

                current = current.Next;
            }
        }

        // Search Task
        public void SearchTask(int id)
        {
            TaskNode current = head;

            while (current != null)
            {
                if (current.Data.TaskId == id)
                {
                    Console.WriteLine("\nTask Found");
                    Console.WriteLine($"Task ID : {current.Data.TaskId}");
                    Console.WriteLine($"Task Name : {current.Data.TaskName}");
                    Console.WriteLine($"Status : {current.Data.Status}");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Task Not Found.");
        }

        // Delete Task
        public void DeleteTask(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task List is Empty.");
                return;
            }

            if (head.Data.TaskId == id)
            {
                head = head.Next;
                Console.WriteLine("Task Deleted Successfully.");
                return;
            }

            TaskNode current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.TaskId == id)
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine("Task Deleted Successfully.");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Task Not Found.");
        }
    }
}