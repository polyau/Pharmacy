namespace Pharmacy
{
    partial class frmWriteOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWriteOff));
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWhy = new System.Windows.Forms.TextBox();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.sqlCommand_writeOff = new System.Data.SqlClient.SqlCommand();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtProductInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlCommand_getProductInfo = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand_checkBarcode = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(315, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные о товаре, который нужно списать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(465, 223);
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
            this.label3.Location = new System.Drawing.Point(389, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Причина списания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(447, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество";
            // 
            // txtWhy
            // 
            this.txtWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWhy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtWhy.Location = new System.Drawing.Point(592, 322);
            this.txtWhy.Name = "txtWhy";
            this.txtWhy.Size = new System.Drawing.Size(294, 30);
            this.txtWhy.TabIndex = 5;
            // 
            // numUD_count
            // 
            this.numUD_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numUD_count.Location = new System.Drawing.Point(592, 273);
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Size = new System.Drawing.Size(81, 30);
            this.numUD_count.TabIndex = 8;
            this.numUD_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWriteOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteOff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWriteOff.Location = new System.Drawing.Point(529, 399);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(131, 43);
            this.btnWriteOff.TabIndex = 9;
            this.btnWriteOff.Text = "Списать";
            this.btnWriteOff.UseVisualStyleBackColor = false;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.Location = new System.Drawing.Point(592, 220);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(194, 30);
            this.txtBarcode.TabIndex = 10;
            // 
            // sqlCommand_writeOff
            // 
            this.sqlCommand_writeOff.CommandText = "writeOffProduct";
            this.sqlCommand_writeOff.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_writeOff.Connection = this.sqlConnection;
            this.sqlCommand_writeOff.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.Char, 13),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt),
            new System.Data.SqlClient.SqlParameter("@WhyDelete", System.Data.SqlDbType.VarChar, 60)});
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1001, 573);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtProductInfo
            // 
            this.txtProductInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductInfo.Location = new System.Drawing.Point(197, 477);
            this.txtProductInfo.Name = "txtProductInfo";
            this.txtProductInfo.Size = new System.Drawing.Size(973, 30);
            this.txtProductInfo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Списанный товар:";
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
            // frmWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.numUD_count);
            this.Controls.Add(this.txtWhy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmWriteOff";
            this.Text = "Списание товара";
            this.Load += new System.EventHandler(this.frmWriteOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWhy;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Data.SqlClient.SqlCommand sqlCommand_writeOff;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtProductInfo;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlCommand sqlCommand_getProductInfo;
        private System.Data.SqlClient.SqlCommand sqlCommand_checkBarcode;
    }
}