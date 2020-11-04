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
            LoadTasks();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string verify = "";
            if (!chkStuacao.Checked)
            {
                verify = "Em aberto!";
            }
            tasks.InsertTask(txtTask.Text, cmbUser.Text, Convert.ToDateTime(dateTask.Value.ToString("MM/dd/yyyy")), verify);
            MessageBox.Show(tasks.msg);
            LoadTasks();
        }

        private void LoadTasks()
        {
            List<TasksModel> tasksModels = new List<TasksModel>();
            tasksModels = tasks.SelectTasks();

            //Clear List
            lstTasks.Items.Clear();

            //Inserir items na lista
            foreach (TasksModel tks in tasksModels)
            {
                ListViewItem item = new ListViewItem(tks.descTask.ToString());
                item.SubItems.Add(tks.funcTask);
                item.SubItems.Add(tks.dateTask.ToString());
                item.SubItems.Add(tks.situacao);
                lstTasks.Items.Add(item);
            }

        }
        
        private void chkFg_CheckedChanged(object sender, EventArgs e)
        {
            string st = "";
            if(chkStuacao.Checked)
            {
                st = "Finalizada";
            }

            tasks.UpdateTask(txtTask.Text, st);
            MessageBox.Show("Tarefa Finalizada!");
            LoadTasks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tasks.DeleteTask(txtTask.Text);
            MessageBox.Show(tasks.msg);
            LoadTasks();
        }
    }
}
