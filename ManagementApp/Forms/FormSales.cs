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
    public partial class FormSales : Form
    {
        SalesModel sales = new SalesModel();
        public FormSales()
        {
            InitializeComponent();
            LoadSales();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            sales.InsertSale(txtDesc.Text, int.Parse(txtQuantitySales.Text), double.Parse(txtValueSales.Text), DateTime.Parse(dtmDate.Value.ToString("MM/dd/yyyy")));
            MessageBox.Show(sales.msg);
            LoadSales();
        }

        public void LoadSales()
        {
            List<SalesModel> lstSales = new List<SalesModel>();
            lstSales = sales.SelectSales();

            listSales.Items.Clear();

            foreach (SalesModel sl in lstSales)
            {
                ListViewItem item = new ListViewItem(sl.descSale.ToString());
                item.SubItems.Add(sl.quantitySale.ToString());
                item.SubItems.Add(sl.valueSale.ToString());
                item.SubItems.Add(sl.dateSale.ToString());
                listSales.Items.Add(item);
            }
        }
    }
}
