﻿namespace TodoList
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriorityTask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Executor = new System.Windows.Forms.TextBox();
            this.TaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EditFormButton = new System.Windows.Forms.Button();
            this.AllTaskForm = new System.Windows.Forms.Button();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание";
            // 
            // NameTask
            // 
            this.NameTask.Location = new System.Drawing.Point(234, 88);
            this.NameTask.Multiline = true;
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(314, 26);
            this.NameTask.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(230, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Приоритет";
            // 
            // PriorityTask
            // 
            this.PriorityTask.Location = new System.Drawing.Point(234, 143);
            this.PriorityTask.Multiline = true;
            this.PriorityTask.Name = "PriorityTask";
            this.PriorityTask.Size = new System.Drawing.Size(314, 26);
            this.PriorityTask.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(230, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Исполнитель";
            // 
            // Executor
            // 
            this.Executor.Location = new System.Drawing.Point(234, 200);
            this.Executor.Multiline = true;
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(314, 26);
            this.Executor.TabIndex = 5;
            // 
            // TaskStartDate
            // 
            this.TaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskStartDate.Location = new System.Drawing.Point(234, 254);
            this.TaskStartDate.Name = "TaskStartDate";
            this.TaskStartDate.Size = new System.Drawing.Size(314, 26);
            this.TaskStartDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(230, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата начала";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(234, 310);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(313, 32);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateTask);
            // 
            // EditFormButton
            // 
            this.EditFormButton.Location = new System.Drawing.Point(171, 430);
            this.EditFormButton.Name = "EditFormButton";
            this.EditFormButton.Size = new System.Drawing.Size(133, 54);
            this.EditFormButton.TabIndex = 10;
            this.EditFormButton.Text = "Изменение";
            this.EditFormButton.UseVisualStyleBackColor = true;
            this.EditFormButton.Click += new System.EventHandler(this.EditForm);
            // 
            // AllTaskForm
            // 
            this.AllTaskForm.Location = new System.Drawing.Point(325, 430);
            this.AllTaskForm.Name = "AllTaskForm";
            this.AllTaskForm.Size = new System.Drawing.Size(133, 54);
            this.AllTaskForm.TabIndex = 11;
            this.AllTaskForm.Text = "Все задачи";
            this.AllTaskForm.UseVisualStyleBackColor = true;
            this.AllTaskForm.Click += new System.EventHandler(this.AllTaskFormButton);
            // 
            // DeleteTask
            // 
            this.DeleteTask.Location = new System.Drawing.Point(478, 430);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteTask.Size = new System.Drawing.Size(133, 54);
            this.DeleteTask.TabIndex = 12;
            this.DeleteTask.Text = "Удаление";
            this.DeleteTask.UseVisualStyleBackColor = true;
            this.DeleteTask.Click += new System.EventHandler(this.DeleteForm);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.AllTaskForm);
            this.Controls.Add(this.EditFormButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Executor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTask);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriorityTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Executor;
        private System.Windows.Forms.DateTimePicker TaskStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button EditFormButton;
        private System.Windows.Forms.Button AllTaskForm;
        private System.Windows.Forms.Button DeleteTask;
    }
}

