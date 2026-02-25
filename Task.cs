using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist
{
    public partial class Task : UserControl
    {
        public Taskdata data;
        public Task(string name, string source, DateOnly dueDate ,string[] tasks)
        {
            data = new Taskdata();
            InitializeComponent();
            lbl_taskname.Text = name;
            data.taskName = name;
            lbl_source.Text = source;
            data.taskSource = source;
            lbl_duedate.Text = dueDate.ToString();
            data.taskDueDate = dueDate;

            list_tasks.Items.Clear();

            bar_progress.Minimum = 0;

            data.taskParts = tasks;

            foreach (string part in data.taskParts)
            {
                list_tasks.Items.Add(part);
            }

            int diff = dueDate.DayNumber - DateOnly.FromDateTime(DateTime.Today).DayNumber;

            switch (diff)
            {

                case < 1:
                    bar_urgency.BackColor = Color.Crimson;
                    break;
                case < 3:
                    bar_urgency.BackColor = Color.Yellow;
                    break;
                case < 5:
                    bar_urgency.BackColor = Color.Green;
                    break;
            }
        }
        private void list_tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int totalcount = list_tasks.Items.Count;
            int donecount = list_tasks.CheckedItems.Count;
            bar_progress.Maximum = totalcount;

            bar_progress.Value = donecount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tasklist.form.DeleteTask(data.taskName);
            Tasklist.tasks.Remove(this);
            Tasklist.form.UpdateBoard();
            Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Tasklist.tasks.Remove(this);
            EditTask task = new EditTask(this);
            task.ShowDialog();
        }
    }

    public class Taskdata
    {
        public string taskName;
        public string taskSource;
        public DateOnly taskDueDate;
        public string[] taskParts;
    }
}
