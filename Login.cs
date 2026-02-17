using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Checklist
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string login = SQLdata.Accessstring + $";Uid={username};Pwd={password};";
            try
            {
                await using var sqlconnection = new MySqlConnection(login);
                await sqlconnection.OpenAsync();

                SQLdata.Accessstring = login;

                Tasklist.form.ReadSQL();

                Debug.WriteLine("Login Succesful");
                Dispose();
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            username = txt_user.Text;
            Debug.WriteLine(username);
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            password = txt_password.Text;
            Debug.WriteLine(password);
        }
    }
}
