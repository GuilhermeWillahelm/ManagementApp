using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            LoadProducts();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            product.InsertProduct(int.Parse(txtCod.Text), txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));
            MessageBox.Show(product.msg);
        }

        private void LoadProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            products = product.SelectProducts();
            listProducts.Items.Clear();
            foreach (ProductModel p in products)
            {
                ListViewItem item = new ListViewItem(p.codProduct.ToString());
                item.SubItems.Add(p.nameProduct);
                item.SubItems.Add(p.brandProduct);
                item.SubItems.Add(p.priceProduct.ToString());
                item.SubItems.Add(p.quantityProduct.ToString());
                listProducts.Items.Add(item);
            }
        }
    }
}
