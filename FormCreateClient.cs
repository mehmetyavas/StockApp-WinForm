using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Data.Context;
using StockApp.Data.Entity;
using StockApp.Utils.Extensions;

namespace StockApp
{
    public partial class FormCreateProduct : Form
    {

        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private async void btnProductCreate_Click(object sender, EventArgs e)
        {
            using (var context = new StockDbContext())
            {

                var deneme = context.Products.Add(new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = txtProductName.Text,
                    Description = txtProductDesc.Text,
                    StockAmount = int.Parse(txtProductAmount.Text),
                    Price = decimal.Parse(txtProductPrice.Text),
                    BarcodeNo = txtProductBarcode.Text,
                });

                await context.SaveChangesAsync();

            }


            Dispose();


        }
    }
}
