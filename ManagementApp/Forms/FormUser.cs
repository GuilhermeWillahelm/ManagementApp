using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.Models;

namespace ManagementApp.Forms
{
    public partial class FormUser : Form
    {
        UsersModel usersModel = new UsersModel();
        public FormUser()
        {
            InitializeComponent();
        }
        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = sha.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            string pass = Encrypt(txtPass.Text);
            string nivel = "";
            if (rdbAdm.Checked)
            {
                nivel = "Admin";
            }
            else if (rdbFunc.Checked)
            {
                nivel = "Funcionário";
            }
            usersModel.InsertUser(txtUser.Text, txtEmail.Text, pass, nivel);
            MessageBox.Show(usersModel.msg);
            
        }
    }
}
