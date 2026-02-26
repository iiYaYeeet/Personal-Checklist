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
    public partial class EditTask : Form
    {
        public string task, source;
        public DateOnly duedate = DateOnly.FromDateTime(DateTime.Now);
        public string[] subtasks;
        public EditTask(Task tobeedited)
        {
            //init task
            InitializeComponent();
            #region setdata
            task = tobeedited.data.taskName;
            txt_task.Text = task;
            source = tobeedited.data.taskSource;
            txt_source.Text = source;
            duedate = tobeedited.data.taskDueDate;
            dtp_duedate.Value = duedate.ToDateTime(TimeOnly.MinValue);
            subtasks = tobeedited.data.taskParts;
            txt_subtasks.Lines = subtasks;
            #endregion
        }

        private void txt_task_TextChanged(object sender, EventArgs e)
        {
            //change task name
            task = txt_task.Text;
        }

        private void txt_source_TextChanged(object sender, EventArgs e)
        {
            //change task source
            source = txt_source.Text;
        }

        private void txt_subtasks_TextChanged(object sender, EventArgs e)
        {
            //change subtasks
            subtasks = txt_subtasks.Lines;
        }

        private void dtp_duedate_ValueChanged(object sender, EventArgs e)
        {
            //change duedate
            duedate = DateOnly.FromDateTime(dtp_duedate.Value);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //update task in list
            Task tbd = new Task(task, source, duedate, subtasks);
            Tasklist.tasks.Add(tbd);
            //push to db
            Tasklist.form.UpdateSQL(tbd);
            //push to board
            Tasklist.form.UpdateBoard();
            Dispose();
        }
    }
}
