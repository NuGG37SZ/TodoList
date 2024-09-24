using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Edit : Form
    {
        private Main MainForm = new Main();

        private Dictionary<int, Task> Tasks;

        public Edit(Main main, Dictionary<int, Task> tasks)
        {
            this.MainForm = main;
            Tasks = tasks;
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {       
            for(int i = 0; i < Tasks.Count; i++)
            {
                IdsTaskBox.Items.Add(i);
            }
        }

        private void EditTask(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(IdsTaskBox.Text);
            Task currentTask = Tasks[currentId];

            if (currentTask != null)
            {
                NameTask.Text = currentTask.Name;
                PriorityTask.Text = currentTask.Priority.ToString();
                Executor.Text = currentTask.ExecutorName;
                TaskStartDate.Text = currentTask.StartTaskDate.ToString();

                Task newTask = new Task(NameTask.Text, Executor.Text, Convert.ToInt32(PriorityTask.Text), 
                    Convert.ToDateTime(TaskStartDate.Text));
                Tasks[currentId] = newTask;
            }
        }



        private void GoMainFormButton(object sender, EventArgs e)
        {
            Main form = new Main();
            form.ShowDialog();
            this.Close();
        }

        private void IdsTaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(IdsTaskBox.Text);
            Task currentTask = Tasks[currentId + 1];

            if (currentTask != null)
            {
                NameTask.Text = currentTask.Name;
                PriorityTask.Text = currentTask.Priority.ToString();
                Executor.Text = currentTask.ExecutorName;
                TaskStartDate.Text = currentTask.StartTaskDate.ToString();
            }
        }
    }
}
