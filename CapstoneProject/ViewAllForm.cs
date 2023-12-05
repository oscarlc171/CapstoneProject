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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
        }

        private void addTaskButton2_Click(object sender, EventArgs e)
        {
            new AddTaskForm().ShowDialog();
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {

        }
    }
}
