using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.getPurveyor". При необходимости она может быть перемещена или удалена.
            this.getPurveyorTableAdapter.Fill(this.pharmacyDataSet1.getPurveyor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.viewGetManagerSotr". При необходимости она может быть перемещена или удалена.
         //   this.viewGetManagerSotrTableAdapter.Fill(this.pharmacyDataSet1.viewGetManagerSotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1._tableProduct". При необходимости она может быть перемещена или удалена.
            this.tableProductTableAdapter.Fill(this.pharmacyDataSet1._tableProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

            txtOutput.Text = word; // Отображение переданного слова в txtOutput
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddProduct(word);
            frm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tableProductBindingSource.Filter = "Barcode Like '%" + txtFind.Text
            + "%' OR NameProduct Like '%" + txtFind.Text + "%'"
            + " OR Brand Like '%" + txtFind.Text + "%'"
            + " OR NameCategory Like '%" + txtFind.Text + "%'";
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

        private void RefreshProductTable()
        {
            tblProduct.DataSource = null; // Очищаем источник данных
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tableProduct", sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            tblProduct.DataSource = bs;

            // Повторное применение фильтра после обновления таблицы
            tableProductBindingSource = bs;
            tableProductBindingSource.Filter = "NameProduct Like '" + "%" + txtFind.Text
                + "%' OR Brand Like '%" + "%" + txtFind.Text + "%"
                + "%' OR NameCategory Like '%" + "%" + txtFind.Text + "%'";
        }

        private void ClearInsertPur(object sender, EventArgs e)
        {
            txtBarcodePur.Text = "";
            numUD_count.Value = 1;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtBarcodePur.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcodePur.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //     txtBarcode.Text = string.Empty;
                    break;
                }
            }

            sqlCommand_Purchase.Parameters["@barcode"].Value = txtBarcodePur.Text;
            sqlCommand_Purchase.Parameters["@quantity"].Value = numUD_count.Text;
            sqlCommand_Purchase.Parameters["@sotr"].Value = txtOutput.Text;
            sqlCommand_Purchase.Parameters["@purveyor"].Value = cbPurveyor.Text;

            sqlConnection.Open();
            sqlCommand_Purchase.ExecuteNonQuery(); ;
            sqlConnection.Close();

            MessageBox.Show("Поставка оформлена", "Оформление поставки", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInsertPur(sender, e);

            RefreshProductTable();
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            Form frm = new frmWriteOff(word);
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmSeeDeleteProduct(word);
            frm.Show();
            this.Hide();
        }

        private void btnSeeSell_Click(object sender, EventArgs e)
        {
            Form frm = new frmSeeSell(word);
            frm.Show();
            this.Hide();
        }

        private void btnSeePurchase_Click(object sender, EventArgs e)
        {
            Form frm = new frmSeePurchase(word);
            frm.Show();
            this.Hide();
        }
    }
}
