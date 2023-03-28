using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Database
    {
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csdl\QUANLYTRO.mdf;Integrated Security=True";

        // Cac đối tượng để truy vấn dữ liệu
        private SqlConnection conn;

        public Database()
        {
            try
            {
                conn = new SqlConnection(conStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }

        }
        public void cmd(string commandString)
        {
            SqlCommand sqlDatabaseCommand = new SqlCommand(commandString, conn);
            sqlDatabaseCommand.ExecuteNonQuery();
        }
        public DataTable getData(string ssql)
        {
            try
            {
                SqlDataAdapter dbadapter = new SqlDataAdapter(ssql, conn);
                DataTable dt = new DataTable();
                dbadapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void runQuery(string query)
        {
            try
            {
                SqlConnection .Open();
                SqlCommand mySqlCommand = new SqlCommand(ssql, SqlConnection);
                mySqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}

