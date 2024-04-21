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
      private readonly  ProductRepository _productRepository;
        public FormMain()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();

        }

        #region Product

        private async void btnListProduct_Click(object sender, EventArgs e)
        {

            if ((dataGridProduct.DataSource as List<Product> ?? new List<Product>()) is List<Product> products)
            {
                if (products.Any())
                {
                    return;
                }
                dataGridProduct.DataSource = await _productRepository.GetAllAsync();
            }

            if (!panelProduct.Visible)
            {
                panelProduct.Visible = true;
            }
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            FormCreateProduct frmCreateClient = new FormCreateProduct();

            frmCreateClient.Show();
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

        #endregion



        #region Client
        private void btnListClient_Click(object sender, EventArgs e)
        {

            Alert.Show("deneme", FormAlert.AlertType.Success);
        }

        private void btnListSale_Click(object sender, EventArgs e)
        {
        }
        #endregion


        #region Sale

        #endregion
    }
}
