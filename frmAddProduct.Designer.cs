namespace Pharmacy
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numUDMinReserve = new System.Windows.Forms.NumericUpDown();
            this.numUDInStock = new System.Windows.Forms.NumericUpDown();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.categoryTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.CategoryTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_addProduct = new System.Data.SqlClient.SqlCommand();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddMedicament = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(361, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрихкод";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(361, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(361, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бренд";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(361, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Название";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(361, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(360, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Мин.запас";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(360, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "В наличии";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(493, 481);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 42);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBarcode.Location = new System.Drawing.Point(504, 190);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(183, 30);
            this.txtBarcode.TabIndex = 8;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNameProduct.Location = new System.Drawing.Point(504, 302);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(300, 30);
            this.txtNameProduct.TabIndex = 9;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBrand.Location = new System.Drawing.Point(504, 266);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(183, 30);
            this.txtBrand.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrice.Location = new System.Drawing.Point(504, 338);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 30);
            this.txtPrice.TabIndex = 11;
            // 
            // numUDMinReserve
            // 
            this.numUDMinReserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUDMinReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUDMinReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numUDMinReserve.Location = new System.Drawing.Point(504, 379);
            this.numUDMinReserve.Name = "numUDMinReserve";
            this.numUDMinReserve.Size = new System.Drawing.Size(100, 30);
            this.numUDMinReserve.TabIndex = 12;
            // 
            // numUDInStock
            // 
            this.numUDInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUDInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUDInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numUDInStock.Location = new System.Drawing.Point(504, 418);
            this.numUDInStock.Name = "numUDInStock";
            this.numUDInStock.Size = new System.Drawing.Size(100, 30);
            this.numUDInStock.TabIndex = 13;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(406, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Введите данные о новом товаре";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_addProduct
            // 
            this.sqlCommand_addProduct.CommandText = "addNewProduct";
            this.sqlCommand_addProduct.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_addProduct.Connection = this.sqlConnection;
            this.sqlCommand_addProduct.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@barcode", System.Data.SqlDbType.Char, 13),
            new System.Data.SqlClient.SqlParameter("@nameCategory", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@brand", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@nameProduct", System.Data.SqlDbType.VarChar, 170),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money),
            new System.Data.SqlClient.SqlParameter("@minReserve", System.Data.SqlDbType.SmallInt),
            new System.Data.SqlClient.SqlParameter("@inStock", System.Data.SqlDbType.SmallInt)});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(753, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 60);
            this.label9.TabIndex = 17;
            this.label9.Text = "Если добавляемый товар \r\nявляется препаратом, добавьте \r\nк нему характеристики";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddMedicament
            // 
            this.btnAddMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMedicament.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMedicament.Location = new System.Drawing.Point(757, 481);
            this.btnAddMedicament.Name = "btnAddMedicament";
            this.btnAddMedicament.Size = new System.Drawing.Size(273, 42);
            this.btnAddMedicament.TabIndex = 18;
            this.btnAddMedicament.Text = "Добавить характеристики";
            this.btnAddMedicament.UseVisualStyleBackColor = false;
            this.btnAddMedicament.Click += new System.EventHandler(this.btnAddMedicament_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "NameCategory", true));
            this.cbCategory.DataSource = this.categoryBindingSource;
            this.cbCategory.DisplayMember = "NameCategory";
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(504, 227);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(300, 33);
            this.cbCategory.TabIndex = 19;
            this.cbCategory.ValueMember = "NameCategory";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnalogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.DeleteProductTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.PurveyorTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.SotrTableAdapter = null;
            this.tableAdapterManager.StructPurchaseTableAdapter = null;
            this.tableAdapterManager.StructSellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1009, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(493, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 42);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAddMedicament);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numUDInStock);
            this.Controls.Add(this.numUDMinReserve);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmAddProduct";
            this.Text = "Создание товара";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numUDMinReserve;
        private System.Windows.Forms.NumericUpDown numUDInStock;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PharmacyDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_addProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddMedicament;
        private System.Windows.Forms.ComboBox cbCategory;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PharmacyDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}