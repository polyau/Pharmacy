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
        public frmCashier()
        {
            InitializeComponent();
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
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
            //    if (tblProduct.SelectedRows.Count == 1)
            //   {
            /*      int selectedIndex = tblProduct.SelectedRows[0].Index;
                  // Получаем значение Barcode из выделенной строки в DataGridView
                  string Barcode = tblProduct.CurrentRow.Cells["Barcode"].Value.ToString();

                      // Выполняем запрос к базе данных, используя функцию поиска аналогов
                      using (SqlConnection sqlConnection = new SqlConnection("sqlConnection"))
                      {
                          sqlConnection.Open();
                          SqlCommand sqlCommand_findAnalogs = new SqlCommand("SELECT * FROM dbo.findAnalogs(@Barcode)", sqlConnection);
                          sqlCommand_findAnalogs.Parameters.AddWithValue("@Barcode", Barcode);
                          SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand_findAnalogs);
                          DataTable analogsTable = new DataTable();
                          adapter.Fill(analogsTable);
                          sqlConnection.Close();

                          // Обновляем DataGridView новыми данными
                          tblAnalogs.DataSource = analogsTable;
                      }*/

            //    }

            /*   long selectedIndex = tblProduct.SelectedRows[0].Index;
               long Barcode = Convert.ToLong(tblProduct[0, selectedIndex].Value);
             //  string barcodeString = Barcode.ToString("D13");

               using (SqlConnection sqlConnection = new SqlConnection("sqlConnection"))
               {

                   sqlConnection.Open();
                   sqlCommand_findAnalogs.Parameters.AddWithValue("@Barcode", Barcode);
                   var temp = new DataTable();
                   temp.Load(sqlCommand_findAnalogs.ExecuteReader());
                   tblAnalogs.DataSource = temp;
                   sqlConnection.Close();
                   /*

                   /*   sqlConnection.Open();
                      SqlCommand sqlCommand_findAnalogs = new SqlCommand("SELECT * FROM dbo.findAnalogs()", sqlConnection);
                      sqlCommand_findAnalogs.Parameters.AddWithValue("@Barcode", Barcode);
                      SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand_findAnalogs);
                      DataTable analogsTable = new DataTable();
                      adapter.Fill(analogsTable);
                      tblAnalogs.DataSource = analogsTable;
                      sqlConnection.Close();
        }

        }
        else
        {
            MessageBox.Show("Выберите товар", "Подбор аналогов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

            /*   if (tblProduct.SelectedRows.Count == 1)
               {
                   sqlConnection.Open();
                   var temp = new DataTable();
                   temp.Load(sqlCommand_findAnalogs.ExecuteReader());
                   tblProduct.DataSource = temp;
                   sqlConnection.Close();
               }*/
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

        private void btn_removeFromCart_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            Form frm = new frmMedicament();
            frm.Show();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
            this.Hide();
        }
    }
}
