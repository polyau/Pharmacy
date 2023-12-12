namespace Pharmacy
{
    partial class frmDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirector));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSotr = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCassa = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(365, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите, с чем хотите работать";
            // 
            // btnSotr
            // 
            this.btnSotr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSotr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSotr.Location = new System.Drawing.Point(463, 319);
            this.btnSotr.Name = "btnSotr";
            this.btnSotr.Size = new System.Drawing.Size(213, 43);
            this.btnSotr.TabIndex = 4;
            this.btnSotr.Text = "Учет персонала";
            this.btnSotr.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Location = new System.Drawing.Point(463, 258);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(213, 43);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Учет товаров";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCassa
            // 
            this.btnCassa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCassa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCassa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCassa.Location = new System.Drawing.Point(463, 380);
            this.btnCassa.Name = "btnCassa";
            this.btnCassa.Size = new System.Drawing.Size(213, 43);
            this.btnCassa.TabIndex = 6;
            this.btnCassa.Text = "Касса";
            this.btnCassa.UseVisualStyleBackColor = false;
            this.btnCassa.Click += new System.EventHandler(this.btnCassa_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1011, 582);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCassa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSotr);
            this.Controls.Add(this.btnProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmDirector";
            this.Text = "Директор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSotr;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCassa;
        private System.Windows.Forms.Button btnBack;
    }
}