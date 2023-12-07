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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy
{
    public partial class frmSotr : Form
    {
        public frmSotr()
        {
            InitializeComponent();
        }

        private void frmSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.pharmacyDataSet.Sotr);
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFio.Text = "";
            txtPosition.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void btnAddSotr_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFio.Text) || string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                sqlCommand_addSotr.Parameters["@fio"].Value = txtFio.Text;
                sqlCommand_addSotr.Parameters["@position"].Value = txtPosition.Text;
                sqlCommand_addSotr.Parameters["@email"].Value = txtEmail.Text;
                sqlCommand_addSotr.Parameters["@phoneNum"].Value = txtPhone.Text;
                sqlConnection.Open();
                sqlCommand_addSotr.ExecuteNonQuery();
                sqlConnection.Close();
                ClearInsert(sender, e);
            }

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_allSotr.ExecuteReader());
            tblSotr.DataSource = temp;
            sqlConnection.Close();

            //    MessageBox.Show("Запрос на добавление новго сотрудника выполнен",
            // "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveSotr_Click(object sender, EventArgs e)
        {
            if (tblSotr.SelectedRows.Count > 0)
            {
                int selectedIndex = tblSotr.SelectedRows[0].Index;
                int idSotr = Convert.ToInt32(tblSotr[0, selectedIndex].Value);
                sqlConnection.Open();
                using (SqlCommand sqlCommand_remSotr = new SqlCommand("DELETE FROM Sotr WHERE idSotr = @idSotr", sqlConnection))
                {
                    sqlCommand_remSotr.Parameters.AddWithValue("@idSotr", idSotr);
                    sqlCommand_remSotr.ExecuteNonQuery();
                }
                sqlConnection.Close();
              //  MessageBox.Show("Сотрудник удалён", "Удаление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  sotrBindingSource.RemoveCurrent();
                
            }
            else
            {
                MessageBox.Show("Выберите сотрудника", "Удаление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             //  sotrBindingSource.RemoveCurrent();

             sqlConnection.Open();
             var temp = new DataTable();
             temp.Load(sqlCommand_allSotr.ExecuteReader());
             tblSotr.DataSource = temp;
             sqlConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void txtFio_TextChanged(object sender, EventArgs e) { }
    }
}
