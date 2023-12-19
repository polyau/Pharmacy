namespace Pharmacy
{
    partial class frmSotr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSotr));
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.sotrTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.SotrTableAdapter();
            this.btnAddSotr = new System.Windows.Forms.Button();
            this.btnRemoveSotr = new System.Windows.Forms.Button();
            this.txtFio = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_addSotr = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand_remSotr = new System.Data.SqlClient.SqlCommand();
            this.tblSotr = new System.Windows.Forms.DataGridView();
            this.idSotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCommand_allSotr = new System.Data.SqlClient.SqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.sqlCommand_retireSotr = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddSotr
            // 
            this.btnAddSotr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSotr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSotr.Location = new System.Drawing.Point(806, 310);
            this.btnAddSotr.Name = "btnAddSotr";
            this.btnAddSotr.Size = new System.Drawing.Size(269, 42);
            this.btnAddSotr.TabIndex = 1;
            this.btnAddSotr.Text = "Добавить сотрудника";
            this.btnAddSotr.UseVisualStyleBackColor = false;
            this.btnAddSotr.Click += new System.EventHandler(this.btnAddSotr_Click);
            // 
            // btnRemoveSotr
            // 
            this.btnRemoveSotr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemoveSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSotr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveSotr.Location = new System.Drawing.Point(806, 432);
            this.btnRemoveSotr.Name = "btnRemoveSotr";
            this.btnRemoveSotr.Size = new System.Drawing.Size(269, 42);
            this.btnRemoveSotr.TabIndex = 2;
            this.btnRemoveSotr.Text = "Уволить сотрудника";
            this.btnRemoveSotr.UseVisualStyleBackColor = false;
            this.btnRemoveSotr.Click += new System.EventHandler(this.btnRemoveSotr_Click);
            // 
            // txtFio
            // 
            this.txtFio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFio.Location = new System.Drawing.Point(935, 154);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(140, 30);
            this.txtFio.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(935, 262);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(935, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(806, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(806, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(806, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(806, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(792, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Добавление сотрудника";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_addSotr
            // 
            this.sqlCommand_addSotr.CommandText = "addNewSotr";
            this.sqlCommand_addSotr.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_addSotr.Connection = this.sqlConnection;
            this.sqlCommand_addSotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 60),
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phoneNum", System.Data.SqlDbType.VarChar, 15)});
            // 
            // sqlCommand_remSotr
            // 
            this.sqlCommand_remSotr.CommandText = "deleteSotr";
            this.sqlCommand_remSotr.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_remSotr.Connection = this.sqlConnection;
            this.sqlCommand_remSotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idSotr", System.Data.SqlDbType.SmallInt)});
            // 
            // tblSotr
            // 
            this.tblSotr.AllowUserToAddRows = false;
            this.tblSotr.AllowUserToDeleteRows = false;
            this.tblSotr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblSotr.AutoGenerateColumns = false;
            this.tblSotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSotrDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn});
            this.tblSotr.DataSource = this.sotrBindingSource;
            this.tblSotr.Location = new System.Drawing.Point(12, 56);
            this.tblSotr.Name = "tblSotr";
            this.tblSotr.ReadOnly = true;
            this.tblSotr.RowHeadersWidth = 51;
            this.tblSotr.RowTemplate.Height = 24;
            this.tblSotr.Size = new System.Drawing.Size(709, 495);
            this.tblSotr.TabIndex = 12;
            // 
            // idSotrDataGridViewTextBoxColumn
            // 
            this.idSotrDataGridViewTextBoxColumn.DataPropertyName = "idSotr";
            this.idSotrDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idSotrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSotrDataGridViewTextBoxColumn.Name = "idSotrDataGridViewTextBoxColumn";
            this.idSotrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSotrDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "Sotr";
            this.sotrBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // sqlCommand_allSotr
            // 
            this.sqlCommand_allSotr.CommandText = "SELECT * FROM Sotr";
            this.sqlCommand_allSotr.Connection = this.sqlConnection;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(826, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выберите сотрудника в таблице";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Провизор",
            "Фармацевт",
            "Менеджер",
            "Уборщик",
            "Директор"});
            this.cbPosition.Location = new System.Drawing.Point(935, 189);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(140, 33);
            this.cbPosition.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1001, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // sqlCommand_retireSotr
            // 
            this.sqlCommand_retireSotr.CommandText = "retireSotr";
            this.sqlCommand_retireSotr.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_retireSotr.Connection = this.sqlConnection;
            this.sqlCommand_retireSotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idSotr", System.Data.SqlDbType.SmallInt)});
            // 
            // frmSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tblSotr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFio);
            this.Controls.Add(this.btnRemoveSotr);
            this.Controls.Add(this.btnAddSotr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmSotr";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.frmSotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PharmacyDataSet pharmacyDataSet;
        private PharmacyDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.Button btnAddSotr;
        private System.Windows.Forms.Button btnRemoveSotr;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_addSotr;
        private System.Data.SqlClient.SqlCommand sqlCommand_remSotr;
        private System.Windows.Forms.DataGridView tblSotr;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private System.Data.SqlClient.SqlCommand sqlCommand_allSotr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnBack;
        private System.Data.SqlClient.SqlCommand sqlCommand_retireSotr;
    }
}