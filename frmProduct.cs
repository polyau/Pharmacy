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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddProduct();
            frm.Show();
        }
    }
}
