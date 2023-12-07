using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class AddTaskForm : Form
    {

        private readonly DatabaseConnectionFactory _connectionFactory;
        public AddTaskForm(DatabaseConnectionFactory Conn) : this ()
        {
            _connectionFactory = Conn;
        }
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTaskButton3_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Name = taskNameTextBox.Text;
            task.Description = descriptionTextBox.Text;
            task.DueDate = dueDateCalendar.SelectionStart;
            AddTask(task);
        }

        public int AddTask(Task task)
        {
            var sql = "INSERT INTO Tasks (Name, Description, DueDate, DateCreated) VALUES (@Name, @Description, @DueDate, GETDATE());";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, task);
                return result;
            }
        }

        public Task RemoveTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
