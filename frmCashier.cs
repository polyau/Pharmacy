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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.pharmacyDataSet.Sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = "NameProduct Like '" + "%" + txtFind.Text + "%'";
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
        {/*
            private void button13_Click(object sender, EventArgs e)
            {
                try
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }
                    SqlCommand getIdtrash = new SqlCommand("select Top 1 id_заказа from СоставЗаказа order by id_заказа desc", connection);
                   
                    SqlCommand getIdorder = new SqlCommand("select Top 1 id_заказа from Заказ order by id_заказа desc", connection);
                   
                    SqlDataReader rdr, drd;
                    rdr = getIdtrash.ExecuteReader();
                    while (rdr.Read())
                    {
                        int totalOrders;
                        int.TryParse(rdr["id_заказа"].ToString(), out totalOrders);
                        orderInTrash = totalOrders;
                    }
                    rdr.Close();
                    drd = getIdorder.ExecuteReader();
                    while (drd.Read())
                    {
                        int totalOrders;
                        int.TryParse(drd["id_заказа"].ToString(), out totalOrders);
                        orderInOrder = totalOrders;
                    }
                    drd.Close();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("addOrder", sqlConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mode", "add");
                        cmd.Parameters.AddWithValue("@id_заказа", id_заказаTextBox.Text);
                        cmd.Parameters.AddWithValue("@id_препарата", id_препаратаtextBox4.Text);
                        cmd.Parameters.AddWithValue("@количество", количествоNumericUpDown.Value);
                        cmd.ExecuteNonQuery();
                        корзина_покупокDataGridView.DataSource = pharmacyDataSet.Корзина_покупок;
                        препаратTableAdapter.Fill(pharmacyDataSet.Product);
                        корзина_покупокTableAdapter.Fill(pharmacyDataSet.Корзина_покупок);
                        sumOrder();
                        label6.Visible = false;
                        if (id_препаратаtextBox4.Text != "")
                        {
                            MessageBox.Show("Препарат добавлен в корзину");
                        }
                        else
                        {
                            MessageBox.Show("Выберите товар!");
                        }
                        id_препаратаtextBox4.Text = "";
                        textBox5.Text = "";
                    }

                    catch
                    {
                        int indexRow = tblProduct.CurrentRow.Index;
                        for (int i = 0; i < tblProduct.Rows.Count; i++)
                        {
                            if
                           (Convert.ToInt32(tblProduct.Rows[indexRow].Cells["dataGridViewTextBoxColumn7"].Value) == 0)
                            {
                            MessageBox.Show("Препарат отсутствует");
                                return;
                            }
                            if
                           (Convert.ToInt32(tblProduct.Rows[indexRow].Cells["dataGridViewTextBoxColumn7"].Value) < количествоNumericUpDown.Value)
                            {
                                if (tblCart.Rows.Count == 0)
                                {
                                    tblCart.DataSource = null;
                                }
                                MessageBox.Show("В аптеке отсутствует такое количество препаратов");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("В заказе уже есть такой препарат");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
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
    }
}
