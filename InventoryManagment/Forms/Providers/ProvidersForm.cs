using System;
using System.Windows.Forms;
using InventoryManagment.Services;

namespace InventoryManagment.Forms.Providers
{
    public partial class ProvidersForm : Form
    {
        public ProvidersForm()
        {
            InitializeComponent();
            LoadProviders();
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadProviders()
        {
            dgvProviders.DataSource = null;
            dgvProviders.AutoGenerateColumns = false;
            dgvProviders.DataSource = ProvidersService.GetAll();
        }

        private void btn_refreshProviders_Click(object sender, EventArgs e)
        {
            LoadProviders();
        }

        private void btn_addProvider_Click(object sender, EventArgs e)
        {
            var form = new NewProvider();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProviders();
            }
        }

        private void btn_editProvider_Click(object sender, EventArgs e)
        {
            if (dgvProviders.CurrentRow != null)
            {
                var provider = (InventoryManagment.Models.Provider)dgvProviders.CurrentRow.DataBoundItem;
                var form = new NewProvider(provider);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProviders();
                }
            }
        }

        private void btn_deleteProvider_Click(object sender, EventArgs e)
        {
            if (dgvProviders.CurrentRow != null)
            {
                var provider = (InventoryManagment.Models.Provider)dgvProviders.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show($"¿Eliminar proveedor {provider.Name}?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    ProvidersService.Delete(provider.ProviderId);
                    LoadProviders();
                }
            }
        }
    }
}
