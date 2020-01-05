using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothingDataAware
{
    public partial class frmCustomersAdd : Form
    {
        public frmCustomersAdd()
        {
            InitializeComponent();
        }

        private void frmCustomersAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmMainForm mainForm = new frmMainForm();
            //mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomersAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.salesDataSet1.Categories);
            // TODO: This line of code loads data into the 'salesDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesDataSet.Customers);

        }
    }
}
