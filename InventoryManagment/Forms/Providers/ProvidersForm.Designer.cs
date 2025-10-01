namespace InventoryManagment.Forms.Providers
{
    partial class ProvidersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.dgvProviderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editProvider = new System.Windows.Forms.Button();
            this.btn_refreshProviders = new System.Windows.Forms.Button();
            this.btn_deleteProvider = new System.Windows.Forms.Button();
            this.btn_addProvider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProviders
            // 
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProviderId,
            this.dgvName,
            this.dgvContactName,
            this.dgvPhone,
            this.dgvEmail,
            this.dgvAddress});
            this.dgvProviders.Location = new System.Drawing.Point(242, 12);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(645, 426);
            this.dgvProviders.TabIndex = 0;
            // 
            // dgvProviderId
            // 
            this.dgvProviderId.DataPropertyName = "ProviderId";
            this.dgvProviderId.HeaderText = "Id";
            this.dgvProviderId.Name = "dgvProviderId";
            this.dgvProviderId.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Nombre";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvContactName
            // 
            this.dgvContactName.DataPropertyName = "ContactName";
            this.dgvContactName.HeaderText = "Nombre Contacto";
            this.dgvContactName.Name = "dgvContactName";
            this.dgvContactName.ReadOnly = true;
            // 
            // dgvPhone
            // 
            this.dgvPhone.DataPropertyName = "Phone";
            this.dgvPhone.HeaderText = "Teléfono";
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.DataPropertyName = "Address";
            this.dgvAddress.HeaderText = "Dirección";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editProvider);
            this.groupBox1.Controls.Add(this.btn_refreshProviders);
            this.groupBox1.Controls.Add(this.btn_deleteProvider);
            this.groupBox1.Controls.Add(this.btn_addProvider);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elige una de las opciones";
            // 
            // btn_editProvider
            // 
            this.btn_editProvider.Location = new System.Drawing.Point(7, 50);
            this.btn_editProvider.Name = "btn_editProvider";
            this.btn_editProvider.Size = new System.Drawing.Size(186, 23);
            this.btn_editProvider.TabIndex = 3;
            this.btn_editProvider.Text = "Editar";
            this.btn_editProvider.UseVisualStyleBackColor = true;
            this.btn_editProvider.Click += new System.EventHandler(this.btn_editProvider_Click);
            // 
            // btn_refreshProviders
            // 
            this.btn_refreshProviders.Location = new System.Drawing.Point(7, 79);
            this.btn_refreshProviders.Name = "btn_refreshProviders";
            this.btn_refreshProviders.Size = new System.Drawing.Size(187, 23);
            this.btn_refreshProviders.TabIndex = 2;
            this.btn_refreshProviders.Text = "Actualizar";
            this.btn_refreshProviders.UseVisualStyleBackColor = true;
            this.btn_refreshProviders.Click += new System.EventHandler(this.btn_refreshProviders_Click);
            // 
            // btn_deleteProvider
            // 
            this.btn_deleteProvider.Location = new System.Drawing.Point(6, 108);
            this.btn_deleteProvider.Name = "btn_deleteProvider";
            this.btn_deleteProvider.Size = new System.Drawing.Size(187, 23);
            this.btn_deleteProvider.TabIndex = 1;
            this.btn_deleteProvider.Text = "Eliminar";
            this.btn_deleteProvider.UseVisualStyleBackColor = true;
            this.btn_deleteProvider.Click += new System.EventHandler(this.btn_deleteProvider_Click);
            // 
            // btn_addProvider
            // 
            this.btn_addProvider.Location = new System.Drawing.Point(7, 20);
            this.btn_addProvider.Name = "btn_addProvider";
            this.btn_addProvider.Size = new System.Drawing.Size(187, 23);
            this.btn_addProvider.TabIndex = 0;
            this.btn_addProvider.Text = "Añadir";
            this.btn_addProvider.UseVisualStyleBackColor = true;
            this.btn_addProvider.Click += new System.EventHandler(this.btn_addProvider_Click);
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProviders);
            this.Name = "ProvidersForm";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteProvider;
        private System.Windows.Forms.Button btn_addProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProviderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.Button btn_refreshProviders;
        private System.Windows.Forms.Button btn_editProvider;
    }
}