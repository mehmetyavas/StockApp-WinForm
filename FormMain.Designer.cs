using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.panelClientTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.columnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelProductTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrdSearch = new System.Windows.Forms.TextBox();
            this.btnClientRefresh = new System.Windows.Forms.Button();
            this.btnPrdRefresh = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnClientDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpTop.SuspendLayout();
            this.grpSale.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpMid.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.panelClientTop.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panelProductTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
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
            this.btnListProduct.Text = "Ürün Listele";
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
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
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
            this.btnClientCreate.Click += new System.EventHandler(this.btnClientCreate_Click);
            // 
            // grpMid
            // 
            this.grpMid.Controls.Add(this.panelClient);
            this.grpMid.Controls.Add(this.panelProduct);
            this.grpMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMid.Location = new System.Drawing.Point(0, 112);
            this.grpMid.Name = "grpMid";
            this.grpMid.Size = new System.Drawing.Size(1049, 519);
            this.grpMid.TabIndex = 1;
            this.grpMid.TabStop = false;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.dataGridViewClient);
            this.panelClient.Controls.Add(this.panelClientTop);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(3, 16);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1043, 500);
            this.panelClient.TabIndex = 1;
            this.panelClient.Visible = false;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn1,
            this.modifiedAtDataGridViewTextBoxColumn1,
            this.ColumnClientUpdate,
            this.ColumnClientDelete});
            this.dataGridViewClient.DataSource = this.clientBindingSource;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(1043, 437);
            this.dataGridViewClient.TabIndex = 1;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // panelClientTop
            // 
            this.panelClientTop.Controls.Add(this.btnClientRefresh);
            this.panelClientTop.Controls.Add(this.label2);
            this.panelClientTop.Controls.Add(this.txtClientSearch);
            this.panelClientTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientTop.Location = new System.Drawing.Point(0, 0);
            this.panelClientTop.Name = "panelClientTop";
            this.panelClientTop.Size = new System.Drawing.Size(1043, 63);
            this.panelClientTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEARCH:";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtClientSearch.Location = new System.Drawing.Point(95, 19);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(257, 26);
            this.txtClientSearch.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.dataGridProduct);
            this.panelProduct.Controls.Add(this.panelProductTop);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(3, 16);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1043, 500);
            this.panelProduct.TabIndex = 0;
            this.panelProduct.Visible = false;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoGenerateColumns = false;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeNoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stockAmountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.saleDetailsDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.modifiedAtDataGridViewTextBoxColumn,
            this.columnUpdate,
            this.columnDelete});
            this.dataGridProduct.DataSource = this.productBindingSource;
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 63);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.Size = new System.Drawing.Size(1043, 437);
            this.dataGridProduct.TabIndex = 2;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // columnUpdate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.columnUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnUpdate.FillWeight = 15F;
            this.columnUpdate.HeaderText = "Güncelle";
            this.columnUpdate.Name = "columnUpdate";
            this.columnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnDelete
            // 
            this.columnDelete.FillWeight = 10F;
            this.columnDelete.HeaderText = "Sil";
            this.columnDelete.Name = "columnDelete";
            // 
            // panelProductTop
            // 
            this.panelProductTop.AutoScroll = true;
            this.panelProductTop.Controls.Add(this.btnPrdRefresh);
            this.panelProductTop.Controls.Add(this.label1);
            this.panelProductTop.Controls.Add(this.txtPrdSearch);
            this.panelProductTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductTop.Location = new System.Drawing.Point(0, 0);
            this.panelProductTop.Name = "panelProductTop";
            this.panelProductTop.Size = new System.Drawing.Size(1043, 63);
            this.panelProductTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH:";
            // 
            // txtPrdSearch
            // 
            this.txtPrdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPrdSearch.Location = new System.Drawing.Point(95, 19);
            this.txtPrdSearch.Name = "txtPrdSearch";
            this.txtPrdSearch.Size = new System.Drawing.Size(257, 26);
            this.txtPrdSearch.TabIndex = 0;
            // 
            // btnClientRefresh
            // 
            this.btnClientRefresh.Location = new System.Drawing.Point(937, 15);
            this.btnClientRefresh.Name = "btnClientRefresh";
            this.btnClientRefresh.Size = new System.Drawing.Size(97, 37);
            this.btnClientRefresh.TabIndex = 2;
            this.btnClientRefresh.Text = "Yenile";
            this.btnClientRefresh.UseVisualStyleBackColor = true;
            this.btnClientRefresh.Click += new System.EventHandler(this.btnClientRefresh_Click);
            // 
            // btnPrdRefresh
            // 
            this.btnPrdRefresh.Location = new System.Drawing.Point(937, 15);
            this.btnPrdRefresh.Name = "btnPrdRefresh";
            this.btnPrdRefresh.Size = new System.Drawing.Size(97, 37);
            this.btnPrdRefresh.TabIndex = 3;
            this.btnPrdRefresh.Text = "Yenile";
            this.btnPrdRefresh.UseVisualStyleBackColor = true;
            this.btnPrdRefresh.Click += new System.EventHandler(this.btnPrdRefresh_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(StockApp.Data.Entity.Client);
            // 
            // barcodeNoDataGridViewTextBoxColumn
            // 
            this.barcodeNoDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.barcodeNoDataGridViewTextBoxColumn.HeaderText = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn.Name = "barcodeNoDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 75F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            this.createdAtDataGridViewTextBoxColumn.FillWeight = 30F;
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(StockApp.Data.Entity.Product);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 35.28266F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 35.28266F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 35.28266F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 35.28266F;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            this.salesDataGridViewTextBoxColumn.FillWeight = 35.28266F;
            this.salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            this.salesDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            this.createdAtDataGridViewTextBoxColumn1.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn1.FillWeight = 35.28266F;
            this.createdAtDataGridViewTextBoxColumn1.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn1.Name = "createdAtDataGridViewTextBoxColumn1";
            // 
            // modifiedAtDataGridViewTextBoxColumn1
            // 
            this.modifiedAtDataGridViewTextBoxColumn1.DataPropertyName = "ModifiedAt";
            this.modifiedAtDataGridViewTextBoxColumn1.HeaderText = "ModifiedAt";
            this.modifiedAtDataGridViewTextBoxColumn1.Name = "modifiedAtDataGridViewTextBoxColumn1";
            this.modifiedAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ColumnClientUpdate
            // 
            this.ColumnClientUpdate.FillWeight = 18.48571F;
            this.ColumnClientUpdate.HeaderText = "Güncelle";
            this.ColumnClientUpdate.Name = "ColumnClientUpdate";
            this.ColumnClientUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnClientUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnClientDelete
            // 
            this.ColumnClientDelete.FillWeight = 12.59731F;
            this.ColumnClientDelete.HeaderText = "Sil";
            this.ColumnClientDelete.Name = "ColumnClientDelete";
            this.ColumnClientDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnClientDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.panelClientTop.ResumeLayout(false);
            this.panelClientTop.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panelProductTop.ResumeLayout(false);
            this.panelProductTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelProductTop;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrdSearch;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Panel panelClientTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn columnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn columnDelete;
        private System.Windows.Forms.Button btnClientRefresh;
        private System.Windows.Forms.Button btnPrdRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnClientUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnClientDelete;
    }
}

