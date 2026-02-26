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
            //set file backup
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C://Documents//";
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SQLdata.filepath = ofd.FileName;
            }

            //set sql login data
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C://Documents//Checklist//";
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SQLdata.loginpath = ofd.FileName;
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            //attempt to read login file
            try
            {
                StreamReader rd = new StreamReader(SQLdata.loginpath);

                username = rd.ReadLine();
                password = rd.ReadLine();

                rd.Close();
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
            //run normal sql
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
            //update username
            username = txt_user.Text;
            //Debug.WriteLine(username);
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            //update password
            password = txt_password.Text;
            //Debug.WriteLine(password);
        }
    }
}
