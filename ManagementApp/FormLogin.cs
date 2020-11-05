using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMainMenu form = new FormMainMenu(txtUser.Text);
            if (txtUser.Text == "Gui" && txtPass.Text == "123")
            {
                form.Show();
                this.Hide();

            }
        }
    }
}
