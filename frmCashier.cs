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
            this.getCashierSotrTableAdapter.Fill(this.pharmacyDataSet.getCashierSotr);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            tableProductBindingSource.Filter = "NameProduct Like '" + "%" + txtFind.Text
            + "%' OR Brand Like '%" + "%" + txtFind.Text + "%"
            + "%' OR NameCategory Like '%" + "%" + txtFind.Text + "%'";
        }

        private void btnFindAnalog_Click(object sender, EventArgs e)
        {
            Form frm = new frmAnalogs();
            frm.Show();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            /* // Получаем выделенную строку из DataGridView с товарами
             DataGridViewRow selectedRow = tblProduct.SelectedRows[0];

             // Получаем данные о товаре
             string barcode = selectedRow.Cells["Barcode"].Value.ToString();
             string name = selectedRow.Cells["NameProduct"].Value.ToString();
             decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

             // Добавляем товар в корзину (второй DataGridView)
             tblCart.Rows.Add(barcode, name, price);*/

            try
            {
                tableProductBindingSource.MoveFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            Form frm = new frmMedicament();
            frm.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
           /* if (txtBarcodeSell.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //   txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcodeSell.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод");
                    //     txtBarcode.Text = string.Empty;
                    break;
                }
            }

            sqlCommand_Sell.Parameters["@barcode"].Value = txtBarcodeSell.Text;
            sqlCommand_Sell.Parameters["@quantity"].Value = numUD_count.Text;
            sqlCommand_Sell.Parameters["@sotr"].Value = cbCashier.Text;

            sqlConnection.Open();
            sqlCommand_Sell.ExecuteNonQuery(); ;
            sqlConnection.Close();

            */

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
            this.Hide();
        }

        private void txtCashier_TextChanged(object sender, EventArgs e)
        {
       //     txtCashier.Text = frmAuth.txtLogin;
        }

        private void ClearInsertSell(object sender, EventArgs e)
        {
            txtBarcodeSell.Text = "";
            numUD_count.Value = 1;
        }

        private void btnSell_Click_1(object sender, EventArgs e)
        {
            if (txtBarcodeSell.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //   txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcodeSell.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Оформление продажи", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //     txtBarcode.Text = string.Empty;
                    break;
                }
            }

            sqlCommand_Sell.Parameters["@barcode"].Value = txtBarcodeSell.Text;
            sqlCommand_Sell.Parameters["@quantity"].Value = numUD_count.Text;
            sqlCommand_Sell.Parameters["@sotr"].Value = txtOutput.Text;

            sqlConnection.Open();
            sqlCommand_Sell.ExecuteNonQuery(); ;
            sqlConnection.Close();

            MessageBox.Show("Продажа оформлена", "Оформление продажи", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInsertSell(sender, e);
        }
    }
}
