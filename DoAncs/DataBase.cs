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

namespace Doancs
{
    public class Database
    {
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\asset\csdl\QUANLYTRO.mdf;Integrated Security=True";

        // Cac đối tượng để truy vấn dữ liệu
        private SqlConnection conn;

        public Database()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                testconnect("select * from ...");
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
        public bool testconnect(string commandString)
        {
            try
            {
                SqlCommand sqlDatabaseCommand = new SqlCommand(commandString, conn);
                sqlDatabaseCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
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
        public void runQuery(string ssql)
        {
            try
            {
                SqlCommand mySqlCommand = new SqlCommand(ssql, conn);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}

