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
    public partial class frmSeeDeleteProduct : Form
    {
        private string word; // Переменная, в которой будет храниться переданное фио

        public frmSeeDeleteProduct(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного фио в переменную word
        }

        private void frmDeleteProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.deleteProductForWF". При необходимости она может быть перемещена или удалена.
            this.deleteProductForWFTableAdapter.Fill(this.pharmacyDataSet.deleteProductForWF);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            deleteProductForWFBindingSource.Filter = "Barcode Like '" + "%" + txtFind.Text
            + "%' OR Brand Like '%" + "%" + txtFind.Text + "%"
            + "%' OR NameProduct Like '%" + "%" + txtFind.Text + "%'";
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deleteProductForWFBindingSource.Filter = "";
            ClearInsert(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct(word);
            frm.Show();
            this.Hide();
        }
    }
}
