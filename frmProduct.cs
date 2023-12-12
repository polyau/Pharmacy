using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1._tableProduct". При необходимости она может быть перемещена или удалена.
            this.tableProductTableAdapter.Fill(this.pharmacyDataSet1._tableProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddProduct();
            frm.Show();
            this.Hide();
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            Form frm = new frmWriteOff();
            frm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tableProductBindingSource.Filter = "NameProduct Like '" + "%" + txtFind.Text 
            + "%' OR Brand Like '%" + "%" + txtFind.Text + "%" 
            + "%' OR NameCategory Like '%" + "%" + txtFind.Text + "%'";
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tableProductBindingSource.Filter = "";
            ClearInsert(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmManager();
            frm.Show();
            this.Hide();
        }
    }
}
