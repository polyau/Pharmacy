namespace Pharmacy
{
    partial class frmSeePurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeePurchase));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namePurveyorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelivPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewPurchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet1 = new Pharmacy.PharmacyDataSet();
            this.viewPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.viewPurchaseTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.viewPurchaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namePurveyorDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.dateExeDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityOrdDataGridViewTextBoxColumn,
            this.DelivPrice});
            this.dataGridView1.DataSource = this.viewPurchaseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(62, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // namePurveyorDataGridViewTextBoxColumn
            // 
            this.namePurveyorDataGridViewTextBoxColumn.DataPropertyName = "NamePurveyor";
            this.namePurveyorDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.namePurveyorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namePurveyorDataGridViewTextBoxColumn.Name = "namePurveyorDataGridViewTextBoxColumn";
            this.namePurveyorDataGridViewTextBoxColumn.ReadOnly = true;
            this.namePurveyorDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateExeDataGridViewTextBoxColumn
            // 
            this.dateExeDataGridViewTextBoxColumn.DataPropertyName = "DateExe";
            this.dateExeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateExeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateExeDataGridViewTextBoxColumn.Name = "dateExeDataGridViewTextBoxColumn";
            this.dateExeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateExeDataGridViewTextBoxColumn.Width = 125;
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
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityOrdDataGridViewTextBoxColumn
            // 
            this.quantityOrdDataGridViewTextBoxColumn.DataPropertyName = "QuantityOrd";
            this.quantityOrdDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityOrdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityOrdDataGridViewTextBoxColumn.Name = "quantityOrdDataGridViewTextBoxColumn";
            this.quantityOrdDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityOrdDataGridViewTextBoxColumn.Width = 125;
            // 
            // DelivPrice
            // 
            this.DelivPrice.DataPropertyName = "DelivPrice";
            this.DelivPrice.HeaderText = "Сумма";
            this.DelivPrice.MinimumWidth = 6;
            this.DelivPrice.Name = "DelivPrice";
            this.DelivPrice.ReadOnly = true;
            this.DelivPrice.Width = 125;
            // 
            // viewPurchaseBindingSource1
            // 
            this.viewPurchaseBindingSource1.DataMember = "viewPurchase";
            this.viewPurchaseBindingSource1.DataSource = this.pharmacyDataSet1;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPurchaseBindingSource
            // 
            this.viewPurchaseBindingSource.DataMember = "viewPurchase";
            this.viewPurchaseBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Информация о закупленных товарах";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(23, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(850, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Вы можете осуществить поиск по поставщику, заказчику, штрихкоду, бренду или назва" +
    "нию товара";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(872, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 36);
            this.btnReset.TabIndex = 47;
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
            this.btnFind.Location = new System.Drawing.Point(757, 537);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 36);
            this.btnFind.TabIndex = 46;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFind.Location = new System.Drawing.Point(231, 540);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(520, 30);
            this.txtFind.TabIndex = 45;
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
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // viewPurchaseTableAdapter
            // 
            this.viewPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmSeePurchase";
            this.Text = "Закупленные товары";
            this.Load += new System.EventHandler(this.frmSeePurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource viewPurchaseBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnBack;
        private PharmacyDataSet pharmacyDataSet1;
        private System.Windows.Forms.BindingSource viewPurchaseBindingSource1;
        private PharmacyDataSetTableAdapters.viewPurchaseTableAdapter viewPurchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePurveyorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelivPrice;
    }
}