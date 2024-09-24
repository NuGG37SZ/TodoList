namespace TodoList
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Executor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriorityTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdsTaskBox = new System.Windows.Forms.ComboBox();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(234, 354);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(313, 32);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditTask);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(230, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата начала";
            // 
            // TaskStartDate
            // 
            this.TaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskStartDate.Location = new System.Drawing.Point(234, 298);
            this.TaskStartDate.Name = "TaskStartDate";
            this.TaskStartDate.Size = new System.Drawing.Size(314, 26);
            this.TaskStartDate.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(230, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Исполнитель";
            // 
            // Executor
            // 
            this.Executor.Location = new System.Drawing.Point(234, 244);
            this.Executor.Multiline = true;
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(314, 26);
            this.Executor.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(230, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Приоритет";
            // 
            // PriorityTask
            // 
            this.PriorityTask.Location = new System.Drawing.Point(234, 187);
            this.PriorityTask.Multiline = true;
            this.PriorityTask.Name = "PriorityTask";
            this.PriorityTask.Size = new System.Drawing.Size(314, 26);
            this.PriorityTask.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название";
            // 
            // NameTask
            // 
            this.NameTask.Location = new System.Drawing.Point(234, 132);
            this.NameTask.Multiline = true;
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(314, 26);
            this.NameTask.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Изменение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(230, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Номер задачи";
            // 
            // IdsTaskBox
            // 
            this.IdsTaskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdsTaskBox.FormattingEnabled = true;
            this.IdsTaskBox.Location = new System.Drawing.Point(234, 74);
            this.IdsTaskBox.Name = "IdsTaskBox";
            this.IdsTaskBox.Size = new System.Drawing.Size(317, 28);
            this.IdsTaskBox.TabIndex = 22;
            this.IdsTaskBox.SelectedIndexChanged += new System.EventHandler(this.IdsTaskBox_SelectedIndexChanged);
            // 
            // MainFormButton
            // 
            this.MainFormButton.Location = new System.Drawing.Point(281, 452);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(212, 49);
            this.MainFormButton.TabIndex = 23;
            this.MainFormButton.Text = "Назад";
            this.MainFormButton.UseVisualStyleBackColor = true;
            this.MainFormButton.Click += new System.EventHandler(this.GoMainFormButton);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainFormButton);
            this.Controls.Add(this.IdsTaskBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Executor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTask);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.LoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TaskStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Executor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriorityTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdsTaskBox;
        private System.Windows.Forms.Button MainFormButton;
    }
}