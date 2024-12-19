using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUSTOMER_MANAGERMENT
{
    public class DatabaseConection
    {
        private static string _conectionString = "Data Source=DESKTOP-D80GRN6\\SQLEXPRESS;Initial Catalog=\"badminton racket sales product manager\";Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection GetConnection()
        {
            // khoi tạo biến sql connection
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_conectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errox while connecting to the database",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return connection;

        }
    }
}       
        


