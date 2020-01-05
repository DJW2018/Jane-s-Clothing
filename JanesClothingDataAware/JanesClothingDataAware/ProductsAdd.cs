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
    public partial class frmProductsAdd : Form
    {
        public frmProductsAdd()
        {
            InitializeComponent();
        }

        private void ProductsAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmMainForm mainForm = new frmMainForm();
            //mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductsAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet4.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.salesDataSet4.Brands);
            // TODO: This line of code loads data into the 'salesDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesDataSet2.Products);

        }
    }
}
