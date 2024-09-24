using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TodoList
{
    public partial class Edit : Form
    {
        private Main MainForm;

        private Dictionary<int, Task> Tasks;

        public Edit(Main main)
        {
            MainForm = main;
            Tasks = MainForm.GetTasks();
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {       
            for(int i = 0; i < Tasks.Count; i++)
            {
                IdsTaskBox.Items.Add(i + 1);
            }
        }

        private void EditTask(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(IdsTaskBox.Text);
            Task currentTask = Tasks[currentId];

            Task newTask = new Task(NameTask.Text, Executor.Text, Convert.ToInt32(PriorityTask.Text), 
                    Convert.ToDateTime(TaskStartDate.Text));
            Tasks[currentId] = newTask;

            MessageBox.Show("Задача была изменена!!!");
        }

        private void GoMainFormButton(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }

        private void IdsTaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(IdsTaskBox.Text);
            Task currentTask = Tasks[currentId];

            NameTask.Text = currentTask.Name;
            PriorityTask.Text = currentTask.Priority.ToString();
            Executor.Text = currentTask.ExecutorName;
            TaskStartDate.Text = currentTask.StartTaskDate.ToString();

        }
    }
}
