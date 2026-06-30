namespace TaskManagement
{
    public class TaskNode
    {
        public TaskItem Data;

        public TaskNode Next;

        public TaskNode(TaskItem task)
        {
            Data = task;
            Next = null;
        }
    }
}