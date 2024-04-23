using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Data.Entity;
using StockApp.Data.Repository;
using StockApp.Utils.Extensions;

namespace StockApp
{
    public partial class FormMain : Form
    {
        private readonly ProductRepository _productRepository;
        private readonly ClientRepository _clientRepository;


        private readonly SaleRepository _saleRepository;
        private readonly SaleDetailRepository _saleDetailRepository;

        private FormCreate _frmCreate;

        private Client _selectedClient = null;


        private readonly List<ProductGrid> _selectedProducts = new List<ProductGrid>();

        public FormMain()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _clientRepository = new ClientRepository();
            _saleDetailRepository = new SaleDetailRepository();
            _saleRepository = new SaleRepository();
        }

        #region Product

        private async void btnListProduct_Click(object sender, EventArgs e)
        {
            if (panelClient.Visible)
            {
                PanelClientVisible();
                ClosePanelSale();

            }

            if ((dataGridProduct.DataSource as List<Product> ?? new List<Product>()) is List<Product> products)
            {
                if (!products.Any())
                {
                    dataGridProduct.DataSource = await  _productRepository.GetAllAsync() ;

                }
            }
            PanelProductVisible();
            ClosePanelSale();

        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {

            if (_frmCreate is null || _frmCreate.IsDisposed)
            {
                _frmCreate = new FormCreate(_productRepository);

                _frmCreate.Show();
            }

        }

        private async void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var column = dataGridProduct.Columns[e.ColumnIndex];


            if (!(column is DataGridViewButtonColumn && e.RowIndex >= 0))
            {
                return;
            }

            var row = dataGridProduct.Rows[e.RowIndex];

            var guid = Guid.Parse(row.GetRowCellValue(nameof(idDataGridViewTextBoxColumn)));


            var updatedPrd = (dataGridProduct.DataSource as List<Product>)
                     .Single(x => x.Id == guid);

            if (column.Name == nameof(columnUpdate))
            {

                await _productRepository.UpdateAsync(updatedPrd);

                Alert.Show("Kayıt Güncellendi!", FormAlert.AlertType.Success);

            }
            if (column.Name == nameof(columnDelete))
            {

                await _productRepository.DeleteAsync(updatedPrd);

                Alert.Show("Kayıt Silindi!", FormAlert.AlertType.Success);

            }

            dataGridProduct.DataSource = await  FillPRoductSaleGrid() ;

        }

        private async void btnPrdRefresh_Click(object sender, EventArgs e)
        {
            dataGridProduct.DataSource = await  FillPRoductSaleGrid() ;
        }


        private void PanelProductVisible()
        {
            panelProduct.Visible = !panelProduct.Visible;


            btnListProduct.BackColor = panelProduct.Visible
                ? Color.LightGreen
                : SystemColors.Control;

        }
        #endregion



        #region Client
        private async void btnListClient_Click(object sender, EventArgs e)
        {
            if (panelProduct.Visible)
            {
                PanelProductVisible();

            }


            if ((dataGridViewClient.DataSource as List<Client> ?? new List<Client>()) is List<Client> clients)
            {
                if (!clients.Any())
                {
                    var deneme = await _clientRepository.GetAllAsync();
                    dataGridViewClient.DataSource = deneme;

                }
            }

            PanelClientVisible();
            ClosePanelSale();
        }

        private void btnListSale_Click(object sender, EventArgs e)
        {
        }

        private void btnClientCreate_Click(object sender, EventArgs e)
        {

            if (_frmCreate is null || _frmCreate.IsDisposed)
            {
                _frmCreate = new FormCreate(_clientRepository);

                _frmCreate.Show();
            }
        }

        private async void btnClientRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewClient.DataSource = await _clientRepository.GetAllAsync();
        }

        private void PanelClientVisible()
        {
            panelClient.Visible = !panelClient.Visible;


            btnListClient.BackColor = panelClient.Visible
                ? Color.LightGreen
                : SystemColors.Control;

        }

        private async void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dataGridViewClient.Columns[e.ColumnIndex];






            if (!(column is DataGridViewButtonColumn && e.RowIndex >= 0))
            {
                return;
            }
            var row = dataGridViewClient.Rows[e.RowIndex];

            var guid = Guid.Parse(row.GetRowCellValue(nameof(idClientDataGridViewTextBoxColumn)));



            var updatedPrd = (dataGridViewClient.DataSource as List<Client>)
                     .Single(x => x.Id == guid);

            if (column.Name == nameof(ColumnClientUpdate))
            {

                await _clientRepository.UpdateAsync(updatedPrd);

                Alert.Show("Kayıt Güncellendi!", FormAlert.AlertType.Success);

            }
            if (column.Name == nameof(ColumnClientDelete))
            {

                await _clientRepository.DeleteAsync(updatedPrd);

                Alert.Show("Kayıt Silindi!", FormAlert.AlertType.Success);

            }

            dataGridViewClient.DataSource = await _clientRepository.GetAllAsync();
        }




        #endregion

        #region Sale
        private async void btnSalePrd_Click(object sender, EventArgs e)
        {
            if (_selectedClient != null)
            {
                panelSale.Visible = true;

                lblFirstName.Text = _selectedClient.FirstName;
                lblLastNAme.Text = _selectedClient.LastName;
                lblEmail.Text = _selectedClient.Email;
                lblPhone.Text = _selectedClient.Phone;


                var prds = await  FillPRoductSaleGrid() ;
                GridViewSaleProduct.DataSource = prds.Select(x => new ProductGrid(x)).ToList();

            }
        }


        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex<0)
            {
                return;
            }
            var column = dataGridViewClient.Columns[e.ColumnIndex];




            if ((column is DataGridViewButtonColumn) || e.RowIndex < 0)
            {
                return;
            }


            var row = dataGridViewClient.Rows[e.RowIndex];

            var guid = Guid.Parse(row.GetRowCellValue(nameof(idClientDataGridViewTextBoxColumn)));

            btnSalePrd.Enabled = guid == null ? false : true;
            btnClientSale.Enabled = guid == null ? false : true;


            var client = (dataGridViewClient.DataSource as List<Client>)
                     .Single(x => x.Id == guid);

            _selectedClient = client;


            Alert.Show(guid.ToString() + "\n " + row.GetRowCellValue(nameof(firstNameDataGridViewTextBoxColumn)), FormAlert.AlertType.Success);
        }
       
        private async Task<List<Product>> FillPRoductSaleGrid() 
        {

            return await _productRepository.GetAllAsync(x=>x.StockAmount>0);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClosePanelSale();
        }

        private void ClosePanelSale()
        {
            if (panelSale.Visible)
            {
                panelSale.Visible = false;
                lblFirstName.Text = null;
                lblLastNAme.Text = null;
                lblEmail.Text = null;
                lblPhone.Text = null;

                _selectedClient = null;
                btnSalePrd.Enabled = false;
                btnClientSale.Enabled = false;

                _selectedProducts.Clear();
            }

        }

        private async void txtSalePrd_TextChanged(object sender, EventArgs e)
        {
            var term = txtSalePrd.Text;

            if (txtSalePrd.Text.Length == 0)
            {
                GridViewSaleProduct.DataSource = await  FillPRoductSaleGrid() ;
                _selectedProducts.Clear();

            }

            if (term.Length < 3)
                return;


            var saleProducts = GridViewSaleProduct.DataSource as List<ProductGrid>;

            if (saleProducts is null)
            {
                Alert.Show("Önce Ürün Girin!", FormAlert.AlertType.Warning);
                return;
            }
            var filteredData = saleProducts.Where(x => x.Name.Contains(term)).ToList();
            GridViewSaleProduct.DataSource = filteredData;
        }

        private async void btnSelectedSalePrd_Click(object sender, EventArgs e)
        {
            var deneme = _selectedProducts;

            var saleDetails = new List<SaleDetail>();


            foreach (var product in _selectedProducts)
            {

                saleDetails.Add(new SaleDetail 
                { 
                   Amount = product.Adet,
                   ProductId = product.Id,
                   
                });

                product.StockAmount -= product.Adet;
            }

            var sale = new Sale
            {
                ClientId = _selectedClient.Id,
                Total = _selectedProducts.Sum(x => (x.Price * x.Adet)),
                SaleDetails = saleDetails
            };




            await _saleRepository.AddAsync(sale);


            await _productRepository.UpdateProductStockAmountProc(sale.Id);

           

    

            Alert.Show("Satış Başarılı!",FormAlert.AlertType.Success);

            ClosePanelSale();

        }

        private void GridViewSaleProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var column = GridViewSaleProduct.Columns[e.ColumnIndex];



            if (column.Name == nameof(ColumnSaleCheckBox))
            {
                if (!(column is DataGridViewCheckBoxColumn) || e.RowIndex < 0)
                {
                    return;
                }
                GridSaleSelectedChanged(e);
            }

            if (column.Name == nameof(ColumnAdet))
            {
                GridSaleAmountChanged(e);
            }

        }

        private void GridSaleAmountChanged(DataGridViewCellEventArgs e) 
        {
            var adetCell = Convert.ToInt32(GridViewSaleProduct.Rows[e.RowIndex].Cells[nameof(ColumnAdet)].Value);
            var stockAmountCell = Convert.ToInt32(GridViewSaleProduct.Rows[e.RowIndex].Cells[nameof(stockAmountPrdGridDataGridViewTextBoxColumn)].Value);

            if (adetCell > stockAmountCell)
            {
                Alert.Show("Adet, Stok Adetinden Büyük Olamaz!", FormAlert.AlertType.Warning);

                GridViewSaleProduct.Rows[e.RowIndex].Cells[nameof(ColumnAdet)].Value = 1;

                return;
            }


        }

        private void GridSaleSelectedChanged(DataGridViewCellEventArgs e)
        {



            var row = GridViewSaleProduct.Rows[e.RowIndex];
            var checkBoxCell = GridViewSaleProduct.Rows[e.RowIndex].Cells[nameof(ColumnSaleCheckBox)].Value;

            if (!(checkBoxCell is bool))
            {
                return;
            }

            var guid = Guid.Parse(row.GetRowCellValue(nameof(idPrdGridDataGridViewSalePrdTextBoxColumn)));

            var prd = (GridViewSaleProduct.DataSource as List<ProductGrid>).Single(x => x.Id == guid);



            var checkedCell = Convert.ToBoolean(checkBoxCell);

            if (checkedCell)
            {
                if (!_selectedProducts.Contains(prd))
                {
                    _selectedProducts.Add(prd);

                }
            }
            else
            {
                if (_selectedProducts.Contains(prd))
                {
                    _selectedProducts.Remove(prd);
                }

            }



            Alert.Show("", FormAlert.AlertType.Success);
        }



        #endregion

        private async void btnClientSale_Click(object sender, EventArgs e)
        {
            if (_selectedClient != null)
            {
                panelClientSale.Visible = true;

                lblClientSaleFirstName.Text = _selectedClient.FirstName;
                lblClientSaleLastName.Text = _selectedClient.LastName;
                lblClientSaleEmail.Text = _selectedClient.Email;
                lblClientSalePhone.Text = _selectedClient.Phone;


                dataGridViewSale.DataSource = (await _saleRepository.GetAllAsync(x => x.ClientId == _selectedClient.Id)).OrderByDescending(x=>x.CreatedAt).ToList();

            }
        }

        private void btnClientSaleBack_Click(object sender, EventArgs e)
        {
            if (panelClientSale.Visible)
            {
                panelClientSale.Visible = false;
                lblClientSaleFirstName.Text = null;
                lblClientSaleLastName.Text = null;
                lblClientSaleEmail.Text = null;
                lblClientSalePhone.Text = null;

                _selectedClient = null;
                btnSalePrd.Enabled = false;
                btnClientSale.Enabled = false;

                _selectedProducts.Clear();
            }
        }

        private async void dataGridViewSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var saleId = Convert.ToInt64(dataGridViewSale.Rows[e.RowIndex].Cells[nameof(ıdDataGridViewTextBoxColumn)].Value);

            var saleDetails = await _saleDetailRepository.GetSaleDetailsForGrid(saleId);


            dataGridViewSaleDetail.DataSource = saleDetails;

        }
    }
}
