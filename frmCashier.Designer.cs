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
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_removeFromCart = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_cashier = new System.Windows.Forms.ComboBox();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.SotrTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.tblCart = new System.Windows.Forms.DataGridView();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_findAnalogs = new System.Data.SqlClient.SqlCommand();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.sqlCommand_allSotr = new System.Data.SqlClient.SqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.tableProductTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.tableProductTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCart)).BeginInit();
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
            this.Barcode,
            this.NameCategory,
            this.Brand,
            this.NameProduct,
            this.Price,
            this.MinReserve,
            this.InStock,
            this.barcodeDataGridViewTextBoxColumn,
            this.nameCategoryDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.minReserveDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
            this.tblProduct.DataSource = this.tableProductBindingSource;
            this.tblProduct.Location = new System.Drawing.Point(-3, -1);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.ReadOnly = true;
            this.tblProduct.RowHeadersWidth = 51;
            this.tblProduct.RowTemplate.Height = 24;
            this.tblProduct.Size = new System.Drawing.Size(941, 374);
            this.tblProduct.TabIndex = 0;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Штрихкод";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 125;
            // 
            // NameCategory
            // 
            this.NameCategory.DataPropertyName = "NameCategory";
            this.NameCategory.HeaderText = "Категория";
            this.NameCategory.MinimumWidth = 6;
            this.NameCategory.Name = "NameCategory";
            this.NameCategory.ReadOnly = true;
            this.NameCategory.Width = 125;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Бренд";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 125;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Название";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // MinReserve
            // 
            this.MinReserve.DataPropertyName = "MinReserve";
            this.MinReserve.HeaderText = "Мин.запас";
            this.MinReserve.MinimumWidth = 6;
            this.MinReserve.Name = "MinReserve";
            this.MinReserve.ReadOnly = true;
            this.MinReserve.Width = 125;
            // 
            // InStock
            // 
            this.InStock.DataPropertyName = "InStock";
            this.InStock.HeaderText = "В наличии";
            this.InStock.MinimumWidth = 6;
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 125;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCategoryDataGridViewTextBoxColumn
            // 
            this.nameCategoryDataGridViewTextBoxColumn.DataPropertyName = "NameCategory";
            this.nameCategoryDataGridViewTextBoxColumn.HeaderText = "NameCategory";
            this.nameCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCategoryDataGridViewTextBoxColumn.Name = "nameCategoryDataGridViewTextBoxColumn";
            this.nameCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minReserveDataGridViewTextBoxColumn
            // 
            this.minReserveDataGridViewTextBoxColumn.DataPropertyName = "MinReserve";
            this.minReserveDataGridViewTextBoxColumn.HeaderText = "MinReserve";
            this.minReserveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minReserveDataGridViewTextBoxColumn.Name = "minReserveDataGridViewTextBoxColumn";
            this.minReserveDataGridViewTextBoxColumn.ReadOnly = true;
            this.minReserveDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
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
            this.btnFindAnalog.Location = new System.Drawing.Point(944, 59);
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
            this.txtFind.Location = new System.Drawing.Point(460, 379);
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
            this.btnFind.Location = new System.Drawing.Point(714, 375);
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
            this.btnReset.Location = new System.Drawing.Point(829, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToCart.Location = new System.Drawing.Point(944, 286);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(226, 41);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // numUD_count
            // 
            this.numUD_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_count.Location = new System.Drawing.Point(1079, 250);
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
            this.label1.Location = new System.Drawing.Point(944, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество:";
            // 
            // btn_removeFromCart
            // 
            this.btn_removeFromCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_removeFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_removeFromCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_removeFromCart.Location = new System.Drawing.Point(944, 333);
            this.btn_removeFromCart.Name = "btn_removeFromCart";
            this.btn_removeFromCart.Size = new System.Drawing.Size(226, 41);
            this.btn_removeFromCart.TabIndex = 9;
            this.btn_removeFromCart.Text = "Удалить из корзины";
            this.btn_removeFromCart.UseVisualStyleBackColor = false;
            this.btn_removeFromCart.Click += new System.EventHandler(this.btn_removeFromCart_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sell.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sell.Location = new System.Drawing.Point(900, 531);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(214, 41);
            this.btn_sell.TabIndex = 10;
            this.btn_sell.Text = "Оформить продажу";
            this.btn_sell.UseVisualStyleBackColor = false;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(899, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Продал:";
            // 
            // cb_cashier
            // 
            this.cb_cashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cashier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sotrBindingSource, "Fio", true));
            this.cb_cashier.DataSource = this.sotrBindingSource;
            this.cb_cashier.DisplayMember = "Fio";
            this.cb_cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_cashier.FormattingEnabled = true;
            this.cb_cashier.Location = new System.Drawing.Point(900, 492);
            this.cb_cashier.Name = "cb_cashier";
            this.cb_cashier.Size = new System.Drawing.Size(214, 33);
            this.cb_cashier.TabIndex = 12;
            this.cb_cashier.ValueMember = "Fio";
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "Sotr";
            this.sotrBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(317, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Корзина";
            // 
            // tblCart
            // 
            this.tblCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCart.Location = new System.Drawing.Point(-3, 447);
            this.tblCart.Name = "tblCart";
            this.tblCart.RowHeadersWidth = 51;
            this.tblCart.RowTemplate.Height = 24;
            this.tblCart.Size = new System.Drawing.Size(802, 206);
            this.tblCart.TabIndex = 14;
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
            this.btnMedicament.Location = new System.Drawing.Point(944, 12);
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
            this.label4.Location = new System.Drawing.Point(2, 384);
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
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.tblCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_cashier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_removeFromCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_count);
            this.Controls.Add(this.btnAddToCart);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblCart)).EndInit();
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
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_removeFromCart;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_cashier;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private PharmacyDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblCart;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_findAnalogs;
        private System.Windows.Forms.Button btnMedicament;
        private System.Data.SqlClient.SqlCommand sqlCommand_allSotr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private PharmacyDataSetTableAdapters.tableProductTableAdapter tableProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}