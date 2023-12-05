namespace CapstoneProject
{
    public partial class TaskTrackerForm : Form
    {
        public TaskTrackerForm()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTaskForm().ShowDialog();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            new ViewAllForm().ShowDialog();
        }
    }
}