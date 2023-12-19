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
                MessageBox.Show("Введен некорректный штрихкод", "Добавлние характеристик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (char c in txtBarcode.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Добавлние характеристик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            sqlCommand_medicament.Parameters["@barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand_medicament);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Характеристики для данного товара отсутствуют, либо введен неверный штрихкод.", 
                    "Добавление характеристик", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
