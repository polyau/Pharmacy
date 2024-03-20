namespace Pharmacy
{
    partial class frmSeeDeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeeDeleteProduct));
            this.tblDelete = new System.Windows.Forms.DataGridView();
            this.ndeleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whyDeleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProductForWFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.deleteProductForWFTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.deleteProductForWFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProductForWFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDelete
            // 
            this.tblDelete.AllowUserToAddRows = false;
            this.tblDelete.AllowUserToDeleteRows = false;
            this.tblDelete.AutoGenerateColumns = false;
            this.tblDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndeleteDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDeleteDataGridViewTextBoxColumn,
            this.whyDeleteDataGridViewTextBoxColumn});
            this.tblDelete.DataSource = this.deleteProductForWFBindingSource;
            this.tblDelete.Location = new System.Drawing.Point(121, 50);
            this.tblDelete.Name = "tblDelete";
            this.tblDelete.ReadOnly = true;
            this.tblDelete.RowHeadersWidth = 51;
            this.tblDelete.RowTemplate.Height = 24;
            this.tblDelete.Size = new System.Drawing.Size(940, 465);
            this.tblDelete.TabIndex = 0;
            // 
            // ndeleteDataGridViewTextBoxColumn
            // 
            this.ndeleteDataGridViewTextBoxColumn.DataPropertyName = "Ndelete";
            this.ndeleteDataGridViewTextBoxColumn.HeaderText = "№списания";
            this.ndeleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ndeleteDataGridViewTextBoxColumn.Name = "ndeleteDataGridViewTextBoxColumn";
            this.ndeleteDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndeleteDataGridViewTextBoxColumn.Width = 125;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDeleteDataGridViewTextBoxColumn
            // 
            this.dateDeleteDataGridViewTextBoxColumn.DataPropertyName = "DateDelete";
            this.dateDeleteDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDeleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDeleteDataGridViewTextBoxColumn.Name = "dateDeleteDataGridViewTextBoxColumn";
            this.dateDeleteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDeleteDataGridViewTextBoxColumn.Width = 125;
            // 
            // whyDeleteDataGridViewTextBoxColumn
            // 
            this.whyDeleteDataGridViewTextBoxColumn.DataPropertyName = "WhyDelete";
            this.whyDeleteDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.whyDeleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whyDeleteDataGridViewTextBoxColumn.Name = "whyDeleteDataGridViewTextBoxColumn";
            this.whyDeleteDataGridViewTextBoxColumn.ReadOnly = true;
            this.whyDeleteDataGridViewTextBoxColumn.Width = 125;
            // 
            // deleteProductForWFBindingSource
            // 
            this.deleteProductForWFBindingSource.DataMember = "deleteProductForWF";
            this.deleteProductForWFBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1028, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Информация о списаниях товаров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(121, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Введите штрихкод, бренд или название товара:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(957, 530);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 36);
            this.btnReset.TabIndex = 38;
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
            this.btnFind.Location = new System.Drawing.Point(842, 530);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 36);
            this.btnFind.TabIndex = 37;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFind.Location = new System.Drawing.Point(584, 533);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(254, 30);
            this.txtFind.TabIndex = 36;
            // 
            // deleteProductForWFTableAdapter
            // 
            this.deleteProductForWFTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeeDeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tblDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmSeeDeleteProduct";
            this.Text = "Списанные товары";
            this.Load += new System.EventHandler(this.frmDeleteProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProductForWFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblDelete;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource deleteProductForWFBindingSource;
        private PharmacyDataSetTableAdapters.deleteProductForWFTableAdapter deleteProductForWFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndeleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whyDeleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
    }
}