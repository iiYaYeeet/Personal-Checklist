namespace Checklist
{
    partial class MainForm
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
            panel1 = new FlowLayoutPanel();
            btn_newTask = new Button();
            monthCalendar1 = new MonthCalendar();
            btn_read = new Button();
            btn_write = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(7, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 496);
            panel1.TabIndex = 0;
            // 
            // btn_newTask
            // 
            btn_newTask.Location = new Point(497, 176);
            btn_newTask.Name = "btn_newTask";
            btn_newTask.Size = new Size(227, 64);
            btn_newTask.TabIndex = 1;
            btn_newTask.Text = "New Task";
            btn_newTask.UseVisualStyleBackColor = true;
            btn_newTask.Click += btn_newTask_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(497, 2);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(497, 319);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(227, 61);
            btn_read.TabIndex = 3;
            btn_read.Text = "FileRead";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_write
            // 
            btn_write.Location = new Point(497, 246);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(227, 67);
            btn_write.TabIndex = 4;
            btn_write.Text = "FileBackup";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 506);
            Controls.Add(btn_write);
            Controls.Add(btn_read);
            Controls.Add(monthCalendar1);
            Controls.Add(btn_newTask);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Checklist";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel1;
        private Button btn_newTask;
        private MonthCalendar monthCalendar1;
        private Button btn_read;
        private Button btn_write;
    }
}
