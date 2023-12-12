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
    public partial class frmAuth : Form
    {
        byte EnterTry = 2;

        public frmAuth()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (EnterTry == 0) {
                btnEntry.Enabled = false;
                MessageBox.Show("У вас закончились попытки входа", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                sqlCommand_auth.Parameters["@fio"].Value = txtLogin.Text;
                sqlCommand_auth.Parameters["@phoneNum"].Value = txtPasswd.Text;

                sqlConnection.Open();
                sqlCommand_auth.ExecuteNonQuery();
                sqlConnection.Close();

                if (Convert.ToInt32(sqlCommand_auth.Parameters["@a"].Value) == 0) {
                    MessageBox.Show($"Повторите ввод, количество попыток: {EnterTry}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EnterTry--;
                    txtLogin.Clear();
                    txtPasswd.Clear();
                }

                else if (Convert.ToInt32(sqlCommand_auth.Parameters["@a"].Value) == 1) {
                    Form frm = new frmCashier();
                    frm.Show();
                    this.Hide();
                }

                else if (Convert.ToInt32(sqlCommand_auth.Parameters["@a"].Value) == 2) {
                    Form frm = new frmManager();
                    frm.Show();
                    this.Hide();
                }
                else if (Convert.ToInt32(sqlCommand_auth.Parameters["@a"].Value) == 3)
                {
                    Form frm = new frmDirector();
                    frm.Show();
                    this.Hide();
                }
            }

            catch
            {
                    MessageBox.Show($"Повторите ввод, количество попыток: {EnterTry}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EnterTry--;
                    txtLogin.Clear();
                    txtPasswd.Clear();
                    sqlCommand_auth.Parameters["@fio"].Value = 0;
                    sqlCommand_auth.Parameters["@phoneNum"].Value = 0;
                    sqlCommand_auth.Parameters["@a"].Value = 0;
                    sqlConnection.Close();
            }

     /*       if (txtLogin.Text == "менеджер" && txtPasswd.Text == "менеджер")
            {
                Form frm = new frmManager();
                frm.Show();
            }

            else if (txtLogin.Text == "первостольник" && txtPasswd.Text == "первостольник")
            {
                Form frm = new frmCashier();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Данные введены неверно. Повторите попытку", 
                    "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            txtPasswd.PasswordChar = '*'; // Установка символа замены для скрытия текста
        }
    }
}
