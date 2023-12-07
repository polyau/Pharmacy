namespace Pharmacy
{
    partial class frmAnalogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalogs));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalogs = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblAnalogs = new System.Windows.Forms.DataGridView();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_findAnalogs = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnalogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(384, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Если ничего не отображается, это значит, что аналоги \r\nотсутствуют, либо введён н" +
    "еверный штрихкод";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnalogs
            // 
            this.btnAnalogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAnalogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalogs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnalogs.Location = new System.Drawing.Point(656, 175);
            this.btnAnalogs.Name = "btnAnalogs";
            this.btnAnalogs.Size = new System.Drawing.Size(82, 38);
            this.btnAnalogs.TabIndex = 8;
            this.btnAnalogs.Text = "найти";
            this.btnAnalogs.UseVisualStyleBackColor = false;
            this.btnAnalogs.Click += new System.EventHandler(this.btnAnalogs_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.Location = new System.Drawing.Point(494, 179);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(156, 30);
            this.txtBarcode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(237, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите штрихкод товара, для которого требуется найти аналоги\r\n";
            // 
            // tblAnalogs
            // 
            this.tblAnalogs.AllowUserToAddRows = false;
            this.tblAnalogs.AllowUserToDeleteRows = false;
            this.tblAnalogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblAnalogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAnalogs.Location = new System.Drawing.Point(242, 271);
            this.tblAnalogs.Name = "tblAnalogs";
            this.tblAnalogs.ReadOnly = true;
            this.tblAnalogs.RowHeadersWidth = 51;
            this.tblAnalogs.RowTemplate.Height = 24;
            this.tblAnalogs.Size = new System.Drawing.Size(761, 110);
            this.tblAnalogs.TabIndex = 5;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=VIVO;Initial Catalog=Pharmacy;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_findAnalogs
            // 
            this.sqlCommand_findAnalogs.CommandText = "SELECT * FROM dbo.findAnalogs(@Barcode)";
            this.sqlCommand_findAnalogs.Connection = this.sqlConnection;
            this.sqlCommand_findAnalogs.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.Char, 13)});
            // 
            // frmAnalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnalogs);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblAnalogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmAnalogs";
            this.Text = "Подбор аналогов";
            ((System.ComponentModel.ISupportInitialize)(this.tblAnalogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalogs;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblAnalogs;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_findAnalogs;
    }
}