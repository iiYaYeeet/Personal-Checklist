namespace Checklist
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_taskname = new Label();
            lbl_source = new Label();
            bar_progress = new ProgressBar();
            list_tasks = new CheckedListBox();
            btn_complete = new Button();
            lbl_duedate = new Label();
            btn_edit = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lbl_taskname
            // 
            lbl_taskname.AutoSize = true;
            lbl_taskname.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_taskname.Location = new Point(10, 8);
            lbl_taskname.Name = "lbl_taskname";
            lbl_taskname.Size = new Size(62, 27);
            lbl_taskname.TabIndex = 0;
            lbl_taskname.Text = "Task";
            // 
            // lbl_source
            // 
            lbl_source.AutoSize = true;
            lbl_source.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_source.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_source.Location = new Point(535, 12);
            lbl_source.Name = "lbl_source";
            lbl_source.Size = new Size(68, 23);
            lbl_source.TabIndex = 1;
            lbl_source.Text = "Source";
            lbl_source.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bar_progress
            // 
            bar_progress.BackColor = SystemColors.Control;
            bar_progress.ForeColor = Color.Green;
            bar_progress.Location = new Point(3, 231);
            bar_progress.Margin = new Padding(3, 2, 3, 2);
            bar_progress.Name = "bar_progress";
            bar_progress.Size = new Size(652, 20);
            bar_progress.TabIndex = 2;
            // 
            // list_tasks
            // 
            list_tasks.FormattingEnabled = true;
            list_tasks.Location = new Point(3, 61);
            list_tasks.Margin = new Padding(3, 2, 3, 2);
            list_tasks.Name = "list_tasks";
            list_tasks.Size = new Size(652, 166);
            list_tasks.TabIndex = 3;
            list_tasks.SelectedIndexChanged += list_tasks_SelectedIndexChanged;
            // 
            // btn_complete
            // 
            btn_complete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_complete.Location = new Point(10, 260);
            btn_complete.Margin = new Padding(3, 2, 3, 2);
            btn_complete.Name = "btn_complete";
            btn_complete.Size = new Size(175, 34);
            btn_complete.TabIndex = 4;
            btn_complete.Text = "Complete Task";
            btn_complete.UseVisualStyleBackColor = true;
            btn_complete.Click += button1_Click;
            // 
            // lbl_duedate
            // 
            lbl_duedate.AutoSize = true;
            lbl_duedate.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_duedate.Location = new Point(286, 265);
            lbl_duedate.Name = "lbl_duedate";
            lbl_duedate.Size = new Size(63, 18);
            lbl_duedate.TabIndex = 5;
            lbl_duedate.Text = "dueDate";
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(480, 260);
            btn_edit.Margin = new Padding(3, 2, 3, 2);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(175, 34);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit Task";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 47);
            progressBar1.Maximum = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(654, 12);
            progressBar1.TabIndex = 7;
            progressBar1.Value = 1;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressBar1);
            Controls.Add(btn_edit);
            Controls.Add(lbl_duedate);
            Controls.Add(btn_complete);
            Controls.Add(list_tasks);
            Controls.Add(bar_progress);
            Controls.Add(lbl_source);
            Controls.Add(lbl_taskname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Task";
            Size = new Size(658, 296);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_taskname;
        private Label lbl_source;
        private ProgressBar bar_progress;
        private CheckedListBox list_tasks;
        private Button btn_complete;
        private Label lbl_duedate;
        private Button btn_edit;
        private ProgressBar progressBar1;
    }
}
