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
    public partial class frmWriteOff : Form
    {
        public frmWriteOff()
        {
            InitializeComponent();
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Списание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcode.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Списание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBarcode.Text = string.Empty; // Очистить поле ввода
                    break;
                }
            }

            sqlCommand_writeOff.Parameters["@Barcode"].Value = txtBarcode.Text;
            sqlCommand_writeOff.Parameters["@Quantity"].Value = numUD_count.Text;
            sqlCommand_writeOff.Parameters["@WhyDelete"].Value = txtWhy.Text;


                // открыть соединение с БД
                sqlConnection.Open();
                // выполнить sql-выражение (хранимую процедуру) и вернуть количество измененных записей
                sqlCommand_writeOff.ExecuteNonQuery();
                // закрыть соединение с БД
                sqlConnection.Close();
            
            // вывод результата через окно сообщения
            MessageBox.Show("Товар списан", "Списание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmWriteOff_Load(object sender, EventArgs e)
        {
            txtWhy.Text = "Истекает срок годности";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.Show();
            this.Hide();
        }
    }
}
