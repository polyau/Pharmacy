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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.pharmacyDataSet.Category);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // присвоить значения входным параметрам процедуры с преобразованием типов
            sqlCommand_addProduct.Parameters["@barcode"].Value = txtBarcode.Text;
            sqlCommand_addProduct.Parameters["@codeСategory"].Value = numUDCodeCategory.Text;
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
}
