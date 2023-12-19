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
        private string word; // Переменная, в которой будет храниться переданное слово

        public frmProduct(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного слова в переменную word
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.viewGetManagerSotr". При необходимости она может быть перемещена или удалена.
            this.viewGetManagerSotrTableAdapter.Fill(this.pharmacyDataSet1.viewGetManagerSotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1._tableProduct". При необходимости она может быть перемещена или удалена.
            this.tableProductTableAdapter.Fill(this.pharmacyDataSet1._tableProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

            txtOutput.Text = word; // Отображение переданного слова в txtOutput
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddProduct();
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
            Form frm = new frmManager(word);
            frm.Show();
            this.Hide();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            Form frm = new frmWriteOff();
            frm.Show();
            this.Hide();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            Form frm = new frmMedicament();
            frm.Show();
        }

        private void btnAddPurveyor_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddPurveyor(word);
            frm.Show();
            this.Hide();
        }
    }
}
