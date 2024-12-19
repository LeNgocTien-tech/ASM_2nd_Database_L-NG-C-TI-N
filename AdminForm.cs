
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
    public partial class AdminForm : Form
    {
        private string authorityLevel;
        private int employeeId;
        private string employeePosition;

        public AdminForm(string authorityLevel, int employeeId)
        {

            InitializeComponent();

            this.authorityLevel = authorityLevel;

            this.employeeId = employeeId;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee(employeePosition);

            this.Hide();

            manageEmployee.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(this.authorityLevel, this.employeeId);
            this.Hide();
            manageProduct.Show();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
