namespace Checklist
{
    partial class EditTask
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
            txt_source = new TextBox();
            lbl_source = new Label();
            lbl_task = new Label();
            txt_task = new TextBox();
            txt_subtasks = new TextBox();
            dtp_duedate = new DateTimePicker();
            label1 = new Label();
            Submit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_source
            // 
            txt_source.Location = new Point(98, 70);
            txt_source.Margin = new Padding(4);
            txt_source.Name = "txt_source";
            txt_source.Size = new Size(170, 23);
            txt_source.TabIndex = 8;
            txt_source.Text = "Blank";
            txt_source.TextChanged += txt_source_TextChanged;
            // 
            // lbl_source
            // 
            lbl_source.AutoSize = true;
            lbl_source.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_source.Location = new Point(9, 63);
            lbl_source.Margin = new Padding(4, 0, 4, 0);
            lbl_source.Name = "lbl_source";
            lbl_source.Size = new Size(81, 30);
            lbl_source.TabIndex = 7;
            lbl_source.Text = "Source:";
            // 
            // lbl_task
            // 
            lbl_task.AutoSize = true;
            lbl_task.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_task.Location = new Point(9, 9);
            lbl_task.Margin = new Padding(4, 0, 4, 0);
            lbl_task.Name = "lbl_task";
            lbl_task.Size = new Size(57, 30);
            lbl_task.TabIndex = 6;
            lbl_task.Text = "Task:";
            // 
            // txt_task
            // 
            txt_task.Location = new Point(98, 13);
            txt_task.Margin = new Padding(4);
            txt_task.Name = "txt_task";
            txt_task.Size = new Size(170, 23);
            txt_task.TabIndex = 5;
            txt_task.Text = "Blank";
            txt_task.TextChanged += txt_task_TextChanged;
            // 
            // txt_subtasks
            // 
            txt_subtasks.AcceptsReturn = true;
            txt_subtasks.Location = new Point(12, 199);
            txt_subtasks.Multiline = true;
            txt_subtasks.Name = "txt_subtasks";
            txt_subtasks.Size = new Size(254, 205);
            txt_subtasks.TabIndex = 9;
            txt_subtasks.Text = "Blank";
            txt_subtasks.TextChanged += txt_subtasks_TextChanged;
            // 
            // dtp_duedate
            // 
            dtp_duedate.ImeMode = ImeMode.NoControl;
            dtp_duedate.Location = new Point(68, 125);
            dtp_duedate.Name = "dtp_duedate";
            dtp_duedate.Size = new Size(200, 23);
            dtp_duedate.TabIndex = 10;
            dtp_duedate.ValueChanged += dtp_duedate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 11;
            label1.Text = "Due:";
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.Location = new Point(12, 410);
            Submit.Name = "Submit";
            Submit.Size = new Size(254, 91);
            Submit.TabIndex = 12;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 13;
            label2.Text = "Subtasks:";
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 513);
            Controls.Add(label2);
            Controls.Add(Submit);
            Controls.Add(label1);
            Controls.Add(dtp_duedate);
            Controls.Add(txt_subtasks);
            Controls.Add(txt_source);
            Controls.Add(lbl_source);
            Controls.Add(lbl_task);
            Controls.Add(txt_task);
            Name = "NewTask";
            Text = "NewTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Submit;
        private Label label1;
        private DateTimePicker dtp_duedate;
        private TextBox txt_subtasks;
        private TextBox txt_source;
        private Label lbl_source;
        private Label lbl_task;
        private TextBox txt_task;
    }
}