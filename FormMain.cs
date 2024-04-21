using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Data.Context;
using StockApp.Data.Entity;
using StockApp.Data.Repository;
using StockApp.Utils.Extensions;
using URETIM;

namespace StockApp
{
    public partial class FormMain : Form
    {
        private readonly ProductRepository _productRepository;
        private readonly ClientRepository _clientRepository;

        private FormCreate _frmCreate;
        public FormMain()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _clientRepository = new ClientRepository();
        }

        #region Product

        private async void btnListProduct_Click(object sender, EventArgs e)
        {
            if (panelClient.Visible)
            {
                PanelClientVisible();

            }

            if ((dataGridProduct.DataSource as List<Product> ?? new List<Product>()) is List<Product> products)
            {
                if (!products.Any())
                {
                    dataGridProduct.DataSource = await _productRepository.GetAllAsync();

                }
            }
            PanelProductVisible();


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

            dataGridProduct.DataSource = await _productRepository.GetAllAsync();

        }

        private async void btnPrdRefresh_Click(object sender, EventArgs e)
        {
            dataGridProduct.DataSource = await _productRepository.GetAllAsync();
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
                    dataGridViewClient.DataSource = await _clientRepository.GetAllAsync();

                }
            }

            PanelClientVisible();
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




        #endregion

        #region Sale

        #endregion

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
    }
}
