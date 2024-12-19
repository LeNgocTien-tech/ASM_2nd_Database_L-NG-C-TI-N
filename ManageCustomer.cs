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
    public partial class ManageCustomer : Form
    {
        private int customerId;
        private int employeeId;
        private string authorityLevel;
        private int userId;
        public ManageCustomer(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLevel = authorityLevel;
        }
 
        private void ClearData()
        {
            FlushCustomerId();
            txtCustomerCode.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtPhonenumber.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtCustomerCode.Focus();

        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            // When customer is selected, button add will be disabled
            // button Update, Delete & Clear will be enabled and vice versa

            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = !buttonStatus;
        }
        private bool ValidateData(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            // Validate user input data
            // Declare isValid variable to check. First we assume all data is valid and check each of it
            bool isValid = true;

            if (customerCode == null || customerCode == string.Empty)
            {
                MessageBox.Show(
                    "Customer Code cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                isValid = false;
                txtCustomerCode.Focus();
            }
            else if (customerName == null || customerName == string.Empty)
            {
                MessageBox.Show(
                    "Customer Name cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                isValid = false;
                txtCustomerName.Focus();
            }
            else if (customerAddress == null || customerAddress == string.Empty)
            {
                MessageBox.Show(
                    "Customer Address cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                isValid = false;
                txtCustomerAddress.Focus();
            }
            else if (phoneNumber == null || phoneNumber == string.Empty)
            {
                MessageBox.Show(
                    "Phone number cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                isValid = false;
                txtPhonenumber.Focus();
            }

            return isValid;

        }
        private void FlushCustomerId()
        {
            // Flush customerID value to check button and setup status for buttons
            this.customerId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadCustomerData()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // Declare query to the database
                string query = "SELECT * FROM Customer";

                // Initialize SqlDataAdapter to translate query result to a data table
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Initialize data table
                DataTable table = new DataTable();

                // Fill the data table by data queried from the database
                adapter.Fill(table);

                // Set the datasource of data gridview by the dataset
                dtgCustomer.DataSource = table;

                // close the connection
                connection.Close();
            }
        }
        private bool CheckUserExistence(int customerId)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");

            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Customer WHERE CustomerID = @customerId";

                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters
                command.Parameters.AddWithValue("@customerId", customerId);

                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();

                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;

                connection.Close();
            }

            return isExist;
        }
        private void AddCustomer(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");

            if (connection != null)
            {
                connection.Open();
                string query = "INSERT INTO Customer (CustomerCode, CustomerName, PhoneNumber, Address) " +
                               "VALUES (@customerCode, @customerName, @phoneNumber, @customerAddress)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerCode", customerCode);
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@customerAddress", customerAddress);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    // Success message
                    MessageBox.Show(
                 "Successfully add new customer",
                 "Success",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                 );
                }
                else
                {
                    // Error message
                    MessageBox.Show(
                 "An error occur while adding customer",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                 );
                }
                connection.Close();
                ClearData();
                // Reload the data gridview
                LoadCustomerData();
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dtgCustomer.Rows[index].Cells[0].Value;
                txtCustomerCode.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
                txtCustomerName.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                txtPhonenumber.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
                txtCustomerAddress.Text = dtgCustomer.Rows[index].Cells[4].Value.ToString();
                ChangeButtonStatus(true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get data from user input
            string customerCode = txtCustomerCode.Text;
            string customerName = txtCustomerName.Text;
            string customerAddress = txtCustomerAddress.Text;
            string phoneNumber = txtPhonenumber.Text;

            // Validate data
            bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);
            if (isValid)
            {
                AddCustomer(customerCode, customerName, customerAddress, phoneNumber);
            }
        }

       
    }
}
