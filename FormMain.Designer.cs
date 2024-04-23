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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnListClient = new System.Windows.Forms.Button();
            this.btnClientCreate = new System.Windows.Forms.Button();
            this.btnSelectedSalePrd = new System.Windows.Forms.Button();
            this.grpMid = new System.Windows.Forms.GroupBox();
            this.panelClientSale = new System.Windows.Forms.Panel();
            this.dataGridViewSaleDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.grpClientSaleLeft = new System.Windows.Forms.GroupBox();
            this.btnClientSaleBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClientSalePhone = new System.Windows.Forms.Label();
            this.lblClientSaleLastName = new System.Windows.Forms.Label();
            this.lblClientSaleEmail = new System.Windows.Forms.Label();
            this.lblClientSaleFirstName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSale = new System.Windows.Forms.Panel();
            this.GridViewSaleProduct = new System.Windows.Forms.DataGridView();
            this.ColumnSaleCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSaleLeft = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastNAme = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSaleTop = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalePrd = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelClient = new System.Windows.Forms.Panel();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.ColumnClientUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnClientDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelClientTop = new System.Windows.Forms.Panel();
            this.btnClientSale = new System.Windows.Forms.Button();
            this.btnSalePrd = new System.Windows.Forms.Button();
            this.btnClientRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.columnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelProductTop = new System.Windows.Forms.Panel();
            this.btnPrdRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrdSearch = new System.Windows.Forms.TextBox();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailProductDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeNoPrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionPrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAmountPrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrdGridDataGridViewSalePrdTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtPrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedAtPrdGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpTop.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpMid.SuspendLayout();
            this.panelClientSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.grpClientSaleLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSaleProduct)).BeginInit();
            this.grpSaleLeft.SuspendLayout();
            this.grpSaleTop.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.panelClientTop.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panelProductTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailProductDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.grpProduct);
            this.grpTop.Controls.Add(this.grpClient);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1049, 112);
            this.grpTop.TabIndex = 0;
            this.grpTop.TabStop = false;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.btnListProduct);
            this.grpProduct.Controls.Add(this.btnProductCreate);
            this.grpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProduct.Location = new System.Drawing.Point(501, 16);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(545, 93);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Ürün";
            // 
            // btnListProduct
            // 
            this.btnListProduct.Location = new System.Drawing.Point(312, 24);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(140, 50);
            this.btnListProduct.TabIndex = 1;
            this.btnListProduct.Text = "Ürün Listele";
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(78, 24);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(140, 50);
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
            this.grpClient.Size = new System.Drawing.Size(498, 93);
            this.grpClient.TabIndex = 2;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Cari";
            // 
            // btnListClient
            // 
            this.btnListClient.Location = new System.Drawing.Point(289, 24);
            this.btnListClient.Name = "btnListClient";
            this.btnListClient.Size = new System.Drawing.Size(140, 50);
            this.btnListClient.TabIndex = 0;
            this.btnListClient.Text = "Cari Listele";
            this.btnListClient.UseVisualStyleBackColor = true;
            this.btnListClient.Click += new System.EventHandler(this.btnListClient_Click);
            // 
            // btnClientCreate
            // 
            this.btnClientCreate.Location = new System.Drawing.Point(55, 24);
            this.btnClientCreate.Name = "btnClientCreate";
            this.btnClientCreate.Size = new System.Drawing.Size(140, 50);
            this.btnClientCreate.TabIndex = 0;
            this.btnClientCreate.Text = "Cari Oluştur";
            this.btnClientCreate.UseVisualStyleBackColor = true;
            this.btnClientCreate.Click += new System.EventHandler(this.btnClientCreate_Click);
            // 
            // btnSelectedSalePrd
            // 
            this.btnSelectedSalePrd.Location = new System.Drawing.Point(928, 30);
            this.btnSelectedSalePrd.Name = "btnSelectedSalePrd";
            this.btnSelectedSalePrd.Size = new System.Drawing.Size(109, 50);
            this.btnSelectedSalePrd.TabIndex = 1;
            this.btnSelectedSalePrd.Text = "Sat";
            this.btnSelectedSalePrd.UseVisualStyleBackColor = true;
            this.btnSelectedSalePrd.Click += new System.EventHandler(this.btnSelectedSalePrd_Click);
            // 
            // grpMid
            // 
            this.grpMid.Controls.Add(this.panelClientSale);
            this.grpMid.Controls.Add(this.panelSale);
            this.grpMid.Controls.Add(this.panelClient);
            this.grpMid.Controls.Add(this.panelProduct);
            this.grpMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMid.Location = new System.Drawing.Point(0, 112);
            this.grpMid.Name = "grpMid";
            this.grpMid.Size = new System.Drawing.Size(1049, 681);
            this.grpMid.TabIndex = 1;
            this.grpMid.TabStop = false;
            // 
            // panelClientSale
            // 
            this.panelClientSale.Controls.Add(this.dataGridViewSaleDetail);
            this.panelClientSale.Controls.Add(this.dataGridViewSale);
            this.panelClientSale.Controls.Add(this.grpClientSaleLeft);
            this.panelClientSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientSale.Location = new System.Drawing.Point(3, 16);
            this.panelClientSale.Name = "panelClientSale";
            this.panelClientSale.Size = new System.Drawing.Size(1043, 662);
            this.panelClientSale.TabIndex = 4;
            this.panelClientSale.Visible = false;
            // 
            // dataGridViewSaleDetail
            // 
            this.dataGridViewSaleDetail.AutoGenerateColumns = false;
            this.dataGridViewSaleDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.barcodeNoDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridViewSaleDetail.DataSource = this.saleDetailProductDtoBindingSource;
            this.dataGridViewSaleDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleDetail.Location = new System.Drawing.Point(250, 259);
            this.dataGridViewSaleDetail.Name = "dataGridViewSaleDetail";
            this.dataGridViewSaleDetail.Size = new System.Drawing.Size(793, 403);
            this.dataGridViewSaleDetail.TabIndex = 5;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.AutoGenerateColumns = false;
            this.dataGridViewSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.saleDetailsDataGridViewTextBoxColumn1,
            this.ıdDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn1,
            this.modifiedAtDataGridViewTextBoxColumn1});
            this.dataGridViewSale.DataSource = this.saleBindingSource;
            this.dataGridViewSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSale.Location = new System.Drawing.Point(250, 0);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.Size = new System.Drawing.Size(793, 259);
            this.dataGridViewSale.TabIndex = 4;
            this.dataGridViewSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSale_CellClick);
            // 
            // grpClientSaleLeft
            // 
            this.grpClientSaleLeft.Controls.Add(this.btnClientSaleBack);
            this.grpClientSaleLeft.Controls.Add(this.groupBox1);
            this.grpClientSaleLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpClientSaleLeft.Location = new System.Drawing.Point(0, 0);
            this.grpClientSaleLeft.Name = "grpClientSaleLeft";
            this.grpClientSaleLeft.Size = new System.Drawing.Size(250, 662);
            this.grpClientSaleLeft.TabIndex = 3;
            this.grpClientSaleLeft.TabStop = false;
            // 
            // btnClientSaleBack
            // 
            this.btnClientSaleBack.Image = global::StockApp.Properties.Resources.back1;
            this.btnClientSaleBack.Location = new System.Drawing.Point(9, 25);
            this.btnClientSaleBack.Name = "btnClientSaleBack";
            this.btnClientSaleBack.Size = new System.Drawing.Size(66, 45);
            this.btnClientSaleBack.TabIndex = 3;
            this.btnClientSaleBack.UseVisualStyleBackColor = true;
            this.btnClientSaleBack.Click += new System.EventHandler(this.btnClientSaleBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClientSalePhone);
            this.groupBox1.Controls.Add(this.lblClientSaleLastName);
            this.groupBox1.Controls.Add(this.lblClientSaleEmail);
            this.groupBox1.Controls.Add(this.lblClientSaleFirstName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblClientSalePhone
            // 
            this.lblClientSalePhone.AutoSize = true;
            this.lblClientSalePhone.Location = new System.Drawing.Point(109, 165);
            this.lblClientSalePhone.Name = "lblClientSalePhone";
            this.lblClientSalePhone.Size = new System.Drawing.Size(35, 13);
            this.lblClientSalePhone.TabIndex = 0;
            this.lblClientSalePhone.Text = "label5";
            // 
            // lblClientSaleLastName
            // 
            this.lblClientSaleLastName.AutoSize = true;
            this.lblClientSaleLastName.Location = new System.Drawing.Point(109, 97);
            this.lblClientSaleLastName.Name = "lblClientSaleLastName";
            this.lblClientSaleLastName.Size = new System.Drawing.Size(35, 13);
            this.lblClientSaleLastName.TabIndex = 0;
            this.lblClientSaleLastName.Text = "label5";
            // 
            // lblClientSaleEmail
            // 
            this.lblClientSaleEmail.AutoSize = true;
            this.lblClientSaleEmail.Location = new System.Drawing.Point(109, 131);
            this.lblClientSaleEmail.Name = "lblClientSaleEmail";
            this.lblClientSaleEmail.Size = new System.Drawing.Size(35, 13);
            this.lblClientSaleEmail.TabIndex = 0;
            this.lblClientSaleEmail.Text = "label5";
            // 
            // lblClientSaleFirstName
            // 
            this.lblClientSaleFirstName.AutoSize = true;
            this.lblClientSaleFirstName.Location = new System.Drawing.Point(109, 63);
            this.lblClientSaleFirstName.Name = "lblClientSaleFirstName";
            this.lblClientSaleFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblClientSaleFirstName.TabIndex = 0;
            this.lblClientSaleFirstName.Text = "label5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad:";
            // 
            // panelSale
            // 
            this.panelSale.Controls.Add(this.GridViewSaleProduct);
            this.panelSale.Controls.Add(this.grpSaleLeft);
            this.panelSale.Controls.Add(this.grpSaleTop);
            this.panelSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSale.Location = new System.Drawing.Point(3, 16);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(1043, 662);
            this.panelSale.TabIndex = 3;
            this.panelSale.Visible = false;
            // 
            // GridViewSaleProduct
            // 
            this.GridViewSaleProduct.AutoGenerateColumns = false;
            this.GridViewSaleProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewSaleProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSaleProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSaleCheckBox,
            this.barcodeNoPrdGridDataGridViewTextBoxColumn,
            this.namePrdGridDataGridViewTextBoxColumn,
            this.descriptionPrdGridDataGridViewTextBoxColumn,
            this.ColumnAdet,
            this.stockAmountPrdGridDataGridViewTextBoxColumn,
            this.pricePrdGridDataGridViewTextBoxColumn,
            this.idPrdGridDataGridViewSalePrdTextBoxColumn});
            this.GridViewSaleProduct.DataSource = this.productGridBindingSource;
            this.GridViewSaleProduct.Location = new System.Drawing.Point(233, 86);
            this.GridViewSaleProduct.Name = "GridViewSaleProduct";
            this.GridViewSaleProduct.Size = new System.Drawing.Size(810, 576);
            this.GridViewSaleProduct.TabIndex = 2;
            this.GridViewSaleProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSaleProduct_CellValueChanged);
            // 
            // ColumnSaleCheckBox
            // 
            this.ColumnSaleCheckBox.HeaderText = "Seç";
            this.ColumnSaleCheckBox.Name = "ColumnSaleCheckBox";
            this.ColumnSaleCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSaleCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnAdet
            // 
            this.ColumnAdet.DataPropertyName = "Adet";
            this.ColumnAdet.HeaderText = "Adet";
            this.ColumnAdet.Name = "ColumnAdet";
            this.ColumnAdet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grpSaleLeft
            // 
            this.grpSaleLeft.Controls.Add(this.lblPhone);
            this.grpSaleLeft.Controls.Add(this.lblLastNAme);
            this.grpSaleLeft.Controls.Add(this.label9);
            this.grpSaleLeft.Controls.Add(this.label6);
            this.grpSaleLeft.Controls.Add(this.lblEmail);
            this.grpSaleLeft.Controls.Add(this.lblFirstName);
            this.grpSaleLeft.Controls.Add(this.label7);
            this.grpSaleLeft.Controls.Add(this.label3);
            this.grpSaleLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSaleLeft.Location = new System.Drawing.Point(0, 86);
            this.grpSaleLeft.Name = "grpSaleLeft";
            this.grpSaleLeft.Size = new System.Drawing.Size(233, 576);
            this.grpSaleLeft.TabIndex = 1;
            this.grpSaleLeft.TabStop = false;
            this.grpSaleLeft.Text = "Cari Bilgisi";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(94, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "label5";
            // 
            // lblLastNAme
            // 
            this.lblLastNAme.AutoSize = true;
            this.lblLastNAme.Location = new System.Drawing.Point(94, 98);
            this.lblLastNAme.Name = "lblLastNAme";
            this.lblLastNAme.Size = new System.Drawing.Size(35, 13);
            this.lblLastNAme.TabIndex = 3;
            this.lblLastNAme.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soyad:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "label4";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(94, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad:";
            // 
            // grpSaleTop
            // 
            this.grpSaleTop.Controls.Add(this.btnSelectedSalePrd);
            this.grpSaleTop.Controls.Add(this.label4);
            this.grpSaleTop.Controls.Add(this.txtSalePrd);
            this.grpSaleTop.Controls.Add(this.btnBack);
            this.grpSaleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSaleTop.Location = new System.Drawing.Point(0, 0);
            this.grpSaleTop.Name = "grpSaleTop";
            this.grpSaleTop.Size = new System.Drawing.Size(1043, 86);
            this.grpSaleTop.TabIndex = 0;
            this.grpSaleTop.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(236, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "SEARCH:";
            // 
            // txtSalePrd
            // 
            this.txtSalePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSalePrd.Location = new System.Drawing.Point(322, 37);
            this.txtSalePrd.Name = "txtSalePrd";
            this.txtSalePrd.Size = new System.Drawing.Size(257, 26);
            this.txtSalePrd.TabIndex = 3;
            this.txtSalePrd.TextChanged += new System.EventHandler(this.txtSalePrd_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::StockApp.Properties.Resources.back1;
            this.btnBack.Location = new System.Drawing.Point(9, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 45);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.dataGridViewClient);
            this.panelClient.Controls.Add(this.panelClientTop);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(3, 16);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1043, 662);
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
            this.createdAtPrdGridDataGridViewTextBoxColumn,
            this.modifiedAtPrdGridDataGridViewTextBoxColumn,
            this.ColumnClientUpdate,
            this.ColumnClientDelete});
            this.dataGridViewClient.DataSource = this.clientBindingSource;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(1043, 599);
            this.dataGridViewClient.TabIndex = 1;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // ColumnClientUpdate
            // 
            this.ColumnClientUpdate.FillWeight = 19.0511F;
            this.ColumnClientUpdate.HeaderText = "Güncelle";
            this.ColumnClientUpdate.Name = "ColumnClientUpdate";
            this.ColumnClientUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnClientUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;

            this.ColumnClientUpdate.DefaultCellStyle.BackColor = Color.LightGreen;
            // 
            // ColumnClientDelete
            // 
            this.ColumnClientDelete.FillWeight = 12.9826F;
            this.ColumnClientDelete.HeaderText = "Sil";
            this.ColumnClientDelete.Name = "ColumnClientDelete";
            this.ColumnClientDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnClientDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;

            this.ColumnClientDelete.DefaultCellStyle.BackColor = Color.MediumVioletRed;
            // 
            // panelClientTop
            // 
            this.panelClientTop.Controls.Add(this.btnClientSale);
            this.panelClientTop.Controls.Add(this.btnSalePrd);
            this.panelClientTop.Controls.Add(this.btnClientRefresh);
            this.panelClientTop.Controls.Add(this.label2);
            this.panelClientTop.Controls.Add(this.txtClientSearch);
            this.panelClientTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientTop.Location = new System.Drawing.Point(0, 0);
            this.panelClientTop.Name = "panelClientTop";
            this.panelClientTop.Size = new System.Drawing.Size(1043, 63);
            this.panelClientTop.TabIndex = 0;
            // 
            // btnClientSale
            // 
            this.btnClientSale.Enabled = false;
            this.btnClientSale.Location = new System.Drawing.Point(612, 15);
            this.btnClientSale.Name = "btnClientSale";
            this.btnClientSale.Size = new System.Drawing.Size(104, 37);
            this.btnClientSale.TabIndex = 2;
            this.btnClientSale.Text = "Satışlar";
            this.btnClientSale.UseVisualStyleBackColor = true;
            this.btnClientSale.Click += new System.EventHandler(this.btnClientSale_Click);
            // 
            // btnSalePrd
            // 
            this.btnSalePrd.Enabled = false;
            this.btnSalePrd.Location = new System.Drawing.Point(822, 15);
            this.btnSalePrd.Name = "btnSalePrd";
            this.btnSalePrd.Size = new System.Drawing.Size(97, 37);
            this.btnSalePrd.TabIndex = 2;
            this.btnSalePrd.Text = "Satış Yap";
            this.btnSalePrd.UseVisualStyleBackColor = true;
            this.btnSalePrd.Click += new System.EventHandler(this.btnSalePrd_Click);
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
            this.panelProduct.Size = new System.Drawing.Size(1043, 662);
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
            this.dataGridProduct.Size = new System.Drawing.Size(1043, 599);
            this.dataGridProduct.TabIndex = 2;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // columnUpdate
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.columnUpdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnUpdate.FillWeight = 15F;
            this.columnUpdate.HeaderText = "Güncelle";
            this.columnUpdate.Name = "columnUpdate";
            this.columnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnUpdate.DefaultCellStyle.BackColor = Color.LightGreen;
            // 
            // columnDelete
            // 
            this.columnDelete.FillWeight = 10F;
            this.columnDelete.HeaderText = "Sil";
            this.columnDelete.Name = "columnDelete";

            this.columnDelete.DefaultCellStyle.BackColor = Color.MediumVioletRed;
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
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // barcodeNoDataGridViewTextBoxColumn1
            // 
            this.barcodeNoDataGridViewTextBoxColumn1.DataPropertyName = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn1.HeaderText = "BarcodeNo";
            this.barcodeNoDataGridViewTextBoxColumn1.Name = "barcodeNoDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // saleDetailProductDtoBindingSource
            // 
            this.saleDetailProductDtoBindingSource.DataSource = typeof(StockApp.Data.Dto.SaleDetailProductDto);
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleDetailsDataGridViewTextBoxColumn1
            // 
            this.saleDetailsDataGridViewTextBoxColumn1.DataPropertyName = "SaleDetails";
            this.saleDetailsDataGridViewTextBoxColumn1.HeaderText = "SaleDetails";
            this.saleDetailsDataGridViewTextBoxColumn1.Name = "saleDetailsDataGridViewTextBoxColumn1";
            this.saleDetailsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            this.createdAtDataGridViewTextBoxColumn1.DataPropertyName = "CreatedAt";
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
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(StockApp.Data.Entity.Sale);
            // 
            // barcodeNoPrdGridDataGridViewTextBoxColumn
            // 
            this.barcodeNoPrdGridDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNo";
            this.barcodeNoPrdGridDataGridViewTextBoxColumn.HeaderText = "BarcodeNo";
            this.barcodeNoPrdGridDataGridViewTextBoxColumn.Name = "barcodeNoPrdGridDataGridViewTextBoxColumn";
            // 
            // namePrdGridDataGridViewTextBoxColumn
            // 
            this.namePrdGridDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.namePrdGridDataGridViewTextBoxColumn.HeaderText = "Name";
            this.namePrdGridDataGridViewTextBoxColumn.Name = "namePrdGridDataGridViewTextBoxColumn";
            // 
            // descriptionPrdGridDataGridViewTextBoxColumn
            // 
            this.descriptionPrdGridDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionPrdGridDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionPrdGridDataGridViewTextBoxColumn.Name = "descriptionPrdGridDataGridViewTextBoxColumn";
            // 
            // stockAmountPrdGridDataGridViewTextBoxColumn
            // 
            this.stockAmountPrdGridDataGridViewTextBoxColumn.DataPropertyName = "StockAmount";
            this.stockAmountPrdGridDataGridViewTextBoxColumn.HeaderText = "StockAmount";
            this.stockAmountPrdGridDataGridViewTextBoxColumn.Name = "stockAmountPrdGridDataGridViewTextBoxColumn";
            // 
            // pricePrdGridDataGridViewTextBoxColumn
            // 
            this.pricePrdGridDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.pricePrdGridDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pricePrdGridDataGridViewTextBoxColumn.Name = "pricePrdGridDataGridViewTextBoxColumn";
            // 
            // idPrdGridDataGridViewSalePrdTextBoxColumn
            // 
            this.idPrdGridDataGridViewSalePrdTextBoxColumn.DataPropertyName = "Id";
            this.idPrdGridDataGridViewSalePrdTextBoxColumn.HeaderText = "Id";
            this.idPrdGridDataGridViewSalePrdTextBoxColumn.Name = "idPrdGridDataGridViewSalePrdTextBoxColumn";
            this.idPrdGridDataGridViewSalePrdTextBoxColumn.Visible = false;
            // 
            // productGridBindingSource
            // 
            this.productGridBindingSource.DataSource = typeof(StockApp.Data.Entity.ProductGrid);
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
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 36.36178F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 36.36178F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 36.36178F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 36.36178F;
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
            // createdAtPrdGridDataGridViewTextBoxColumn
            // 
            this.createdAtPrdGridDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtPrdGridDataGridViewTextBoxColumn.FillWeight = 36.36178F;
            this.createdAtPrdGridDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtPrdGridDataGridViewTextBoxColumn.Name = "createdAtPrdGridDataGridViewTextBoxColumn";
            // 
            // modifiedAtPrdGridDataGridViewTextBoxColumn
            // 
            this.modifiedAtPrdGridDataGridViewTextBoxColumn.DataPropertyName = "ModifiedAt";
            this.modifiedAtPrdGridDataGridViewTextBoxColumn.HeaderText = "ModifiedAt";
            this.modifiedAtPrdGridDataGridViewTextBoxColumn.Name = "modifiedAtPrdGridDataGridViewTextBoxColumn";
            this.modifiedAtPrdGridDataGridViewTextBoxColumn.Visible = false;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 793);
            this.Controls.Add(this.grpMid);
            this.Controls.Add(this.grpTop);
            this.MinimumSize = new System.Drawing.Size(1065, 670);
            this.Name = "FormMain";
            this.Text = "Ana Sayfa";
            this.grpTop.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpClient.ResumeLayout(false);
            this.grpMid.ResumeLayout(false);
            this.panelClientSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.grpClientSaleLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSaleProduct)).EndInit();
            this.grpSaleLeft.ResumeLayout(false);
            this.grpSaleLeft.PerformLayout();
            this.grpSaleTop.ResumeLayout(false);
            this.grpSaleTop.PerformLayout();
            this.panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.panelClientTop.ResumeLayout(false);
            this.panelClientTop.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panelProductTop.ResumeLayout(false);
            this.panelProductTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailProductDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Button btnSelectedSalePrd;
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
        private System.Windows.Forms.DataGridViewButtonColumn ColumnClientUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnClientDelete;
        private System.Windows.Forms.Button btnSalePrd;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.DataGridView GridViewSaleProduct;
        private System.Windows.Forms.GroupBox grpSaleLeft;
        private System.Windows.Forms.GroupBox grpSaleTop;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastNAme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalePrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource productGridBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSaleCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeNoPrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionPrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAmountPrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrdGridDataGridViewSalePrdTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtPrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtPrdGridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClientSale;
        private System.Windows.Forms.Panel panelClientSale;
        private System.Windows.Forms.GroupBox grpClientSaleLeft;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.DataGridView dataGridViewSaleDetail;
        private System.Windows.Forms.Button btnClientSaleBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClientSalePhone;
        private System.Windows.Forms.Label lblClientSaleLastName;
        private System.Windows.Forms.Label lblClientSaleEmail;
        private System.Windows.Forms.Label lblClientSaleFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource saleDetailProductDtoBindingSource;
    }
}

