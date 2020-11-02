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
    public partial class FormProducts : Form
    {
        ProductModel product = new ProductModel();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            product.InsertProduct(int.Parse(txtCod.Text), txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));
            MessageBox.Show(product.msg);
        }
    }
}
