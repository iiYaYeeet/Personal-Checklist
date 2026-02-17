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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(12, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 659);
            panel1.TabIndex = 0;
            // 
            // btn_newTask
            // 
            btn_newTask.Location = new Point(11, 11);
            btn_newTask.Name = "btn_newTask";
            btn_newTask.Size = new Size(176, 31);
            btn_newTask.TabIndex = 1;
            btn_newTask.Text = "New Task";
            btn_newTask.UseVisualStyleBackColor = true;
            btn_newTask.Click += btn_newTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 709);
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
    }
}
