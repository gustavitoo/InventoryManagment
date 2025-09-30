namespace InventoryManagment
{
    partial class ProductsForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProviderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.dgvName,
            this.dgvCategory,
            this.dgvUnitPrice,
            this.dgvCostPrice,
            this.dgvStock,
            this.dgvProviderId});
            this.dgvProducts.Location = new System.Drawing.Point(242, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(743, 426);
            this.dgvProducts.TabIndex = 0;
            // 
            // dgvProductId
            // 
            this.dgvProductId.DataPropertyName = "ProductId";
            this.dgvProductId.HeaderText = "Id";
            this.dgvProductId.Name = "dgvProductId";
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Nombre";
            this.dgvName.Name = "dgvName";
            // 
            // dgvCategory
            // 
            this.dgvCategory.DataPropertyName = "Category";
            this.dgvCategory.HeaderText = "Categoria";
            this.dgvCategory.Name = "dgvCategory";
            // 
            // dgvUnitPrice
            // 
            this.dgvUnitPrice.DataPropertyName = "UnitPrice";
            this.dgvUnitPrice.HeaderText = "Precio Unitario";
            this.dgvUnitPrice.Name = "dgvUnitPrice";
            // 
            // dgvCostPrice
            // 
            this.dgvCostPrice.DataPropertyName = "CostPrice";
            this.dgvCostPrice.HeaderText = "Precio de costo";
            this.dgvCostPrice.Name = "dgvCostPrice";
            // 
            // dgvStock
            // 
            this.dgvStock.DataPropertyName = "Stock";
            this.dgvStock.HeaderText = "Disponibles";
            this.dgvStock.Name = "dgvStock";
            // 
            // dgvProviderId
            // 
            this.dgvProviderId.DataPropertyName = "ProviderName";
            this.dgvProviderId.HeaderText = "Proveedor";
            this.dgvProviderId.Name = "dgvProviderId";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deleteProduct);
            this.groupBox1.Controls.Add(this.btn_addProduct);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(7, 50);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(187, 23);
            this.btn_deleteProduct.TabIndex = 1;
            this.btn_deleteProduct.Text = "Eliminar";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(7, 20);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(187, 23);
            this.btn_addProduct.TabIndex = 0;
            this.btn_addProduct.Text = "Añadir";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductsForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProviderId;
    }
}