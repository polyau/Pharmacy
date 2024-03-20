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
    public partial class frmSeePurchase : Form
    {
        private string word; // Переменная, в которой будет храниться переданное фио

        public frmSeePurchase(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного фио в переменную word
        }

        private void frmSeePurchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.viewPurchase". При необходимости она может быть перемещена или удалена.
            this.viewPurchaseTableAdapter.Fill(this.pharmacyDataSet1.viewPurchase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.viewPurchase". При необходимости она может быть перемещена или удалена.
            this.viewPurchaseTableAdapter.Fill(this.pharmacyDataSet.viewPurchase);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct(word);
            frm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            viewPurchaseBindingSource1.Filter = "NamePurveyor LIKE '%" + txtFind.Text + "%' " +
            "OR Fio LIKE '%" + txtFind.Text + "%' " +
            "OR Barcode LIKE '%" + txtFind.Text + "%' " +
            "OR Brand LIKE '%" + txtFind.Text + "%' " +
            "OR NameProduct LIKE '%" + txtFind.Text + "%'";
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            viewPurchaseBindingSource1.Filter = "";
            ClearInsert(sender, e);
        }
    }
}
