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
    public partial class frmDirector : Form
    {
        public frmDirector()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.Show();
        }

        private void btnSotr_Click(object sender, EventArgs e)
        {
            Form frm = new frmSotr();
            frm.Show();
        }

        private void btnCassa_Click(object sender, EventArgs e)
        {
            Form frm = new frmCashier();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
        }
    }
}
