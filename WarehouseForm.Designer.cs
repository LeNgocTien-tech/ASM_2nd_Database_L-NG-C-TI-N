namespace CUSTOMER_MANAGERMENT
{
    partial class WarehouseManagerForm
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
            this.gbWarehouseManagerFeature = new System.Windows.Forms.GroupBox();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.gbWarehouseManagerFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWarehouseManagerFeature
            // 
            this.gbWarehouseManagerFeature.Controls.Add(this.btnManageProduct);
            this.gbWarehouseManagerFeature.Location = new System.Drawing.Point(37, 30);
            this.gbWarehouseManagerFeature.Name = "gbWarehouseManagerFeature";
            this.gbWarehouseManagerFeature.Size = new System.Drawing.Size(750, 534);
            this.gbWarehouseManagerFeature.TabIndex = 0;
            this.gbWarehouseManagerFeature.TabStop = false;
            this.gbWarehouseManagerFeature.Text = "Warehouse manager feature ";
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(99, 103);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(167, 69);
            this.btnManageProduct.TabIndex = 0;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // WarehouseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 692);
            this.Controls.Add(this.gbWarehouseManagerFeature);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WarehouseManagerForm";
            this.Text = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.gbWarehouseManagerFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWarehouseManagerFeature;
        private System.Windows.Forms.Button btnManageProduct;
    }
}