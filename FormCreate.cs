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
using StockApp.Data.Repository;
using StockApp.Utils.Extensions;

namespace StockApp
{
    public partial class FormCreate : Form
    {
       private readonly ProductRepository _productRepository;
       private readonly ClientRepository _clientRepository;

        public FormCreate(ProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            grpProductCreate.Visible = true;
        }   
        
        public FormCreate(ClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            grpCreateClient.Visible = true;

        }

        private async void btnProductCreate_Click(object sender, EventArgs e)
        {


            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = txtProductName.Text,
                Description = txtProductDesc.Text,
                StockAmount = int.Parse(txtProductAmount.Text),
                Price = decimal.Parse(txtProductPrice.Text),
                BarcodeNo = txtProductBarcode.Text,
            };

            await _productRepository.AddAsync(product);

            Dispose();


        }

        private async void btnCreateClient_Click(object sender, EventArgs e)
        {

            var client = new Client()
            {
                Id = Guid.NewGuid(),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
            };

            await _clientRepository.AddAsync(client);

            Dispose();
        }

 
    }
}
