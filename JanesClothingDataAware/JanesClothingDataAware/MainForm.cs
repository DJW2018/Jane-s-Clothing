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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers editForm = new frmCustomers();
            editForm.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            frmProducts editForm = new frmProducts();
            editForm.Show();
        }
    }
}
