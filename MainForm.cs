using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using Newtonsoft.Json;

namespace Checklist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //init form
            InitializeComponent();
            Tasklist.form = this;
            //display login screen
            Login logins = new Login();
            logins.ShowDialog();
        }
        public void DeleteTask(string taskName)
        {
            Debug.WriteLine("Deleting Task");
            //new sql connection
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);

            sqlconnection.Open();

            //set cmd
            var command = new MySqlCommand("DELETE FROM tasklist WHERE task=@TaskName;", sqlconnection);

            command.Parameters.AddWithValue("@TaskName", taskName);

            //execute
            var returnsql = command.ExecuteNonQuery();

            Debug.WriteLine(returnsql.ToString());

            sqlconnection.Close();
        }

        public void ReadSQL()
        {
            //new sql connection
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);

            sqlconnection.Open();

            //set cmd
            var command = new MySqlCommand("SELECT * FROM tasklist;", sqlconnection);

            //execute
            var returnsql = command.ExecuteReader();

            //read returns
            while (returnsql.Read())
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
            //new connection
            Debug.WriteLine("Writing into db");
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);

            sqlconnection.Open();

            #region format
            //convert duedate
            DateOnly date = task_insert.data.taskDueDate;
            string formatted = date.ToString("yyyy-MM-dd");

            string compressedtasks = "";

            //compress tasks into 1 string
            foreach (string task in task_insert.data.taskParts)
            {
                compressedtasks += $"{task},";
            }
            #endregion

            //set command
            var command = new MySqlCommand("INSERT INTO tasklist " +
                "VALUES(@TaskName,@TaskSource,@DueDate,@Subtasks)", sqlconnection);

            //set params
            command.Parameters.AddWithValue("@TaskName", task_insert.data.taskName);
            command.Parameters.AddWithValue("@TaskSource", task_insert.data.taskSource);
            command.Parameters.AddWithValue("@DueDate", formatted);
            command.Parameters.AddWithValue("@Subtasks", compressedtasks);

            //push to db
            var returnsql = command.ExecuteNonQuery();

            Debug.WriteLine(returnsql.ToString());

            sqlconnection.Close();
        }

        public void UpdateSQL(Task task_update)
        {
            //new connection
            Debug.WriteLine("Writing into db");
            var sqlconnection = new MySqlConnection(SQLdata.Accessstring);

            sqlconnection.Open();

            #region format
            //convert duedate
            DateOnly date = task_update.data.taskDueDate;
            string formatted = date.ToString("yyyy-MM-dd");

            string compressedtasks = "";

            foreach (string task in task_update.data.taskParts)
            {
                compressedtasks += $"{task},";
            }
            #endregion

            //set command
            var command = new MySqlCommand("UPDATE tasklist " +
                "SET task = @TaskName, source = @TaskSource, duedate = @DueDate, subtasks = @Subtasks " +
                "WHERE task = @TaskName", sqlconnection);

            //set parameters
            command.Parameters.AddWithValue("@TaskName", task_update.data.taskName);
            command.Parameters.AddWithValue("@TaskSource", task_update.data.taskSource);
            command.Parameters.AddWithValue("@DueDate", formatted);
            command.Parameters.AddWithValue("@Subtasks", compressedtasks);

            //push
            var returnsql = command.ExecuteNonQuery();

            Debug.WriteLine(returnsql.ToString());

            sqlconnection.Close();
        }


        private void btn_newTask_Click(object sender, EventArgs e)
        {
            //display new task
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

        private void btn_write_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(SQLdata.filepath))
            {
                List<Taskdata> data = new List<Taskdata>();
                foreach (Task task in Tasklist.tasks)
                {
                    data.Add(task.data);
                }
                string tobewritten = JsonConvert.SerializeObject(data);
                sw.WriteLine(tobewritten);
                sw.Flush();
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(SQLdata.filepath))
            {
                string json = sr.ReadToEnd();
                List<Taskdata> tasks = JsonConvert.DeserializeObject<List<Taskdata>>(json);
                foreach (Taskdata data in tasks)
                {
                    Tasklist.tasks.Add(new Task(data.taskName, data.taskSource, data.taskDueDate, data.taskParts));
                }
                UpdateBoard();
            }
        }
    }

    public static class Tasklist
    {
        public static MainForm form;
        public static List<Task> tasks = new List<Task>();
    }
}
