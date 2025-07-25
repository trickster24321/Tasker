namespace practiceapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            task_add = new Button();
            tasks = new CheckedListBox();
            taskbox = new TextBox();
            label1 = new Label();
            clearall = new Button();
            date = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // task_add
            // 
            task_add.Location = new Point(28, 334);
            task_add.Name = "task_add";
            task_add.Size = new Size(127, 23);
            task_add.TabIndex = 0;
            task_add.Text = "Add Task";
            task_add.UseVisualStyleBackColor = true;
            task_add.Click += button1_Click;
            // 
            // tasks
            // 
            tasks.FormattingEnabled = true;
            tasks.Location = new Point(28, 99);
            tasks.Name = "tasks";
            tasks.Size = new Size(572, 220);
            tasks.TabIndex = 1;
            tasks.SelectedIndexChanged += tasks_SelectedIndexChanged;
            // 
            // taskbox
            // 
            taskbox.Location = new Point(28, 41);
            taskbox.Name = "taskbox";
            taskbox.Size = new Size(221, 23);
            taskbox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter the Task you want to add";
            // 
            // clearall
            // 
            clearall.Location = new Point(469, 334);
            clearall.Name = "clearall";
            clearall.Size = new Size(131, 23);
            clearall.TabIndex = 5;
            clearall.Text = "Clear All Tasks";
            clearall.UseVisualStyleBackColor = true;
            clearall.Click += clearall_Click;
            // 
            // date
            // 
            date.Location = new Point(400, 38);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 20);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 7;
            label2.Text = "Select the Date for the task";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(label2);
            Controls.Add(date);
            Controls.Add(clearall);
            Controls.Add(label1);
            Controls.Add(taskbox);
            Controls.Add(tasks);
            Controls.Add(task_add);
            Name = "Form1";
            Text = "Tasker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button task_add;
        private CheckedListBox tasks;
        private TextBox taskbox;
        private Label label1;
        private Button clearall;
        private DateTimePicker date;
        private Label label2;
    }
}
