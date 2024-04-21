namespace StockApp
{
    partial class FormCreateProduct
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
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.grpProductCreate = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.grpProductCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(220, 198);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(98, 37);
            this.btnProductCreate.TabIndex = 0;
            this.btnProductCreate.Text = "Kaydet";
            this.btnProductCreate.UseVisualStyleBackColor = true;
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
            // 
            // grpProductCreate
            // 
            this.grpProductCreate.Controls.Add(this.label5);
            this.grpProductCreate.Controls.Add(this.label4);
            this.grpProductCreate.Controls.Add(this.label2);
            this.grpProductCreate.Controls.Add(this.label3);
            this.grpProductCreate.Controls.Add(this.txtProductBarcode);
            this.grpProductCreate.Controls.Add(this.label1);
            this.grpProductCreate.Controls.Add(this.txtProductPrice);
            this.grpProductCreate.Controls.Add(this.txtProductDesc);
            this.grpProductCreate.Controls.Add(this.txtProductAmount);
            this.grpProductCreate.Controls.Add(this.txtProductName);
            this.grpProductCreate.Controls.Add(this.btnProductCreate);
            this.grpProductCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProductCreate.Location = new System.Drawing.Point(0, 0);
            this.grpProductCreate.Name = "grpProductCreate";
            this.grpProductCreate.Size = new System.Drawing.Size(384, 311);
            this.grpProductCreate.TabIndex = 1;
            this.grpProductCreate.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(106, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(106, 63);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(212, 20);
            this.txtProductDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok Adeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyatı";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Location = new System.Drawing.Point(106, 162);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(212, 20);
            this.txtProductBarcode.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Barkod No";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(106, 96);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(212, 20);
            this.txtProductAmount.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(106, 129);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(212, 20);
            this.txtProductPrice.TabIndex = 2;
            // 
            // FormCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.grpProductCreate);
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "FormCreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Oluştur";
            this.grpProductCreate.ResumeLayout(false);
            this.grpProductCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.GroupBox grpProductCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductAmount;
    }
}