using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoList
{
    public partial class AllTask : Form
    {
        private Main MainForm;

        private Dictionary<int, Task> Tasks;

        public AllTask(Main main)
        {
            this.MainForm = main;
            Tasks = MainForm.GetTasks();
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            TaskGridView.DataSource = new BindingSource(Tasks, null);

            TaskGridView.Columns.Remove("Key");
            TaskGridView.Columns.Remove("Value");

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

            int rowIndex = 0;
            foreach (var pair in Tasks)
            {
                int key = pair.Key;
                Task currentTask = pair.Value;

                TaskGridView.Rows[rowIndex].Cells["id"].Value = key;
                TaskGridView.Rows[rowIndex].Cells["name"].Value = currentTask.Name;
                TaskGridView.Rows[rowIndex].Cells["executor"].Value = currentTask.ExecutorName;
                TaskGridView.Rows[rowIndex].Cells["priority"].Value = currentTask.Priority;
                TaskGridView.Rows[rowIndex].Cells["datStartTask"].Value = currentTask.StartTaskDate;

                rowIndex++;
            }
        }

        private void MainFormButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }
    }
}
