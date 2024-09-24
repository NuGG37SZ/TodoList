using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoList
{
    public partial class AllTask : Form
    {
        private Main MainForm;

        private Dictionary<int, Task> Tasks;

        public AllTask(Main main, Dictionary<int, Task> tasks)
        {
            this.MainForm = main;
            this.Tasks = tasks;
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            TaskGridView.DataSource = new BindingSource(Tasks, null);

            //TaskGridView.Columns.Remove("Key");
            //TaskGridView.Columns.Remove("Value");

            TaskGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Номер",
                Name = "id",
                ValueType = typeof(string)
            });

            TaskGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Название",
                Name = "name",
                ValueType = typeof(string)
            });

            TaskGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Исполнитель",
                Name = "executor",
                ValueType = typeof(string)
            });

            TaskGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Приоритет",
                Name = "priority",
                ValueType = typeof(string)
            });

            TaskGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Дата начала",
                Name = "datStartTask",
                ValueType = typeof(string)
            });

            for (int i = 0; i < Tasks.Count; i++)
            {
                Task currentTask = Tasks[i + 1];

                TaskGridView.Rows[i].Cells["id"].Value = i;
                TaskGridView.Rows[i].Cells["name"].Value = currentTask.Name;
                TaskGridView.Rows[i].Cells["executor"].Value = currentTask.ExecutorName;
                TaskGridView.Rows[i].Cells["priority"].Value = currentTask.Priority;
                TaskGridView.Rows[i].Cells["datStartTask"].Value = currentTask.StartTaskDate;
            }
        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.ShowDialog();
            this.Close();
        }
    }
}
