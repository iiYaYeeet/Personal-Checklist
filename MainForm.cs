namespace Checklist
{
    public partial class MainForm : Form
    {
        public List<Task> tasks;
        public MainForm()
        {
            InitializeComponent();
            Login logins = new Login();
            logins.Show();
        }

        private void btn_newTask_Click(object sender, EventArgs e)
        {
            
        }
    }
}
