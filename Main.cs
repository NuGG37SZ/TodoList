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

        private void MainLoad(object sender, EventArgs e)
        {
            MessageBox.Show("Lorem " +
                "ipsum " +
                "dolor " +
                "sit " +
                "amet, " +
                "consectetuer " +
                "adipiscing " +
                "elit. " +
                "Aenean " +
                "commodo " +
                "ligula " +
                "eget " +
                "dolor. " +
                "Aenean " +
                "massa. " +
                "Cum " +
                "sociis " +
                "natoque " +
                "penatibus " +
                "et " +
                "magnis " +
                "dis " +
                "parturient " +
                "montes, " +
                "nascetur " +
                "ridiculus " +
                "mus. " +
                "Donec " +
                "quam " +
                "felis, " +
                "ultricies " +
                "nec, " +
                "pellentesque " +
                "eu, " +
                "pretium " +
                "quis, " +
                "sem. " +
                "Nulla " +
                "consequat" +
                "massa " +
                "quis " +
                "enim. " +
                "Donec " +
                "pede " +
                "justo, " +
                "fringilla " +
                "vel, " +
                "aliquet " +
                "nec, " +
                "vulputate " +
                "eget, " +
                "arcu. " +
                "In " +
                "enim " +
                "justo, " +
                "rhoncus " +
                "ut, " +
                "imperdiet" +
                " a, " +
                "venenatis" +
                " vitae, " +
                "justo. " +
                "Nullam " +
                "dictum " +
                "felis " +
                "eu " +
                "pede" +
                "mollis " +
                "pretium. " +
                "Integer " +
                "tincidunt. " +
                "Cras " +
                "dapibus. " +
                "Vivamus " +
                "elementum" +
                " semper " +
                "nisi. " +
                "Aenean " +
                "vulputate " +
                "eleifend " +
                "tellus. " +
                "Aenean " +
                "leo " +
                "ligula, " +
                "porttitor " +
                "eu, " +
                "consequat" +
                " vitae," +
                " eleifend" +
                " ac," +
                " enim." +
                " Aliquam" +
                " lorem" +
                " ante," +
                " dapibus" +
                " in," +
                " viverra " +
                "quis," +
                "feugiat" +
                " a," +
                " tellus." +
                " Phasellus" +
                " viverra" +
                " nulla " +
                "ut " +
                "metus" +
                "varius" +
                "laoreet." +
                "Quisque " +
                "rutrum." +
                " Aenean " +
                "imperdiet." +
                " Etiam " +
                "ultricies " +
                "nisi " +
                "vel " +
                "augue." +
                "Curabitur " +
                "ullamcorper " +
                "ultricies " +
                "nisi. " +
                "Nam " +
                "eget " +
                "dui. " +
                "Etiam " +
                "rhoncus." +
                "Maecenas " +
                "tempus, " +
                "tellus " +
                "eget " +
                "condimentum " +
                "rhoncus, " +
                "sem" +
                "quam " +
                "semper " +
                "libero, " +
                "sit " +
                "amet " +
                "adipiscing " +
                "sem " +
                "neque " +
                "sed" +
                "ipsum. " +
                "Nam " +
                "quam " +
                "nunc," +
                "blandit" +
                "vel, " +
                "luctus " +
                "pulvinar, " +
                "hendrerit " +
                "id, " +
                "lorem. " +
                "Maecenas " +
                "nec " +
                "odio " +
                "et " +
                "ante " +
                "tincidunt " +
                "tempus. " +
                "Donec " +
                "vitae" +
                " sapien" +
                " ut" +
                " libero " +
                "venenatis " +
                "faucibus. " +
                "Nullam " +
                "quis " +
                "ante. " +
                "Etiam " +
                "sit " +
                "amet " +
                "orci " +
                "eget " +
                "eros " +
                "faucibus " +
                "tincidunt." +
                " Duis leo." +
                " Sed " +
                "fringilla" +
                " mauris" +
                " sit " +
                "amet " +
                "nibh. " +
                "Donec" +
                " sodales" +
                " sagittis" +
                " magna." +
                " Sed" +
                " consequat," +
                " leo " +
                "eget " +
                "bibendum " +
                "sodales," +
                " augue " +
                "velit " +
                "cursus " +
                "nunc, " +
                "quis " +
                "gravida " +
                "magna " +
                "mi " +
                "a " +
                "libero." +
                " Fusce " +
                "vulputate " +
                "eleifend " +
                "sapien. " +
                "Vestibulum " +
                "purus " +
                "quam, " +
                "scelerisque " +
                "ut, " +
                "mollis " +
                "sed," +
                " nonummy " +
                "id," +
                " metus. " +
                "Nullam " +
                "accumsan " +
                "lorem " +
                "in " +
                "dui. " +
                "Cras " +
                "ultricies " +
                "mi " +
                "eu " +
                "turpis " +
                "hendrerit " +
                "fringilla. " +
                "Vestibulum " +
                "ante " +
                "ipsum " +
                "primis " +
                "in " +
                "faucibus " +
                "orci " +
                "luctus " +
                "et " +
                "ultrices" +
                " posuere" +
                " cubilia");

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

        private void EditForm(object sender, EventArgs e)
        {
            Edit form = new Edit(this);
            this.Hide();
            form.Show();
        }

        private void AllTaskFormButton(object sender, EventArgs e)
        {
            AllTask form = new AllTask(this);
            this.Hide();
            form.Show();
        }

        private void DeleteForm(object sender, EventArgs e)
        {
            Delete form = new Delete(this);
            this.Hide();
            form.Show();
        }
    }
}
