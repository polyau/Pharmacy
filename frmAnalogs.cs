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
    public partial class frmAnalogs : Form
    {
        public frmAnalogs()
        {
            InitializeComponent();
        }

        private void btnAnalogs_Click(object sender, EventArgs e)
        {

            if (txtBarcode.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод");
                txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcode.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод");
                    txtBarcode.Text = string.Empty; // Очистить поле ввода
                    break;
                }
            }

            sqlCommand_findAnalogs.Parameters["@Barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_findAnalogs.ExecuteReader());
            tblAnalogs.DataSource = temp;
            sqlConnection.Close();

            sqlCommand_getProductInfo.Parameters["@barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            txtProductInfo.Text = sqlCommand_getProductInfo.ExecuteScalar().ToString();
            sqlConnection.Close();



        }
    }


    
}
