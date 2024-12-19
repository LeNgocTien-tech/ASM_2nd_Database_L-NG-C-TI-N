using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUSTOMER_MANAGERMENT
{
    public partial class WarehouseManagerForm : Form
    {
        int employeeId;

        string authorityLevel;
        

        public WarehouseManagerForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();

            this.authorityLevel = authorityLevel;

            this.employeeId = employeeId;
            
           
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(this.authorityLevel, this.employeeId);
            this.Hide();
            manageProduct.Show();
        }
    }
}
