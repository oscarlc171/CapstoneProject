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
            var sql = "INSERT INTO Tasks (Name, Description, DueDate, DateCreated) VALUES ('School Assignment', 'Science project for Mrs. Jones class', '2024-01-23', GETDATE());";
        }
    }
}
