using InventoryManagment.Models;
using InventoryManagment.Services;
using System;
using System.Windows.Forms;

namespace InventoryManagment.Forms.Providers
{
    public partial class NewProvider : Form
    {
        private Provider _provider;
        private bool _editMode;

        public NewProvider()
        {
            InitializeComponent();
            _editMode = false;
        }

        public NewProvider(Provider provider)
        {
            InitializeComponent();
            _provider = provider;
            _editMode = true;

            LoadProviderData();

            // Change name
            this.Text = "Editar Proveedor";
            this.btn_addProvider.Text = "Guardar";
        }

        private void LoadProviderData()
        {
            if (_provider != null)
            {
                textBox1.Text = _provider.Name;
                textBox2.Text = _provider.ContactName;
                textBox3.Text = _provider.Phone;
                textBox4.Text = _provider.Email;
                textBox5.Text = _provider.Address;
            }
        }

        private void btn_cancelAddProvider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_addProvider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_editMode)
            {
                var result = MessageBox.Show("¿Estás seguro de guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                _provider.Name = textBox1.Text;
                _provider.ContactName = textBox2.Text;
                _provider.Phone = textBox3.Text;
                _provider.Email = textBox4.Text;
                _provider.Address = textBox5.Text;

                ProvidersService.Update(_provider);
            }
            else
            {
                var newProvider = new Provider
                {
                    Name = textBox1.Text,
                    ContactName = textBox2.Text,
                    Phone = textBox3.Text,
                    Email = textBox4.Text,
                    Address = textBox5.Text
                };

                ProvidersService.Add(newProvider);

                MessageBox.Show("Proveedor agregado con éxito", "Éxito");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
