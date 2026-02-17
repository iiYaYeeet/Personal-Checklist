namespace Checklist
{
    partial class NewTask
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
            txt_password = new TextBox();
            lbl_source = new Label();
            lbl_task = new Label();
            txt_user = new TextBox();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(98, 70);
            txt_password.Margin = new Padding(4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(170, 23);
            txt_password.TabIndex = 8;
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
            // txt_user
            // 
            txt_user.Location = new Point(74, 13);
            txt_user.Margin = new Padding(4);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(170, 23);
            txt_user.TabIndex = 5;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 350);
            Controls.Add(txt_password);
            Controls.Add(lbl_source);
            Controls.Add(lbl_task);
            Controls.Add(txt_user);
            Name = "NewTask";
            Text = "NewTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private Label lbl_source;
        private Label lbl_task;
        private TextBox txt_user;
    }
}