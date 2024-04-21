using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Data.Context;
using StockApp.Data.Entity;
using StockApp.Utils.Extensions;
using URETIM;

namespace StockApp
{
    public partial class FormMain : Form
    {



        public FormMain()
        {
            InitializeComponent();

        }

        public void Alert(string msg, FormAlert.AlertType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {

            Alert("deneme", FormAlert.AlertType.Success);
        }

        private async void btnListProduct_Click(object sender, EventArgs e)
        {
            using (var context = new StockDbContext())
            {

                if ((dataGridProduct.DataSource as List<Product> ?? new List<Product>()) is List<Product> products)
                {
                    if (!products.Any())
                    {
                        dataGridProduct.DataSource = await context.Products.ToListAsync();
                    }
                }
            }


            if (!panelClient.Visible)
            {
                panelClient.Visible = true;
            }

        }


        private void btnListSale_Click(object sender, EventArgs e)
        {
        }


        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            FormCreateProduct frmCreateClient = new FormCreateProduct();

            frmCreateClient.Show();
        }

        private async void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            var column = dataGridProduct.Columns[e.ColumnIndex];


            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                using (var context = new StockDbContext())
                {
                    var row = dataGridProduct.Rows[e.RowIndex];

                    var guid = Guid.Parse(row.GetRowCellValue(nameof(idDataGridViewTextBoxColumn)));



                    var prdToProccess = await context.Products
                        .SingleAsync(x => x.Id == guid);


                    if (column.Name == nameof(columnUpdate))
                    {

                        var updatedPrd = (dataGridProduct.DataSource as List<Product>)
                            .Single(x => x.Id == guid);

                        prdToProccess.Name = updatedPrd.Name;
                        prdToProccess.Description = updatedPrd.Description;
                        prdToProccess.BarcodeNo = updatedPrd.BarcodeNo;
                        prdToProccess.StockAmount = updatedPrd.StockAmount;
                        prdToProccess.Price = updatedPrd.Price;
                        prdToProccess.ModifiedAt = DateTime.Now;

                        context.Products.AddOrUpdate(prdToProccess);

                        await context.SaveChangesAsync();

                        Alert("Kayıt Güncellendi!", FormAlert.AlertType.Success);

                    }
                    if (column.Name == nameof(columnDelete))
                    {
                        context.Products.Remove(prdToProccess);



                        await context.SaveChangesAsync();

                        Alert("Kayıt Silindi!", FormAlert.AlertType.Success);

                    }


                    dataGridProduct.DataSource = await context.Products.ToListAsync();

                    context.Dispose();

                }



            }
        }
    }
}
