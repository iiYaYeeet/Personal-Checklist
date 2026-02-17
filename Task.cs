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
        public string taskName { get; set; } = "blank";
        public string taskSource { get; set; } = "blank";
        public DateOnly taskDueDate { get; set; }
        public string[] taskParts { get; set; }
        public Task(string name, string source, DateOnly dueDate ,string[] tasks)
        {
            InitializeComponent();
            lbl_taskname.Text = name;
            lbl_source.Text = source;
            lbl_duedate.Text = dueDate.ToString();
            taskDueDate = dueDate;

            list_tasks.Items.Clear();

            bar_progress.Minimum = 0;

            taskParts = tasks;

            foreach (string part in taskParts)
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
            Tasklist.tasks.Remove(this);
            Tasklist.form.UpdateBoard();
            Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
