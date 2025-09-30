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
            dgvProducts.DataSource = DAO.ProductsDAO.GetAll();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
