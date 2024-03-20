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
        private string word; // Переменная, в которой будет храниться переданное слово

        public frmSotr(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного слова в переменную word
        }

        private void frmSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.pharmacyDataSet.Sotr);
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFio.Text = "";
            cbPosition.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void btnAddSotr_Click(object sender, EventArgs e)
        {
            // проверка уникальности номера
            string query = "SELECT COUNT(*) FROM Sotr WHERE PhoneNum = @phoneNum";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@phoneNum", txtPhone.Text);

            sqlConnection.Open();
            int count = (int)command.ExecuteScalar(); // Получаем количество записей с введенным номером
            sqlConnection.Close();
            // Проверяем, было ли найдено совпадение
            if (count > 0)
            {
                MessageBox.Show("Данный номер телефона уже имеется в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFio.Text) || string.IsNullOrEmpty(cbPosition.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                sqlCommand_addSotr.Parameters["@fio"].Value = txtFio.Text;
                sqlCommand_addSotr.Parameters["@position"].Value = cbPosition.Text;
                sqlCommand_addSotr.Parameters["@email"].Value = txtEmail.Text;
                sqlCommand_addSotr.Parameters["@phoneNum"].Value = txtPhone.Text;
                sqlConnection.Open();
                sqlCommand_addSotr.ExecuteNonQuery();
                sqlConnection.Close();
                ClearInsert(sender, e);

                MessageBox.Show("Запрос на добавление новго сотрудника выполнен",
             "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_allSotr.ExecuteReader());
            tblSotr.DataSource = temp;
            sqlConnection.Close();
        }

        private void btnRemoveSotr_Click(object sender, EventArgs e)
        {
            if (tblSotr.SelectedRows.Count > 0)
            {
                int selectedIndex = tblSotr.SelectedRows[0].Index;
                int idSotr = Convert.ToInt32(tblSotr[0, selectedIndex].Value);
                sqlConnection.Open();
                using (SqlCommand sqlCommand_retireSotr 
                   = new SqlCommand("UPDATE Sotr SET Position = 'Уволен ' + Position WHERE idSotr = @idSotr;", sqlConnection))
                {
                    sqlCommand_retireSotr.Parameters.AddWithValue("@idSotr", idSotr);
                    sqlCommand_retireSotr.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }

            else
            {
                MessageBox.Show("Выберите сотрудника", "Увольнение сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

             sqlConnection.Open();
             var temp = new DataTable();
             temp.Load(sqlCommand_allSotr.ExecuteReader());
             tblSotr.DataSource = temp;
             sqlConnection.Close();
        }   

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmManager(word);
            frm.Show();
            this.Hide();
        }
    }
}
