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
    public partial class SaleForm : Form
    {
        private int employeeId;

        private string authorityLevel;

        public SaleForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();

            this.employeeId = employeeId;

            this.authorityLevel = authorityLevel;
        }

        private void gbSaleFeture_Enter(object sender, EventArgs e)
        {

        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(authorityLevel, employeeId);
            this.Hide();
            manageCustomer.Show();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            Customer_History orderHistory = new Customer_History();
            this.Hide();
            orderHistory.Show();

        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
