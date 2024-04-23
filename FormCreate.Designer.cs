namespace StockApp
{
    partial class FormCreate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.grpCreateClient = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.grpProductCreate.SuspendLayout();
            this.grpCreateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(220, 198);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(98, 37);
            this.btnProductCreate.TabIndex = 6;
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
            this.grpProductCreate.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyatı";
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
            // txtProductBarcode
            // 
            this.txtProductBarcode.Location = new System.Drawing.Point(106, 162);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(212, 20);
            this.txtProductBarcode.TabIndex = 5;
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
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(106, 129);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(212, 20);
            this.txtProductPrice.TabIndex = 4;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(106, 63);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(212, 20);
            this.txtProductDesc.TabIndex = 2;
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(106, 96);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(212, 20);
            this.txtProductAmount.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(106, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // grpCreateClient
            // 
            this.grpCreateClient.Controls.Add(this.label6);
            this.grpCreateClient.Controls.Add(this.label7);
            this.grpCreateClient.Controls.Add(this.label8);
            this.grpCreateClient.Controls.Add(this.label9);
            this.grpCreateClient.Controls.Add(this.txtPhone);
            this.grpCreateClient.Controls.Add(this.txtEmail);
            this.grpCreateClient.Controls.Add(this.txtFirstName);
            this.grpCreateClient.Controls.Add(this.txtLastName);
            this.grpCreateClient.Controls.Add(this.btnCreateClient);
            this.grpCreateClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCreateClient.Location = new System.Drawing.Point(0, 0);
            this.grpCreateClient.Name = "grpCreateClient";
            this.grpCreateClient.Size = new System.Drawing.Size(384, 311);
            this.grpCreateClient.TabIndex = 4;
            this.grpCreateClient.TabStop = false;
            this.grpCreateClient.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Soyad";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(81, 126);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(81, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(81, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(195, 162);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(98, 37);
            this.btnCreateClient.TabIndex = 5;
            this.btnCreateClient.Text = "Kaydet";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.grpCreateClient);
            this.Controls.Add(this.grpProductCreate);
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "FormCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpProductCreate.ResumeLayout(false);
            this.grpProductCreate.PerformLayout();
            this.grpCreateClient.ResumeLayout(false);
            this.grpCreateClient.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpCreateClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCreateClient;
    }
}