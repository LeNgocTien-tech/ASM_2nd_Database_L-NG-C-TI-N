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
    public partial class Customer_History : Form
    {
        private int employeeId;
        private string authorityLevel;

        public Customer_History()
        {
            InitializeComponent();
        }


        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True");
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT o.OrderDate, e.EmployeeName, c.CustomerName " +
                       "FROM Orders o " +
                       "INNER JOIN Employee e ON o.EmployeeId = e.EmployeeId " +
                       "INNER JOIN Customer c ON o.CustomerId = c.CustomerId " +
                       "WHERE o.EmployeeId = @employeeId ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;
            }
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
            {
                case "Admin":
                    AdminForm adminForm = new AdminForm(authorityLevel, employeeId);
                    this.Hide();
                    adminForm.Show();
                    break;

                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(authorityLevel, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                    break;

                case "Sale":
                    ManageCustomer saleForm = new ManageCustomer(authorityLevel, employeeId);
                    this.Hide();
                    saleForm.Show();
                    break;

                default:
                    break;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            RedirectPage();

        }

        private void dtgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}