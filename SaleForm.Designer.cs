namespace CUSTOMER_MANAGERMENT
{
    partial class SaleForm
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
            this.gbSaleFeture = new System.Windows.Forms.GroupBox();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.gbSaleFeture.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaleFeture
            // 
            this.gbSaleFeture.Controls.Add(this.btnManageOrder);
            this.gbSaleFeture.Controls.Add(this.btnManageCustomer);
            this.gbSaleFeture.Location = new System.Drawing.Point(45, 32);
            this.gbSaleFeture.Name = "gbSaleFeture";
            this.gbSaleFeture.Size = new System.Drawing.Size(935, 517);
            this.gbSaleFeture.TabIndex = 0;
            this.gbSaleFeture.TabStop = false;
            this.gbSaleFeture.Text = "Sale feature";
            this.gbSaleFeture.Enter += new System.EventHandler(this.gbSaleFeture_Enter);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(637, 111);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(158, 75);
            this.btnManageOrder.TabIndex = 1;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(105, 111);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(150, 75);
            this.btnManageCustomer.TabIndex = 0;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 692);
            this.Controls.Add(this.gbSaleFeture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.gbSaleFeture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaleFeture;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnManageCustomer;
    }
}