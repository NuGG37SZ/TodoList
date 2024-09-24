using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Delete : Form
    {
        private Main MainForm;

        private Dictionary<int, Task> Tasks;

        public Delete(Main main)
        {
            this.MainForm = main;
            Tasks = MainForm.GetTasks();
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            for(int i = 0; i < Tasks.Count; i++)
            {
                IdsTask.Items.Add(i);
            }
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            Tasks.Remove(Convert.ToInt32(IdsTask.Text) + 1);
        }

        private void GoMainFormButton(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }
    }
}
