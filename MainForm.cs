using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using MySqlConnector;

namespace Checklist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Tasklist.form = this;
            Login logins = new Login();
            logins.ShowDialog();
        }

        public void ReadSQL()
        {
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);
            
            sqlconnection.Open();

            var command = new MySqlCommand("SELECT * FROM tasklist;", sqlconnection);

            var returnsql = command.ExecuteReader();

            while(returnsql.Read())
            {
            Debug.WriteLine(returnsql.GetString("task"));
            Debug.WriteLine(returnsql.GetString("source"));
            Debug.WriteLine(returnsql.GetDateOnly("duedate"));
                Tasklist.tasks.Add(new Task(returnsql.GetString("task"), returnsql.GetString("source"), returnsql.GetDateOnly("duedate"), returnsql.GetString("subtasks").Split(",")));
            }
            UpdateBoard();
            sqlconnection.Close();
        }

        public void InsertSQL(Task task_insert)
        {
            Debug.WriteLine("Writing into db");
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);

            sqlconnection.Open();

            DateOnly date = task_insert.taskDueDate;
            string formatted = date.ToString("yyyy-MM-dd");

            string compressedtasks = "";

            foreach (string task in task_insert.taskParts)
            {
                compressedtasks += $"{task},";
            }

            var command = new MySqlCommand("INSERT INTO tasklist VALUES(@TaskName,@TaskSource,@DueDate,@Subtasks)", sqlconnection);

            command.Parameters.AddWithValue("@TaskName", task_insert.taskName);
            command.Parameters.AddWithValue("@TaskSource", task_insert.taskSource);
            command.Parameters.AddWithValue("@DueDate", formatted);
            command.Parameters.AddWithValue("@Subtasks", compressedtasks);

            var returnsql = command.ExecuteNonQuery();

            Debug.WriteLine(returnsql.ToString());

            sqlconnection.Close();
        }


        private void btn_newTask_Click(object sender, EventArgs e)
        {
            NewTask task = new NewTask();
            task.ShowDialog();
        }

        public void UpdateBoard()
        {
            panel1.Controls.Clear();
            foreach (Task task in Tasklist.tasks)
            {
                panel1.Controls.Add(task);
            }
        }
    }

    public static class Tasklist
    {
        public static MainForm form;
        public static List<Task> tasks = new List<Task>();
    }
}
