namespace Pharmacy
{
    partial class frmAddMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMedicament));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtEffect = new System.Windows.Forms.TextBox();
            this.txtActiveSubstance = new System.Windows.Forms.TextBox();
            this.txtRealeseForm = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtVolune = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtManufactur = new System.Windows.Forms.TextBox();
            this.txtPharmGroup = new System.Windows.Forms.TextBox();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_addMedicament = new System.Data.SqlClient.SqlCommand();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbExp = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.sqlCommand_checkBarcode = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(397, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные о препарате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Штрихкод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(50, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(50, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(50, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Состав";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(50, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Объём";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(50, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(50, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дозировка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(50, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Форма выпуска";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(50, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Действ.вещество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(50, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Действие";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(50, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Примечания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(50, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Срок годности";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(50, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Фарм.группа";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.Location = new System.Drawing.Point(286, 72);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(243, 30);
            this.txtBarcode.TabIndex = 14;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNotes.Location = new System.Drawing.Point(286, 205);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(851, 30);
            this.txtNotes.TabIndex = 20;
            this.txtNotes.Text = "Беречь от детей";
            // 
            // txtEffect
            // 
            this.txtEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEffect.Location = new System.Drawing.Point(286, 252);
            this.txtEffect.Name = "txtEffect";
            this.txtEffect.Size = new System.Drawing.Size(456, 30);
            this.txtEffect.TabIndex = 21;
            // 
            // txtActiveSubstance
            // 
            this.txtActiveSubstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtActiveSubstance.Location = new System.Drawing.Point(286, 297);
            this.txtActiveSubstance.Name = "txtActiveSubstance";
            this.txtActiveSubstance.Size = new System.Drawing.Size(456, 30);
            this.txtActiveSubstance.TabIndex = 22;
            // 
            // txtRealeseForm
            // 
            this.txtRealeseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRealeseForm.Location = new System.Drawing.Point(286, 342);
            this.txtRealeseForm.Name = "txtRealeseForm";
            this.txtRealeseForm.Size = new System.Drawing.Size(456, 30);
            this.txtRealeseForm.TabIndex = 23;
            // 
            // txtDosage
            // 
            this.txtDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDosage.Location = new System.Drawing.Point(286, 387);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(456, 30);
            this.txtDosage.TabIndex = 24;
            // 
            // txtVolune
            // 
            this.txtVolune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVolune.Location = new System.Drawing.Point(286, 477);
            this.txtVolune.Name = "txtVolune";
            this.txtVolune.Size = new System.Drawing.Size(243, 30);
            this.txtVolune.TabIndex = 25;
            // 
            // txtComposition
            // 
            this.txtComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComposition.Location = new System.Drawing.Point(286, 522);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(851, 30);
            this.txtComposition.TabIndex = 26;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.Location = new System.Drawing.Point(286, 567);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(243, 30);
            this.txtCountry.TabIndex = 27;
            // 
            // txtManufactur
            // 
            this.txtManufactur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtManufactur.Location = new System.Drawing.Point(286, 612);
            this.txtManufactur.Name = "txtManufactur";
            this.txtManufactur.Size = new System.Drawing.Size(456, 30);
            this.txtManufactur.TabIndex = 28;
            // 
            // txtPharmGroup
            // 
            this.txtPharmGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPharmGroup.Location = new System.Drawing.Point(286, 117);
            this.txtPharmGroup.Name = "txtPharmGroup";
            this.txtPharmGroup.Size = new System.Drawing.Size(243, 30);
            this.txtPharmGroup.TabIndex = 29;
            // 
            // numUD_count
            // 
            this.numUD_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_count.Location = new System.Drawing.Point(286, 433);
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Size = new System.Drawing.Size(78, 30);
            this.numUD_count.TabIndex = 30;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_addMedicament
            // 
            this.sqlCommand_addMedicament.CommandText = "addMedicament";
            this.sqlCommand_addMedicament.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_addMedicament.Connection = this.sqlConnection;
            this.sqlCommand_addMedicament.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13),
            new System.Data.SqlClient.SqlParameter("@pharmGroup", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@exp", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 150),
            new System.Data.SqlClient.SqlParameter("@effect", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@activeSubstance", System.Data.SqlDbType.VarChar, 70),
            new System.Data.SqlClient.SqlParameter("@releaseForm", System.Data.SqlDbType.VarChar, 80),
            new System.Data.SqlClient.SqlParameter("@dosage", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.TinyInt),
            new System.Data.SqlClient.SqlParameter("@volume", System.Data.SqlDbType.VarChar, 15),
            new System.Data.SqlClient.SqlParameter("@composition", System.Data.SqlDbType.VarChar, 400),
            new System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@manufactur", System.Data.SqlDbType.VarChar, 70)});
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(892, 585);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 43);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbExp
            // 
            this.cbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbExp.FormattingEnabled = true;
            this.cbExp.Items.AddRange(new object[] {
            "Более 12 месяцев",
            "От 6 до 12 месяцев",
            "Менее 6 месяцев"});
            this.cbExp.Location = new System.Drawing.Point(286, 162);
            this.cbExp.Name = "cbExp";
            this.cbExp.Size = new System.Drawing.Size(243, 33);
            this.cbExp.TabIndex = 32;
            this.cbExp.Text = "Более 12 месяцев";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1030, 585);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 42);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // sqlCommand_checkBarcode
            // 
            this.sqlCommand_checkBarcode.CommandText = "SELECT dbo.checkBarcode(@barcode)";
            this.sqlCommand_checkBarcode.Connection = this.sqlConnection;
            this.sqlCommand_checkBarcode.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // frmAddMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbExp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numUD_count);
            this.Controls.Add(this.txtPharmGroup);
            this.Controls.Add(this.txtManufactur);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.txtVolune);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.txtRealeseForm);
            this.Controls.Add(this.txtActiveSubstance);
            this.Controls.Add(this.txtEffect);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmAddMedicament";
            this.Text = "Добление характеристик";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtEffect;
        private System.Windows.Forms.TextBox txtActiveSubstance;
        private System.Windows.Forms.TextBox txtRealeseForm;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtVolune;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtManufactur;
        private System.Windows.Forms.TextBox txtPharmGroup;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_addMedicament;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.ComboBox cbExp;
        private System.Windows.Forms.Button btnClear;
        private System.Data.SqlClient.SqlCommand sqlCommand_checkBarcode;
    }
}