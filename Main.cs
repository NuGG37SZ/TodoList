using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Main : Form
    {
        private Dictionary<int, Task> Tasks = new Dictionary<int, Task>(); 

        public Main()
        {
            InitializeComponent();
        }

        private void CreateTask(object sender, EventArgs e)
        {
            int id = Tasks.Count + 1;

            Tasks.Add(id, new Task(NameTask.Text, Executor.Text, Convert.ToInt32(PriorityTask.Text),
                Convert.ToDateTime(TaskStartDate.Text)));
            
            MessageBox.Show("Задача создана");
        }

        public Dictionary<int, Task> GetTasks()
        {
            return Tasks;
        }

        private void AllTaskFormButton(object sender, EventArgs e)
        {
            AllTask form = new AllTask(this);
            this.Hide();
            form.Show();
        }
    }
}
