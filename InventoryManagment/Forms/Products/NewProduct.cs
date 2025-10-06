using InventoryManagment.DAO;
using InventoryManagment.Models;
using InventoryManagment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagment.Forms.Products
{
    public partial class NewProduct : Form
    {
        private Product _product;  
        private bool _isEditMode;  

        public NewProduct()
        {
            InitializeComponent();
            LoadProviders();
            _isEditMode = false;
        }

        public NewProduct(Product product)
        {
            InitializeComponent();
            _isEditMode = true;
            _product = product;

            LoadProviders();
            LoadProductData();

            this.Text = "Editar Producto";
            this.groupBox1.Text = "Edita los campos";
            this.button1.Text = "Guardar";
        }

        private void LoadProductData()
        {
            if (_product != null)
            {
                txtName.Text = _product.Name;
                txtCategory.Text = _product.Category;
                txtStock.Text = _product.Stock.ToString();
                txtUnitPrice.Text = _product.UnitPrice.ToString("0.00");
                txtCostPrice.Text = _product.CostPrice.ToString("0.00");
                cmbProviders.SelectedValue = _product.ProviderId;
            }
        }

        private void LoadProviders()
        {
            try 
            {
                var providers = ProvidersService.GetAll();
                cmbProviders.DataSource = providers;
                cmbProviders.DisplayMember = "Name";
                cmbProviders.ValueMember = "ProviderId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtCategory.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtCostPrice.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    var result = MessageBox.Show("¿Estás seguro de guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;

                    _product.Name = txtName.Text;
                    _product.Category = txtCategory.Text;
                    _product.Stock = int.Parse(txtStock.Text);
                    _product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    _product.CostPrice = decimal.Parse(txtCostPrice.Text);
                    _product.ProviderId = (int)cmbProviders.SelectedValue;
                    Services.ProductsService.Update(_product);
                }
                else
                {
                    var newProduct = new Product
                    {
                        Name = txtName.Text,
                        Category = txtCategory.Text,
                        Stock = int.Parse(txtStock.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        CostPrice = decimal.Parse(txtCostPrice.Text),
                        ProviderId = (int)cmbProviders.SelectedValue
                    };

                    Services.ProductsService.Add(newProduct);
                    MessageBox.Show("Producto agregado con éxito", "Éxito");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
