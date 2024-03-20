using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pharmacy.PharmacyDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy
{
    public partial class frmCashier : Form
    {
        private string word; // Переменная, в которой будет храниться переданное слово

        public frmCashier(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного слова в переменную word
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.getCashierSotr". При необходимости она может быть перемещена или удалена.
        //    this.getCashierSotrTableAdapter.Fill(this.pharmacyDataSet.getCashierSotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet._tableProduct". При необходимости она может быть перемещена или удалена.
            this.tableProductTableAdapter.Fill(this.pharmacyDataSet._tableProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.pharmacyDataSet.Sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

            txtOutput.Text = word; // Отображение переданного слова в txtOutput
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

        private void btnFindAnalog_Click(object sender, EventArgs e)
        {
            Form frm = new frmAnalogs();
            frm.Show();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            Form frm = new frmMedicament();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
            this.Hide();
        }

        private void ClearInsertSell(object sender, EventArgs e)
        {
            txtBarcodeSell.Text = "";
            numUD_count.Value = 1;
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

        private void btnSell_Click_1(object sender, EventArgs e)
        {
            if (txtBarcodeSell.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in txtBarcodeSell.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //проверка того, что в таблице Продукт такой товар существует
            sqlCommand_checkBarcode.Parameters["@barcode"].Value = txtBarcodeSell.Text;

            sqlConnection.Open();
            int count = (int)sqlCommand_checkBarcode.ExecuteScalar();
            sqlConnection.Close();

            if (count == 0)
            {
                MessageBox.Show("Такого товара не существует", "Оформление продажи",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtBarcode.Text = string.Empty;
                return;
            }

            sqlCommand_checkStock.Parameters["@barcode"].Value = txtBarcodeSell.Text;
            sqlConnection.Open();
            int availableQuantity = (int)sqlCommand_checkStock.ExecuteScalar();
            sqlConnection.Close();

            if (availableQuantity < Convert.ToInt32(numUD_count.Text))
            {
                MessageBox.Show("Выбранное количество товара больше, чем есть в наличии", "Оформление продажи",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sqlCommand_Sell.Parameters["@barcode"].Value = txtBarcodeSell.Text;
            sqlCommand_Sell.Parameters["@quantity"].Value = numUD_count.Text;
            sqlCommand_Sell.Parameters["@sotr"].Value = txtOutput.Text;

            sqlConnection.Open();
            sqlCommand_Sell.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Продажа оформлена", "Оформление продажи", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInsertSell(sender, e);

            RefreshProductTable();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tableProductBindingSource.Filter = "NameProduct Like '" + "%" + txtFind.Text
            + "%' OR Brand Like '%" + "%" + txtFind.Text + "%"
            + "%' OR NameCategory Like '%" + "%" + txtFind.Text + "%'";
        }
    }
}
