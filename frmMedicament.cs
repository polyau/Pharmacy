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
using System.Xml.Linq;

namespace Pharmacy
{
    public partial class frmMedicament : Form
    {
        public frmMedicament()
        {
            InitializeComponent();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Добавлние характеристик", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in txtBarcode.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Добавлние характеристик", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            //проверка того, что в таблице Продукт такой товар существует
            sqlCommand_checkBarcode.Parameters["@barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            int count = (int)sqlCommand_checkBarcode.ExecuteScalar();
            sqlConnection.Close();

            if (count == 0)
            {
                MessageBox.Show("Такого товара не существует", "Просмотр характеристик",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlCommand_medicament.Parameters["@barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand_medicament);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Характеристики для данного товара отсутствуют",
                    "Просмотр характеристик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
                return;
            }
            
            else
            {

                txtPharmGroup.Text = dt.Rows[0]["Фарм.группа"].ToString();
                txtExp.Text = dt.Rows[0]["Срок годности"].ToString();
                txtNotes.Text = dt.Rows[0]["Примечания"].ToString();
                txtEffect.Text = dt.Rows[0]["Эффект"].ToString();
                txtActiveSubstance.Text = dt.Rows[0]["Действующее вещество"].ToString();
                txtReleaseForm.Text = dt.Rows[0]["Форма выпуска"].ToString();
                txtDosage.Text = dt.Rows[0]["Дозировка"].ToString();
                txtQuantity.Text = dt.Rows[0]["Количество"].ToString();
                txtVolume.Text = dt.Rows[0]["Объем"].ToString();
                txtComposition.Text = dt.Rows[0]["Состав"].ToString();
                txtCountry.Text = dt.Rows[0]["Страна"].ToString();
                txtManufactur.Text = dt.Rows[0]["Производитель"].ToString();

                sqlConnection.Close();

                sqlCommand_getProductInfo.Parameters["@barcode"].Value = txtBarcode.Text;

                sqlConnection.Open();
                txtProductInfo.Text = sqlCommand_getProductInfo.ExecuteScalar().ToString();
                sqlConnection.Close();
            }
        }
    }
}
