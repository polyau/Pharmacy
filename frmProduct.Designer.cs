﻿namespace Pharmacy
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.btnMedicament = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.tblProduct = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minReserveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet1 = new Pharmacy.PharmacyDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcodePur = new System.Windows.Forms.TextBox();
            this.btnAddPurveyor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.viewGetManagerSotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.productTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ProductTableAdapter();
            this.tableProductTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.tableProductTableAdapter();
            this.tableProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewGetManagerSotrTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.viewGetManagerSotrTableAdapter();
            this.btnSeeSell = new System.Windows.Forms.Button();
            this.btnSeePurchase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPurveyor = new System.Windows.Forms.ComboBox();
            this.getPurveyorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCommand_Purchase = new System.Data.SqlClient.SqlCommand();
            this.getPurveyorTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.getPurveyorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetManagerSotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPurveyorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicament
            // 
            this.btnMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedicament.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicament.Location = new System.Drawing.Point(952, 12);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(226, 42);
            this.btnMedicament.TabIndex = 30;
            this.btnMedicament.Text = "Описание препаратов";
            this.btnMedicament.UseVisualStyleBackColor = false;
            this.btnMedicament.Click += new System.EventHandler(this.btnMedicament_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(142, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Заказал:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPurchase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPurchase.Location = new System.Drawing.Point(332, 598);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(214, 43);
            this.btnPurchase.TabIndex = 25;
            this.btnPurchase.Text = "Оформить поставку";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(433, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Количество:";
            // 
            // numUD_count
            // 
            this.numUD_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numUD_count.Location = new System.Drawing.Point(584, 509);
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Size = new System.Drawing.Size(67, 30);
            this.numUD_count.TabIndex = 22;
            this.numUD_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(837, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 36);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFind.Location = new System.Drawing.Point(722, 374);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 36);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFind.Location = new System.Drawing.Point(367, 377);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(349, 30);
            this.txtFind.TabIndex = 18;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Location = new System.Drawing.Point(952, 98);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(226, 42);
            this.btnAddProduct.TabIndex = 31;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWriteOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWriteOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteOff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWriteOff.Location = new System.Drawing.Point(952, 146);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(226, 42);
            this.btnWriteOff.TabIndex = 32;
            this.btnWriteOff.Text = "Списать товар";
            this.btnWriteOff.UseVisualStyleBackColor = false;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // tblProduct
            // 
            this.tblProduct.AllowUserToAddRows = false;
            this.tblProduct.AllowUserToDeleteRows = false;
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
            this.tblProduct.Location = new System.Drawing.Point(5, 6);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.ReadOnly = true;
            this.tblProduct.RowHeadersWidth = 51;
            this.tblProduct.RowTemplate.Height = 24;
            this.tblProduct.Size = new System.Drawing.Size(941, 362);
            this.tblProduct.TabIndex = 34;
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
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "Названия";
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
            this.tableProductBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 44);
            this.label4.TabIndex = 35;
            this.label4.Text = "Введите штрихкод, бренд, название\r\nили категорию товара:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(312, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Оформление поставки";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(125, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Штрихкод:";
            // 
            // txtBarcodePur
            // 
            this.txtBarcodePur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcodePur.Location = new System.Drawing.Point(258, 509);
            this.txtBarcodePur.Name = "txtBarcodePur";
            this.txtBarcodePur.Size = new System.Drawing.Size(156, 30);
            this.txtBarcodePur.TabIndex = 37;
            // 
            // btnAddPurveyor
            // 
            this.btnAddPurveyor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPurveyor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddPurveyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPurveyor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddPurveyor.Location = new System.Drawing.Point(856, 530);
            this.btnAddPurveyor.Name = "btnAddPurveyor";
            this.btnAddPurveyor.Size = new System.Drawing.Size(240, 42);
            this.btnAddPurveyor.TabIndex = 40;
            this.btnAddPurveyor.Text = "Добавить поставщика";
            this.btnAddPurveyor.UseVisualStyleBackColor = false;
            this.btnAddPurveyor.Click += new System.EventHandler(this.btnAddPurveyor_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(852, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 40);
            this.label7.TabIndex = 41;
            this.label7.Text = "Добавьте поставщика, если\r\nвы с ним не работали ранее";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(258, 547);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(156, 30);
            this.txtOutput.TabIndex = 42;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProduct.Location = new System.Drawing.Point(952, 232);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(226, 42);
            this.btnDeleteProduct.TabIndex = 43;
            this.btnDeleteProduct.Text = "Списанные товары";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // viewGetManagerSotrBindingSource
            // 
            this.viewGetManagerSotrBindingSource.DataMember = "viewGetManagerSotr";
            this.viewGetManagerSotrBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableProductTableAdapter
            // 
            this.tableProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableProductBindingSource1
            // 
            this.tableProductBindingSource1.DataMember = "tableProduct";
            this.tableProductBindingSource1.DataSource = this.pharmacyDataSet1;
            // 
            // viewGetManagerSotrTableAdapter
            // 
            this.viewGetManagerSotrTableAdapter.ClearBeforeFill = true;
            // 
            // btnSeeSell
            // 
            this.btnSeeSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeeSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSeeSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeeSell.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeeSell.Location = new System.Drawing.Point(952, 280);
            this.btnSeeSell.Name = "btnSeeSell";
            this.btnSeeSell.Size = new System.Drawing.Size(226, 41);
            this.btnSeeSell.TabIndex = 44;
            this.btnSeeSell.Text = "Продажи";
            this.btnSeeSell.UseVisualStyleBackColor = false;
            this.btnSeeSell.Click += new System.EventHandler(this.btnSeeSell_Click);
            // 
            // btnSeePurchase
            // 
            this.btnSeePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSeePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeePurchase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeePurchase.Location = new System.Drawing.Point(952, 327);
            this.btnSeePurchase.Name = "btnSeePurchase";
            this.btnSeePurchase.Size = new System.Drawing.Size(226, 41);
            this.btnSeePurchase.TabIndex = 45;
            this.btnSeePurchase.Text = "Поставки";
            this.btnSeePurchase.UseVisualStyleBackColor = false;
            this.btnSeePurchase.Click += new System.EventHandler(this.btnSeePurchase_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(439, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Поставщик:";
            // 
            // cbPurveyor
            // 
            this.cbPurveyor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getPurveyorBindingSource, "NamePurveyor", true));
            this.cbPurveyor.DataSource = this.getPurveyorBindingSource;
            this.cbPurveyor.DisplayMember = "NamePurveyor";
            this.cbPurveyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPurveyor.FormattingEnabled = true;
            this.cbPurveyor.Location = new System.Drawing.Point(584, 547);
            this.cbPurveyor.Name = "cbPurveyor";
            this.cbPurveyor.Size = new System.Drawing.Size(183, 33);
            this.cbPurveyor.TabIndex = 48;
            this.cbPurveyor.ValueMember = "NamePurveyor";
            // 
            // getPurveyorBindingSource
            // 
            this.getPurveyorBindingSource.DataMember = "getPurveyor";
            this.getPurveyorBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // sqlCommand_Purchase
            // 
            this.sqlCommand_Purchase.CommandText = "addPurchase";
            this.sqlCommand_Purchase.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_Purchase.Connection = this.sqlConnection;
            this.sqlCommand_Purchase.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.SmallInt),
            new System.Data.SqlClient.SqlParameter("@purveyor", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 60)});
            // 
            // getPurveyorTableAdapter
            // 
            this.getPurveyorTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.cbPurveyor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSeePurchase);
            this.Controls.Add(this.btnSeeSell);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddPurveyor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarcodePur);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblProduct);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_count);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmProduct";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetManagerSotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPurveyorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.Button btnAddProduct;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PharmacyDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btnWriteOff;
        private PharmacyDataSet pharmacyDataSet1;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private PharmacyDataSetTableAdapters.tableProductTableAdapter tableProductTableAdapter;
        private System.Windows.Forms.DataGridView tblProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableProductBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource viewGetManagerSotrBindingSource;
        private PharmacyDataSetTableAdapters.viewGetManagerSotrTableAdapter viewGetManagerSotrTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarcodePur;
        private System.Windows.Forms.Button btnAddPurveyor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSeeSell;
        private System.Windows.Forms.Button btnSeePurchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPurveyor;
        private System.Data.SqlClient.SqlCommand sqlCommand_Purchase;
        private System.Windows.Forms.BindingSource getPurveyorBindingSource;
        private PharmacyDataSetTableAdapters.getPurveyorTableAdapter getPurveyorTableAdapter;
    }
}