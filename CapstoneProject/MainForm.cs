namespace CapstoneProject
{
    public partial class TaskTrackerForm : Form
    {
        private DatabaseConnectionFactory connectionFactory;
        public TaskTrackerForm(DatabaseConnectionFactory conn)
        {
            connectionFactory = conn;
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTaskForm(connectionFactory).ShowDialog();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            new ViewAllForm().ShowDialog();
        }
    }
}