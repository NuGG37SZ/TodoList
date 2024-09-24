using System;

namespace TodoList
{
    public class Task
    {
        public string Name { get; set; }
        public string ExecutorName { get; set; }
        public int Priority { get; set; }
        public DateTime StartTaskDate { get; set; }

        public Task(string name, string executorName, int priority, DateTime startTaskDate) {
            this.Name = name;
            this.ExecutorName = executorName;
            this.Priority = priority;
            this.StartTaskDate = startTaskDate;
        }
    }
}
