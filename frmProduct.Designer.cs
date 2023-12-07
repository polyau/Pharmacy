namespace Pharmacy
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
            this.tbl_Cart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cashier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_removeFromCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.tblProduct = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сodeСategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minReserveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.productTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ProductTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicament
            // 
            this.btnMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedicament.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicament.Location = new System.Drawing.Point(968, 12);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(210, 42);
            this.btnMedicament.TabIndex = 30;
            this.btnMedicament.Text = "Описание товара";
            this.btnMedicament.UseVisualStyleBackColor = false;
            // 
            // tbl_Cart
            // 
            this.tbl_Cart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Cart.Location = new System.Drawing.Point(5, 350);
            this.tbl_Cart.Name = "tbl_Cart";
            this.tbl_Cart.RowHeadersWidth = 51;
            this.tbl_Cart.RowTemplate.Height = 24;
            this.tbl_Cart.Size = new System.Drawing.Size(820, 303);
            this.tbl_Cart.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(334, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Корзина";
            // 
            // cb_cashier
            // 
            this.cb_cashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cashier.DisplayMember = "Fio";
            this.cb_cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_cashier.FormattingEnabled = true;
            this.cb_cashier.Location = new System.Drawing.Point(909, 560);
            this.cb_cashier.Name = "cb_cashier";
            this.cb_cashier.Size = new System.Drawing.Size(214, 33);
            this.cb_cashier.TabIndex = 27;
            this.cb_cashier.ValueMember = "Fio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(908, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Заказал:";
            // 
            // btn_sell
            // 
            this.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sell.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sell.Location = new System.Drawing.Point(909, 599);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(214, 42);
            this.btn_sell.TabIndex = 25;
            this.btn_sell.Text = "Оформить поставку";
            this.btn_sell.UseVisualStyleBackColor = false;
            // 
            // btn_removeFromCart
            // 
            this.btn_removeFromCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_removeFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_removeFromCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_removeFromCart.Location = new System.Drawing.Point(968, 238);
            this.btn_removeFromCart.Name = "btn_removeFromCart";
            this.btn_removeFromCart.Size = new System.Drawing.Size(210, 42);
            this.btn_removeFromCart.TabIndex = 24;
            this.btn_removeFromCart.Text = "Удалить из корзины";
            this.btn_removeFromCart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(968, 156);
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
            this.numUD_count.Location = new System.Drawing.Point(1103, 154);
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Size = new System.Drawing.Size(67, 30);
            this.numUD_count.TabIndex = 22;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToCart.Location = new System.Drawing.Point(968, 190);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(210, 42);
            this.btnAddToCart.TabIndex = 21;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(431, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 36);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFind.Location = new System.Drawing.Point(316, 274);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 36);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFind.Location = new System.Drawing.Point(5, 277);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(302, 30);
            this.txtFind.TabIndex = 18;
            // 
            // tblProduct
            // 
            this.tblProduct.AllowUserToDeleteRows = false;
            this.tblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblProduct.AutoGenerateColumns = false;
            this.tblProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.сodeСategoryDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.minReserveDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
            this.tblProduct.DataSource = this.productBindingSource;
            this.tblProduct.Location = new System.Drawing.Point(5, -1);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.RowHeadersWidth = 51;
            this.tblProduct.RowTemplate.Height = 24;
            this.tblProduct.Size = new System.Drawing.Size(941, 272);
            this.tblProduct.TabIndex = 16;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Штрихкод";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // сodeСategoryDataGridViewTextBoxColumn
            // 
            this.сodeСategoryDataGridViewTextBoxColumn.DataPropertyName = "СodeСategory";
            this.сodeСategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.сodeСategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сodeСategoryDataGridViewTextBoxColumn.Name = "сodeСategoryDataGridViewTextBoxColumn";
            this.сodeСategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minReserveDataGridViewTextBoxColumn
            // 
            this.minReserveDataGridViewTextBoxColumn.DataPropertyName = "MinReserve";
            this.minReserveDataGridViewTextBoxColumn.HeaderText = "Мин.запас";
            this.minReserveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minReserveDataGridViewTextBoxColumn.Name = "minReserveDataGridViewTextBoxColumn";
            this.minReserveDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "В наличии";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 125;
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
            this.btnAddProduct.Location = new System.Drawing.Point(968, 60);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(210, 42);
            this.btnAddProduct.TabIndex = 31;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(968, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "Списать товар";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.tbl_Cart);
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
            this.Controls.Add(this.tblProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmProduct";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.DataGridView tbl_Cart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_cashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_removeFromCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView tblProduct;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.Button btnAddProduct;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PharmacyDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сodeСategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}