using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doancs
{
    public class Database
    {
        //sử dụng đường dẫn cục bộ ./asset/csdl để lưu database (.mdf,_log.mdf)
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\asset\csdl\QUANLYTRO.mdf;Integrated Security=True";

        // Cac đối tượng để truy vấn dữ liệu
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
        //
        /// <summary>
        ///     không có ngoại lệ trả về
        ///     dùng trong trường hợp xử lý các ngoại lệ biết trước(custom exception)
        /// </summary>
        /// <param name="commandString"></param>
        public void cmd(string commandString)
        {
            SqlCommand sqlDatabaseCommand = new SqlCommand(commandString, conn);
            sqlDatabaseCommand.ExecuteNonQuery();
        }
        /// <summary>
        ///     Truy vấn dữ liệu thông qua sqlQuery(ssql), trả về 1 bảng chứa dữ liệu hoặc không gì cả
        /// </summary>
        /// <param name="ssql"></param>
        /// <returns>DataTable | null</returns>
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
    }
}

