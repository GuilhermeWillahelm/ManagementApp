using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.Models;

namespace ManagementApp.Forms
{
    public partial class FormTasks : Form
    {
        TasksModel tasks = new TasksModel();
        public FormTasks()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string verify = "";
            if (!chkFg.Checked)
            {
                verify = "Em aberto!";
            }
            tasks.InsertTask(txtTask.Text, cmbUser.Text, Convert.ToDateTime(dateTask.Value.ToString("MM/dd/yyyy")), verify);
            MessageBox.Show(tasks.msg);
        }
    }
}
