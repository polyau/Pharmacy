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
        private string word; // Переменная, в которой будет храниться переданное фио

        public frmWriteOff()
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного фио в переменную word
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
                  //  break
                    return;
                }
            }

            sqlCommand_checkBarcode.Parameters["@barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            int count = (int)sqlCommand_checkBarcode.ExecuteScalar();
            sqlConnection.Close();

            if (count == 0)
            {
                MessageBox.Show("Такого товара не существует", "Списание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtBarcode.Text = string.Empty;
                return;
            }

            else
            {
                sqlCommand_writeOff.Parameters["@Barcode"].Value = txtBarcode.Text;
                sqlCommand_writeOff.Parameters["@Quantity"].Value = numUD_count.Text;
                sqlCommand_writeOff.Parameters["@WhyDelete"].Value = txtWhy.Text;

                sqlConnection.Open();
                sqlCommand_writeOff.ExecuteNonQuery();
                sqlConnection.Close();

                sqlCommand_getProductInfo.Parameters["@barcode"].Value = txtBarcode.Text;

                sqlConnection.Open();
                txtProductInfo.Text = sqlCommand_getProductInfo.ExecuteScalar().ToString();
                sqlConnection.Close();

                MessageBox.Show("Товар списан", "Списание товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmWriteOff_Load(object sender, EventArgs e)
        {
            txtWhy.Text = "Истекает срок годности";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct(word);
            frm.Show();
            this.Hide();
        }
    }
}
