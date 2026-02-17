using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist
{
    public partial class NewTask : Form
    {
        public string task, source;
        public DateOnly duedate = DateOnly.FromDateTime(DateTime.Now);
        public string[] subtasks;
        public NewTask()
        {
            InitializeComponent();
        }

        private void txt_task_TextChanged(object sender, EventArgs e)
        {
            task = txt_task.Text;
        }

        private void txt_source_TextChanged(object sender, EventArgs e)
        {

            source = txt_source.Text;
        }

        private void txt_subtasks_TextChanged(object sender, EventArgs e)
        {
            subtasks = txt_subtasks.Lines;
        }

        private void dtp_duedate_ValueChanged(object sender, EventArgs e)
        {
            duedate = DateOnly.FromDateTime(dtp_duedate.Value);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Tasklist.tasks.Add(new Task(task,source,duedate,subtasks));
            Tasklist.form.InsertSQL(new Task(task, source, duedate, subtasks));
            Tasklist.form.UpdateBoard();
            Dispose();
        }
    }
}
