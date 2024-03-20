namespace Pharmacy
{
    partial class frmMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicament));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_medicament = new System.Data.SqlClient.SqlCommand();
            this.txtPharmGroup = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtManufactur = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtReleaseForm = new System.Windows.Forms.TextBox();
            this.txtActiveSubstance = new System.Windows.Forms.TextBox();
            this.txtEffect = new System.Windows.Forms.TextBox();
            this.txtProductInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sqlCommand_getProductInfo = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand_checkBarcode = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите штрихкод медикамента, у которого требуется посмотреть характеристики";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.Location = new System.Drawing.Point(426, 82);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(156, 30);
            this.txtBarcode.TabIndex = 2;
            // 
            // btnMedicament
            // 
            this.btnMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedicament.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicament.Location = new System.Drawing.Point(588, 78);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(120, 38);
            this.btnMedicament.TabIndex = 3;
            this.btnMedicament.Text = "смотреть";
            this.btnMedicament.UseVisualStyleBackColor = false;
            this.btnMedicament.Click += new System.EventHandler(this.btnMedicament_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_medicament
            // 
            this.sqlCommand_medicament.CommandText = "SELECT * FROM dbo.seeDescriptionOfMedicament(@barcode)";
            this.sqlCommand_medicament.Connection = this.sqlConnection;
            this.sqlCommand_medicament.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // txtPharmGroup
            // 
            this.txtPharmGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPharmGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPharmGroup.Location = new System.Drawing.Point(219, 205);
            this.txtPharmGroup.Name = "txtPharmGroup";
            this.txtPharmGroup.Size = new System.Drawing.Size(250, 30);
            this.txtPharmGroup.TabIndex = 5;
            // 
            // txtExp
            // 
            this.txtExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExp.Location = new System.Drawing.Point(219, 241);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(250, 30);
            this.txtExp.TabIndex = 6;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNotes.Location = new System.Drawing.Point(219, 277);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(950, 30);
            this.txtNotes.TabIndex = 7;
            // 
            // txtManufactur
            // 
            this.txtManufactur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtManufactur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtManufactur.Location = new System.Drawing.Point(219, 601);
            this.txtManufactur.Name = "txtManufactur";
            this.txtManufactur.Size = new System.Drawing.Size(460, 30);
            this.txtManufactur.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.Location = new System.Drawing.Point(219, 565);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 30);
            this.txtCountry.TabIndex = 9;
            // 
            // txtComposition
            // 
            this.txtComposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComposition.Location = new System.Drawing.Point(219, 529);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(950, 30);
            this.txtComposition.TabIndex = 10;
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVolume.Location = new System.Drawing.Point(219, 493);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(250, 30);
            this.txtVolume.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.Location = new System.Drawing.Point(219, 457);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(460, 30);
            this.txtQuantity.TabIndex = 12;
            // 
            // txtDosage
            // 
            this.txtDosage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDosage.Location = new System.Drawing.Point(219, 421);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(460, 30);
            this.txtDosage.TabIndex = 13;
            // 
            // txtReleaseForm
            // 
            this.txtReleaseForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReleaseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtReleaseForm.Location = new System.Drawing.Point(219, 385);
            this.txtReleaseForm.Name = "txtReleaseForm";
            this.txtReleaseForm.Size = new System.Drawing.Size(460, 30);
            this.txtReleaseForm.TabIndex = 14;
            // 
            // txtActiveSubstance
            // 
            this.txtActiveSubstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActiveSubstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtActiveSubstance.Location = new System.Drawing.Point(219, 349);
            this.txtActiveSubstance.Name = "txtActiveSubstance";
            this.txtActiveSubstance.Size = new System.Drawing.Size(460, 30);
            this.txtActiveSubstance.TabIndex = 15;
            // 
            // txtEffect
            // 
            this.txtEffect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEffect.Location = new System.Drawing.Point(219, 313);
            this.txtEffect.Name = "txtEffect";
            this.txtEffect.Size = new System.Drawing.Size(460, 30);
            this.txtEffect.TabIndex = 16;
            // 
            // txtProductInfo
            // 
            this.txtProductInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductInfo.Location = new System.Drawing.Point(196, 143);
            this.txtProductInfo.Name = "txtProductInfo";
            this.txtProductInfo.Size = new System.Drawing.Size(973, 30);
            this.txtProductInfo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Искомый товар:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(26, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Фарм.группа";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(26, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Срок годности";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(24, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Примечания";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(26, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Действие";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(25, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Действ.вещество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(26, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Форма выпуска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(25, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Дозировка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(25, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(26, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Объём";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(26, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Состав";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(25, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Страна";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(25, 604);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Производитель";
            // 
            // sqlCommand_getProductInfo
            // 
            this.sqlCommand_getProductInfo.CommandText = "SELECT dbo.getProductInfo(@barcode)";
            this.sqlCommand_getProductInfo.Connection = this.sqlConnection;
            this.sqlCommand_getProductInfo.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // sqlCommand_checkBarcode
            // 
            this.sqlCommand_checkBarcode.CommandText = "SELECT dbo.checkBarcode(@barcode)";
            this.sqlCommand_checkBarcode.Connection = this.sqlConnection;
            this.sqlCommand_checkBarcode.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // frmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
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
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProductInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEffect);
            this.Controls.Add(this.txtActiveSubstance);
            this.Controls.Add(this.txtReleaseForm);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtManufactur);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtPharmGroup);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmMedicament";
            this.Text = "Характеристики препарата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnMedicament;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_medicament;
        private System.Windows.Forms.TextBox txtPharmGroup;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtManufactur;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtReleaseForm;
        private System.Windows.Forms.TextBox txtActiveSubstance;
        private System.Windows.Forms.TextBox txtEffect;
        private System.Windows.Forms.TextBox txtProductInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Data.SqlClient.SqlCommand sqlCommand_getProductInfo;
        private System.Data.SqlClient.SqlCommand sqlCommand_checkBarcode;
    }
}