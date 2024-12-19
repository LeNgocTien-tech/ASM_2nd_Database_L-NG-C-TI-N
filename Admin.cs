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
        public AdminForm()
        {
            InitializeComponent();
            InitializeCombobox();

        }

        public void InitializeCombobox()
        {
            // Setuo for combobox
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");
            // Set the selected index to the first item of the array (admin)
            cbRole.SelectedIndex = 0;
        }
        private bool ValidateData(string user)
        {

        }
    }
}
