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
    public partial class frmAddPurveyor : Form
    {
        private string word; // Переменная, в которой будет храниться переданное слово

        public frmAddPurveyor(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного слова в переменную word
        }

        private void frmAddPurveyor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Purveyor". При необходимости она может быть перемещена или удалена.
            this.purveyorTableAdapter.Fill(this.pharmacyDataSet.Purveyor);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            purveyorBindingSource.Filter = "NamePurveyor Like '%" + txtFind.Text + "%' ";
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            purveyorBindingSource.Filter = "";
            ClearInsert(sender, e);
        }

        private void ClearInsert2(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPerson.Text = "";
            txtCountry.Text = "";
            txtSity.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtPay.Text = "";
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
         /*   // проверка уникальности номера
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
            } */

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPerson.Text) ||
                string.IsNullOrEmpty(txtCountry.Text) || string.IsNullOrEmpty(txtSity.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                sqlCommand_addPurveyor.Parameters["@namePurveyor"].Value = txtName.Text;
                sqlCommand_addPurveyor.Parameters["@contactPerson"].Value = txtPerson.Text;
                sqlCommand_addPurveyor.Parameters["@country"].Value = txtCountry.Text;
                sqlCommand_addPurveyor.Parameters["@sity"].Value = txtSity.Text;
                sqlCommand_addPurveyor.Parameters["@address"].Value = txtAddress.Text;
                sqlCommand_addPurveyor.Parameters["@phoneNum"].Value = txtPhone.Text;
                sqlCommand_addPurveyor.Parameters["@termsPay"].Value = txtPay.Text;

                sqlConnection.Open();
                sqlCommand_addPurveyor.ExecuteNonQuery();
                sqlConnection.Close();
                ClearInsert2(sender, e);

                MessageBox.Show("Запрос на добавление новго поставщика выполнен",
                "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_allPurv.ExecuteReader());
            tblPurveyor.DataSource = temp;
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
