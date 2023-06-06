using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doancs
{
    public class Database
    {
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\asset\csdl\QUANLYTRO.mdf;Integrated Security=True";

        private SqlConnection conn;
        public Database()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
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
                MessageBox.Show(ex.Message+ $"  {ssql}");
                return null;
            }
        }
    }
}

