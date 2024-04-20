namespace StockApp
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.grpSale = new System.Windows.Forms.GroupBox();
            this.btnListSale = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnListClient = new System.Windows.Forms.Button();
            this.btnClientCreate = new System.Windows.Forms.Button();
            this.grpMid = new System.Windows.Forms.GroupBox();
            this.panelClient = new System.Windows.Forms.Panel();
            this.panelClientTop = new System.Windows.Forms.Panel();
            this.panelClientUpdate = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTop.SuspendLayout();
            this.grpSale.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpMid.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.grpSale);
            this.grpTop.Controls.Add(this.grpProduct);
            this.grpTop.Controls.Add(this.grpClient);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1049, 112);
            this.grpTop.TabIndex = 0;
            this.grpTop.TabStop = false;
            // 
            // grpSale
            // 
            this.grpSale.Controls.Add(this.btnListSale);
            this.grpSale.Controls.Add(this.btnSale);
            this.grpSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSale.Location = new System.Drawing.Point(697, 16);
            this.grpSale.Name = "grpSale";
            this.grpSale.Size = new System.Drawing.Size(349, 93);
            this.grpSale.TabIndex = 2;
            this.grpSale.TabStop = false;
            this.grpSale.Text = "Satış";
            // 
            // btnListSale
            // 
            this.btnListSale.Location = new System.Drawing.Point(189, 24);
            this.btnListSale.Name = "btnListSale";
            this.btnListSale.Size = new System.Drawing.Size(109, 50);
            this.btnListSale.TabIndex = 1;
            this.btnListSale.Text = "Cari Listele";
            this.btnListSale.UseVisualStyleBackColor = true;
            this.btnListSale.Click += new System.EventHandler(this.btnListSale_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(45, 24);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(109, 50);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Cari Oluştur";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.btnListProduct);
            this.grpProduct.Controls.Add(this.btnProductCreate);
            this.grpProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpProduct.Location = new System.Drawing.Point(325, 16);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(372, 93);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Ürün";
            // 
            // btnListProduct
            // 
            this.btnListProduct.Location = new System.Drawing.Point(196, 24);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(109, 50);
            this.btnListProduct.TabIndex = 1;
            this.btnListProduct.Text = "Cari Listele";
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(52, 24);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(109, 50);
            this.btnProductCreate.TabIndex = 2;
            this.btnProductCreate.Text = "Ürün Oluştur";
            this.btnProductCreate.UseVisualStyleBackColor = true;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.btnListClient);
            this.grpClient.Controls.Add(this.btnClientCreate);
            this.grpClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpClient.Location = new System.Drawing.Point(3, 16);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(322, 93);
            this.grpClient.TabIndex = 2;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Cari";
            // 
            // btnListClient
            // 
            this.btnListClient.Location = new System.Drawing.Point(170, 24);
            this.btnListClient.Name = "btnListClient";
            this.btnListClient.Size = new System.Drawing.Size(109, 50);
            this.btnListClient.TabIndex = 0;
            this.btnListClient.Text = "Cari Listele";
            this.btnListClient.UseVisualStyleBackColor = true;
            this.btnListClient.Click += new System.EventHandler(this.btnListClient_Click);
            // 
            // btnClientCreate
            // 
            this.btnClientCreate.Location = new System.Drawing.Point(26, 24);
            this.btnClientCreate.Name = "btnClientCreate";
            this.btnClientCreate.Size = new System.Drawing.Size(109, 50);
            this.btnClientCreate.TabIndex = 0;
            this.btnClientCreate.Text = "Cari Oluştur";
            this.btnClientCreate.UseVisualStyleBackColor = true;
            // 
            // grpMid
            // 
            this.grpMid.Controls.Add(this.panelClient);
            this.grpMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMid.Location = new System.Drawing.Point(0, 112);
            this.grpMid.Name = "grpMid";
            this.grpMid.Size = new System.Drawing.Size(1049, 519);
            this.grpMid.TabIndex = 1;
            this.grpMid.TabStop = false;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.dataGridView1);
            this.panelClient.Controls.Add(this.panelClientUpdate);
            this.panelClient.Controls.Add(this.panelClientTop);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(3, 16);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1043, 500);
            this.panelClient.TabIndex = 0;
            // 
            // panelClientTop
            // 
            this.panelClientTop.AutoScroll = true;
            this.panelClientTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientTop.Location = new System.Drawing.Point(0, 0);
            this.panelClientTop.Name = "panelClientTop";
            this.panelClientTop.Size = new System.Drawing.Size(1043, 63);
            this.panelClientTop.TabIndex = 0;
            // 
            // panelClientUpdate
            // 
            this.panelClientUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClientUpdate.Location = new System.Drawing.Point(0, 63);
            this.panelClientUpdate.Name = "panelClientUpdate";
            this.panelClientUpdate.Size = new System.Drawing.Size(236, 437);
            this.panelClientUpdate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.slugDataGridViewTextBoxColumn,
            this.barcodeNoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stockAmountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.saleDetailsDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.modifiedAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(236, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 437);
            this.dataGridView1.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(StockApp.Data.Entity.Product);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 75F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // slugDataGridViewTextBoxColumn
            // 
            this.slugDataGridViewTextBoxColumn.DataPropertyName = "Slug";
            this.slugDataGridViewTextBoxColumn.FillWeight = 17.7665F;
            this.slugDataGridViewTextBoxColumn.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn.Name = "slugDataGridViewTextBoxColumn";
            this.slugDataGridViewTextBoxColumn.ReadOnly = true;
            this.slugDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeNoDataGridViewTextBoxColumn
            // 
            this.barcodeNoDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.barcodeNoDataGridViewTextBoxColumn.HeaderText = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn.Name = "barcodeNoDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 40F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // stockAmountDataGridViewTextBoxColumn
            // 
            this.stockAmountDataGridViewTextBoxColumn.DataPropertyName = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.FillWeight = 20F;
            this.stockAmountDataGridViewTextBoxColumn.HeaderText = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.Name = "stockAmountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 20F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // saleDetailsDataGridViewTextBoxColumn
            // 
            this.saleDetailsDataGridViewTextBoxColumn.DataPropertyName = "SaleDetails";
            this.saleDetailsDataGridViewTextBoxColumn.HeaderText = "SaleDetails";
            this.saleDetailsDataGridViewTextBoxColumn.Name = "saleDetailsDataGridViewTextBoxColumn";
            this.saleDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.FillWeight = 20F;
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // modifiedAtDataGridViewTextBoxColumn
            // 
            this.modifiedAtDataGridViewTextBoxColumn.DataPropertyName = "ModifiedAt";
            this.modifiedAtDataGridViewTextBoxColumn.HeaderText = "ModifiedAt";
            this.modifiedAtDataGridViewTextBoxColumn.Name = "modifiedAtDataGridViewTextBoxColumn";
            this.modifiedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 631);
            this.Controls.Add(this.grpMid);
            this.Controls.Add(this.grpTop);
            this.MinimumSize = new System.Drawing.Size(1065, 670);
            this.Name = "FormMain";
            this.Text = "Ana Sayfa";
            this.grpTop.ResumeLayout(false);
            this.grpSale.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpClient.ResumeLayout(false);
            this.grpMid.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.GroupBox grpSale;
        private System.Windows.Forms.Button btnListSale;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnListProduct;
        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.Button btnListClient;
        private System.Windows.Forms.Button btnClientCreate;
        private System.Windows.Forms.GroupBox grpMid;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Panel panelClientTop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Panel panelClientUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtDataGridViewTextBoxColumn;
    }
}

