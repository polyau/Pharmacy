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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
   //         this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void categoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
       //     this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.pharmacyDataSet.Category);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length != 13) {
                MessageBox.Show("Введен некорректный штрихкод", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }

            foreach (char c in txtBarcode.Text) {
                if (!char.IsDigit(c)) {
                    MessageBox.Show("Введен некорректный штрихкод", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 //   txtBarcode.Text = string.Empty; // Очистить поле ввода
                    break;
                }
            }

            foreach (char c in txtPrice.Text) {
                if (!char.IsDigit(c)) {
                    MessageBox.Show("Введена некорректная цена", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Text = string.Empty; // Очистить поле ввода
                    break;
                }
            }

            if (string.IsNullOrEmpty(txtBarcode.Text) || string.IsNullOrEmpty(cbCategory.Text)
                || string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtNameProduct.Text)
                || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Введены не все требуемые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                // присвоить значения входным параметрам процедуры с преобразованием типов
                sqlCommand_addProduct.Parameters["@barcode"].Value = txtBarcode.Text;
                sqlCommand_addProduct.Parameters["@nameCategory"].Value = cbCategory.Text;
                sqlCommand_addProduct.Parameters["@brand"].Value = txtBrand.Text;
                sqlCommand_addProduct.Parameters["@nameProduct"].Value = txtNameProduct.Text;
                sqlCommand_addProduct.Parameters["@price"].Value = txtPrice.Text;
                sqlCommand_addProduct.Parameters["@minReserve"].Value = numUDMinReserve.Text;
                sqlCommand_addProduct.Parameters["@inStock"].Value = numUDInStock.Text;
                // открыть соединение с БД
                sqlConnection.Open();
                // выполнить sql-выражение (хранимую процедуру) и вернуть количество измененных записей
                sqlCommand_addProduct.ExecuteNonQuery();
                // закрыть соединение с БД
                sqlConnection.Close();

                // вывод результата через окно сообщения
                MessageBox.Show("Товар создан", "Создание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnAddMedicament_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddMedicament();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.Show();
            this.Hide();
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            cbCategory.Text = "";
            txtBrand.Text = "";
            txtNameProduct.Text = "";
            txtPrice.Text = "";
            numUDMinReserve.Value = 0;
            numUDInStock.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInsert(sender, e);
        }
    }
}
