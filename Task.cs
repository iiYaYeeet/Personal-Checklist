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
        public string taskDueDate { get; set; } = "blank";
        public List<string> taskParts { get; set; } = new List<string>();
        public Task(string name, string source, DateTime dueDate, List<string> tasks)
        {
            InitializeComponent();
            lbl_taskname.Text = name;
            lbl_source.Text = source;
            lbl_duedate.Text = dueDate.ToString();

            list_tasks.Items.Clear();

            bar_progress.Minimum = 0;

            taskParts = tasks;

            foreach (string part in taskParts)
            {
                list_tasks.Items.Add(part);
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
            Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
