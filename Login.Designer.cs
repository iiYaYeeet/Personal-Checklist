namespace Checklist
{
    partial class Login
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
            txt_user = new TextBox();
            lbl_user = new Label();
            lbl_pass = new Label();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(128, 18);
            txt_user.Margin = new Padding(4);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(170, 29);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(9, 14);
            lbl_user.Margin = new Padding(4, 0, 4, 0);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(111, 30);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "Username:";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pass.Location = new Point(9, 68);
            lbl_pass.Margin = new Padding(4, 0, 4, 0);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(104, 30);
            lbl_pass.TabIndex = 3;
            lbl_pass.Text = "Password:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(128, 72);
            txt_password.Margin = new Padding(4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(170, 29);
            txt_password.TabIndex = 4;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(12, 119);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(280, 50);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 181);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_user);
            Controls.Add(txt_user);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user;
        private Label lbl_user;
        private Label lbl_pass;
        private TextBox txt_password;
        private Button btn_login;
    }
}