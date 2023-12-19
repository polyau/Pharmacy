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
    public partial class frmAddMedicament : Form
    {
        public frmAddMedicament()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // проверка уникальности штрихкода
            string query = "SELECT COUNT(*) FROM Medicament WHERE Barcode = @barcode";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@barcode", txtBarcode.Text);

            sqlConnection.Open();
            int kolvo = (int)command.ExecuteScalar(); // Получаем количество записей с введенным штрихкодом
            sqlConnection.Close();

            // Проверяем, было ли найдено совпадение
            if (kolvo > 0)
            {
                MessageBox.Show("Описание этого товара уже имеется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBarcode.Text.Length != 13)
            {
                MessageBox.Show("Введен некорректный штрихкод", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //     txtBarcode.Text = string.Empty; // Очистить поле ввода
                return;
            }
            foreach (char c in txtBarcode.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Введен некорректный штрихкод", "Добавлние товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   txtBarcode.Text = string.Empty; // Очистить поле ввода
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtBarcode.Text) || string.IsNullOrEmpty(txtPharmGroup.Text)
                || string.IsNullOrEmpty(cbExp.Text) || string.IsNullOrEmpty(txtActiveSubstance.Text)
                || string.IsNullOrEmpty(txtRealeseForm.Text) || string.IsNullOrEmpty(txtComposition.Text)
                || string.IsNullOrEmpty(txtManufactur.Text))
            {
                MessageBox.Show("Введены не все требуемые данные " +
                    "(проверьте заполнение следующих полей: Штрихкод, Фарм.группа, Срок годности, Действующее вещество, Форма выпуска, Состав, Производитель)", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //проверка того, что в таблице Продукт такой товар существует
                sqlCommand_checkBarcode.Parameters["@barcode"].Value = txtBarcode.Text;

                sqlConnection.Open();
                int count = (int)sqlCommand_checkBarcode.ExecuteScalar();
                sqlConnection.Close();

                if (count == 0)
                {
                    MessageBox.Show("Такого товара не существует", "Добавление характеристик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    txtBarcode.Text = string.Empty;
                    return;
                }

                else
                {
                    // присвоить значения входным параметрам процедуры с преобразованием типов
                    sqlCommand_addMedicament.Parameters["@barcode"].Value = txtBarcode.Text;
                    sqlCommand_addMedicament.Parameters["@pharmGroup"].Value = txtPharmGroup.Text;
                    sqlCommand_addMedicament.Parameters["@exp"].Value = cbExp.Text;
                    sqlCommand_addMedicament.Parameters["@notes"].Value = txtNotes.Text;
                    sqlCommand_addMedicament.Parameters["@effect"].Value = txtEffect.Text;
                    sqlCommand_addMedicament.Parameters["@activeSubstance"].Value = txtActiveSubstance.Text;
                    sqlCommand_addMedicament.Parameters["@releaseForm"].Value = txtRealeseForm.Text;
                    sqlCommand_addMedicament.Parameters["@dosage"].Value = txtDosage.Text;
                    sqlCommand_addMedicament.Parameters["@quantity"].Value = numUD_count.Text;
                    sqlCommand_addMedicament.Parameters["@volume"].Value = txtVolune.Text;
                    sqlCommand_addMedicament.Parameters["@composition"].Value = txtComposition.Text;
                    sqlCommand_addMedicament.Parameters["@country"].Value = txtCountry.Text;
                    sqlCommand_addMedicament.Parameters["@manufactur"].Value = txtManufactur.Text;
                    // открыть соединение с БД
                    sqlConnection.Open();
                    // выполнить sql-выражение (хранимую процедуру) и вернуть количество измененных записей
                    sqlCommand_addMedicament.ExecuteNonQuery();
                    // закрыть соединение с БД
                    sqlConnection.Close();

                    // вывод результата через окно сообщения
                    MessageBox.Show("Характеристики к товару добавлены", "Создание описания товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearInsert(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            txtPharmGroup.Text = "";
            cbExp.Text = "";
            txtNotes.Text = "";
            txtEffect.Text = "";
            txtActiveSubstance.Text = "";
            txtRealeseForm.Text = "";
            txtDosage.Text = "";
            numUD_count.Value = 0;
            txtVolune.Text = "";
            txtComposition.Text = "";
            txtCountry.Text = "";
            txtManufactur.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInsert(sender, e);
        }
    }
}
