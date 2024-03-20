namespace Pharmacy
{
    partial class frmCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier));
            this.tblProduct = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minReserveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ProductTableAdapter();
            this.btnFindAnalog = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCashierSotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.SotrTableAdapter();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_findAnalogs = new System.Data.SqlClient.SqlCommand();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.sqlCommand_allSotr = new System.Data.SqlClient.SqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.tableProductTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.tableProductTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.sqlCommand_cshSotr = new System.Data.SqlClient.SqlCommand();
            this.getCashierSotrTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.getCashierSotrTableAdapter();
            this.txtBarcodeSell = new System.Windows.Forms.TextBox();
            this.sqlCommand_Sell = new System.Data.SqlClient.SqlCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.sqlCommand_checkStock = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand_checkBarcode = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCashierSotrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProduct
            // 
            this.tblProduct.AllowUserToAddRows = false;
            this.tblProduct.AllowUserToDeleteRows = false;
            this.tblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblProduct.AutoGenerateColumns = false;
            this.tblProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.nameCategoryDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.minReserveDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
            this.tblProduct.DataSource = this.tableProductBindingSource;
            this.tblProduct.Location = new System.Drawing.Point(107, 2);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.ReadOnly = true;
            this.tblProduct.RowHeadersWidth = 51;
            this.tblProduct.RowTemplate.Height = 24;
            this.tblProduct.Size = new System.Drawing.Size(941, 374);
            this.tblProduct.TabIndex = 0;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Штрихкод";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCategoryDataGridViewTextBoxColumn
            // 
            this.nameCategoryDataGridViewTextBoxColumn.DataPropertyName = "NameCategory";
            this.nameCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.nameCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCategoryDataGridViewTextBoxColumn.Name = "nameCategoryDataGridViewTextBoxColumn";
            this.nameCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minReserveDataGridViewTextBoxColumn
            // 
            this.minReserveDataGridViewTextBoxColumn.DataPropertyName = "MinReserve";
            this.minReserveDataGridViewTextBoxColumn.HeaderText = "Мин.запас";
            this.minReserveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minReserveDataGridViewTextBoxColumn.Name = "minReserveDataGridViewTextBoxColumn";
            this.minReserveDataGridViewTextBoxColumn.ReadOnly = true;
            this.minReserveDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "В наличии";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableProductBindingSource
            // 
            this.tableProductBindingSource.DataMember = "tableProduct";
            this.tableProductBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btnFindAnalog
            // 
            this.btnFindAnalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindAnalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFindAnalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindAnalog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFindAnalog.Location = new System.Drawing.Point(749, 527);
            this.btnFindAnalog.Name = "btnFindAnalog";
            this.btnFindAnalog.Size = new System.Drawing.Size(226, 41);
            this.btnFindAnalog.TabIndex = 1;
            this.btnFindAnalog.Text = "Подбор аналогов";
            this.btnFindAnalog.UseVisualStyleBackColor = false;
            this.btnFindAnalog.Click += new System.EventHandler(this.btnFindAnalog_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFind.Location = new System.Drawing.Point(570, 382);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(248, 30);
            this.txtFind.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFind.Location = new System.Drawing.Point(824, 378);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 37);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(939, 378);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numUD_count
            // 
            this.numUD_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_count.Location = new System.Drawing.Point(417, 512);
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Size = new System.Drawing.Size(91, 30);
            this.numUD_count.TabIndex = 7;
            this.numUD_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(267, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество:";
            // 
            // btnSell
            // 
            this.btnSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSell.Location = new System.Drawing.Point(323, 598);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(214, 43);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Оформить продажу";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(308, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Продал:";
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "Sotr";
            this.sotrBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // getCashierSotrBindingSource
            // 
            this.getCashierSotrBindingSource.DataMember = "getCashierSotr";
            this.getCashierSotrBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_findAnalogs
            // 
            this.sqlCommand_findAnalogs.CommandText = "SELECT Barcode, СodeСategory, Brand, NameProduct, Price, MinReserve, InStock\r\nFRO" +
    "M     dbo.findAnalogs(@Barcode) AS findAnalogs_1";
            this.sqlCommand_findAnalogs.Connection = this.sqlConnection;
            this.sqlCommand_findAnalogs.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // btnMedicament
            // 
            this.btnMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedicament.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicament.Location = new System.Drawing.Point(749, 480);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(226, 41);
            this.btnMedicament.TabIndex = 15;
            this.btnMedicament.Text = "Описание препаратов";
            this.btnMedicament.UseVisualStyleBackColor = false;
            this.btnMedicament.Click += new System.EventHandler(this.btnMedicament_Click);
            // 
            // sqlCommand_allSotr
            // 
            this.sqlCommand_allSotr.CommandText = "SELECT * FROM Sotr";
            this.sqlCommand_allSotr.Connection = this.sqlConnection;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(112, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введите название, бренд или категорию товара:";
            // 
            // tableProductTableAdapter
            // 
            this.tableProductTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1028, 598);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // sqlCommand_cshSotr
            // 
            this.sqlCommand_cshSotr.CommandText = "SELECT Fio \r\nFROM     Sotr\r\n WHERE  (Position = \'Провизор\') OR\r\n                 " +
    " (Position = \'Фармацевт\')";
            this.sqlCommand_cshSotr.Connection = this.sqlConnection;
            // 
            // getCashierSotrTableAdapter
            // 
            this.getCashierSotrTableAdapter.ClearBeforeFill = true;
            // 
            // txtBarcodeSell
            // 
            this.txtBarcodeSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcodeSell.Location = new System.Drawing.Point(417, 473);
            this.txtBarcodeSell.Name = "txtBarcodeSell";
            this.txtBarcodeSell.Size = new System.Drawing.Size(156, 30);
            this.txtBarcodeSell.TabIndex = 18;
            // 
            // sqlCommand_Sell
            // 
            this.sqlCommand_Sell.CommandText = "addStructSell";
            this.sqlCommand_Sell.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_Sell.Connection = this.sqlConnection;
            this.sqlCommand_Sell.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.SmallInt),
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 60)});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(285, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Штрихкод:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(304, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Оформление продажи";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(417, 550);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(156, 30);
            this.txtOutput.TabIndex = 21;
            // 
            // sqlCommand_checkStock
            // 
            this.sqlCommand_checkStock.CommandText = "SELECT dbo.checkStock(@barcode)";
            this.sqlCommand_checkStock.Connection = this.sqlConnection;
            this.sqlCommand_checkStock.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // sqlCommand_checkBarcode
            // 
            this.sqlCommand_checkBarcode.CommandText = "SELECT dbo.checkBarcode(@barcode)";
            this.sqlCommand_checkBarcode.Connection = this.sqlConnection;
            this.sqlCommand_checkBarcode.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarcodeSell);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_count);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFindAnalog);
            this.Controls.Add(this.tblProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmCashier";
            this.Text = "Первостольник";
            this.Load += new System.EventHandler(this.frmCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCashierSotrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProduct;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PharmacyDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btnFindAnalog;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private PharmacyDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_findAnalogs;
        private System.Windows.Forms.Button btnMedicament;
        private System.Data.SqlClient.SqlCommand sqlCommand_allSotr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private PharmacyDataSetTableAdapters.tableProductTableAdapter tableProductTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Data.SqlClient.SqlCommand sqlCommand_cshSotr;
        private System.Windows.Forms.BindingSource getCashierSotrBindingSource;
        private PharmacyDataSetTableAdapters.getCashierSotrTableAdapter getCashierSotrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBarcodeSell;
        private System.Data.SqlClient.SqlCommand sqlCommand_Sell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Data.SqlClient.SqlCommand sqlCommand_checkStock;
        private System.Data.SqlClient.SqlCommand sqlCommand_checkBarcode;
    }
}