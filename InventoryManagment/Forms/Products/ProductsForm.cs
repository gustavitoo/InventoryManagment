using InventoryManagment.Forms.Products;
using InventoryManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            loadProducts();
        }

        private void loadProducts()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = Services.ProductsService.GetAll();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            Forms.Products.NewProduct newProductForm = new Forms.Products.NewProduct();
            newProductForm.FormClosed += (s, args) => loadProducts();
            newProductForm.ShowDialog();
        }

        private void btn_refreshProducts_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            using (var form = new NewProduct(selectedProduct))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    loadProducts();
            }
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar el producto '{selectedProduct.Name}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Services.ProductsService.Delete(selectedProduct.ProductId);
                loadProducts();
            }
        }
    }
}
