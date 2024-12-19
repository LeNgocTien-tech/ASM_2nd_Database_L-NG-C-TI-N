using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CUSTOMER_MANAGERMENT
{
    public partial class ManageEmployee : Form
    {
        int employeeId;
        string employeePosition;

        public void InitializeComboBox()
        {
            // Add items to the authority level combo box
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse Manage");
            cbAuthorityLevel.Items.Add("Sale");

            // Set the selected item to "Admin" by default
            cbAuthorityLevel.SelectedIndex = 0;
        }
        public ManageEmployee(string employeePosition)
        {
            employeeId = 0;
            InitializeComponent();
            this.employeePosition = employeePosition;
        }
        public ManageEmployee()
        {
            InitializeComponent();
        }
        private void ManagerEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            InitializeComboBox();
        }
      

        private bool ValidateData(string employeeCode,
                              string employeeName,
                              string employeePosition,
                              string authorityLevel,
                              string username,
                              string password)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(employeeCode))
            {
                MessageBox.Show("Employee Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeCode.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(employeeName))
            {
                MessageBox.Show("Employee Position cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeePosition.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(authorityLevel))
            {
                MessageBox.Show("Authority Level cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                isValid = false;
            }
            return isValid;
        }

        
        private void LoadEmployeeData()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            txtEmployeeCode.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePosition.Text = string.Empty;
            cbAuthorityLevel.SelectedIndex = 0;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }
       
        private bool CheckUserExistence(int employeeId)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Employee WHERE EmployeeID = @employeeId";

                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);

                // Add parameters
                command.Parameters.AddWithValue("@employeeId", employeeId);

                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();

                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;

                // Close the connection
                connection.Close();
            }
            return isExist;
        }
        private void AddUser(string employeeCode,
                    string employeeName,
                    string employeePosition,
                    string authorityLevel,
                    string username,
                    string password)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


            if (connection != null)
            {
                connection.Open();
                string sql = "INSERT INTO Employee VALUES (@employeeCode, @employeeName, @employeePosition, @authorityLevel, @username, @password, 0)";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@employeeCode", employeeCode);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePosition", employeePosition);
                command.Parameters.AddWithValue("@authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully add new user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot add new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void UpdateUser(int employeeId,
                     string employeeCode,
                     string employeeName,
                     string employeePosition,
                     string authorityLevel,
                     string username,
                     string password)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET EmployeeCode = @employeeCode, " +
                             "EmployeeName = @employeeName, " +
                             "Position = @employeePosition, " +
                             "AuthorityLevel = @authorityLevel, " +
                             "Username = @username, " +
                             "Password = @password " +
                             "WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@employeeCode", employeeCode);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePosition", employeePosition);
                command.Parameters.AddWithValue("@authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@employeeId", employeeId);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully update user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void DeleteUser(int employeeId)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE FROM Employee WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@employeeId", employeeId);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully delete user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                // Open connection by call the GetConnection function in DatabaseConnection class
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");


                // Check connection
                if (connection != null)
                {
                    // Open the connection
                    connection.Open();

                    // Declare query to the database
                    string query = "SELECT * FROM Employee WHERE EmployeeCode LIKE @search " +
                                   "OR Position LIKE @search " + "OR AuthorityLevel LIKE @search " +
                                   "OR Username LIKE @search " +
                                   "OR Password LIKE @search";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Initialize data table
                    DataTable table = new DataTable();

                    // Fill the data table by data queried from the database
                    adapter.Fill(table);

                    // Set the datasource of data gridview by the dataset
                    dtgEmployee.DataSource = table;

                    // close the connection
                    connection.Close();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get user input data
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate data
            bool isValid = ValidateData(employeeCode,
                                       employeeName,
                                       employeePosition,
                                       authorityLevel,
                                       username,
                                       password);

            if (isValid)
            {
                AddUser(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get user input data
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate data
            bool isValid = ValidateData(employeeCode,
                                       employeeName,
                                       employeePosition,
                                       authorityLevel,
                                       username,
                                       password);

            if (isValid)
            {
                UpdateUser(employeeId, employeeCode, employeeName, employeePosition, authorityLevel, username, password);

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            DialogResult result = MessageBox.Show("Do you want to delete this user?",
                                                  "Warning",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeId);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (employeePosition)
            {
                case "Admin":
                    AdminForm adminForm = new AdminForm(employeePosition, employeeId);
                    this.Hide();
                    adminForm.Show();
                    break;

                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(employeePosition, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                  
                    break;

                case "Sale":
                    SaleForm saleForm = new SaleForm(employeePosition, employeeId);
                    this.Hide();
                    saleForm.Show();
                    break;

                default:
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }
        private void dtgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the selected row
            int rowIndex = dtgEmployee.CurrentCell.RowIndex;

            // Check if the selected row is valid
            if (rowIndex >= 0)
            {
                // Get the employee ID from the first cell of the selected row
                int employeeId = Convert.ToInt32(dtgEmployee.Rows[rowIndex].Cells[0].Value);

                // Enable the update, delete, and clear buttons if the employee ID is valid

                // Populate the textboxes with the corresponding values from the selected row
                txtEmployeeCode.Text = dtgEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                txtEmployeePosition.Text = dtgEmployee.Rows[rowIndex].Cells[3].Value.ToString();
                string authorityLevel = dtgEmployee.Rows[rowIndex].Cells[4].Value.ToString();
                txtUsername.Text = dtgEmployee.Rows[rowIndex].Cells[5].Value.ToString();
                txtPassword.Text = dtgEmployee.Rows[rowIndex].Cells[6].Value.ToString();
                // Set the selected index of the authority level combobox based on the value
                switch (authorityLevel)
                {
                    case "Admin":
                        cbAuthorityLevel.SelectedIndex = 0;
                        break;
                    case "Warehouse Manager":
                        cbAuthorityLevel.SelectedIndex = 1;
                        break;
                    case "Sale":
                        cbAuthorityLevel.SelectedIndex = 2;
                        break;
                    default:
                        // Handle other cases if necessary
                        break;
                }
            }
        }

        private void gbManageEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void dtgEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the selected row
            int rowIndex = dtgEmployee.CurrentCell.RowIndex;

            // Check if the selected row is valid
            if (rowIndex >= 0)
            {
                // Get the employee ID from the first cell of the selected row
                int employeeId = Convert.ToInt32(dtgEmployee.Rows[rowIndex].Cells[0].Value);

                // Enable the update, delete, and clear buttons if the employee ID is valid

                // Populate the textboxes with the corresponding values from the selected row
                txtEmployeeCode.Text = dtgEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                txtEmployeePosition.Text = dtgEmployee.Rows[rowIndex].Cells[3].Value.ToString();
                string authorityLevel = dtgEmployee.Rows[rowIndex].Cells[4].Value.ToString();
                txtUsername.Text = dtgEmployee.Rows[rowIndex].Cells[5].Value.ToString();
                txtPassword.Text = dtgEmployee.Rows[rowIndex].Cells[6].Value.ToString();
                // Set the selected index of the authority level combobox based on the value
                switch (authorityLevel)
                {
                    case "Admin":
                        cbAuthorityLevel.SelectedIndex = 0;
                        break;
                    case "Warehouse Manager":
                        cbAuthorityLevel.SelectedIndex = 1;
                        break;
                    case "Sale":
                        cbAuthorityLevel.SelectedIndex = 2;
                        break;
                    default:
                        // Handle other cases if necessary
                        break;
                }
            }
        }

 

        private void cbAuthorityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAuthorityLevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}

       

















