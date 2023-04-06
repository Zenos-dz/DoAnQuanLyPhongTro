using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doancs
{
    public partial class dangnhap : Form
    {
        Database db = new Database();
        public dangnhap()
        {
            InitializeComponent();
            pass.PasswordChar = '\u058E';
        }
        
        //for login
        protected void checklogin()
        {
            //code check login
            string query = $"SELECT username FROM NguoiDung WHERE username='{username.Text}' AND password='{pass.Text}'";
            DataTable reader = db.getData(query);
            try
            {
                if (reader.Rows[0].IsNull(0) == false)
                {
                    this.Hide();
                    Main main = new Main(db);
                    main.ShowDialog();
                    Application.Exit();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!");
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            checklogin();
        }
        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checklogin();
        }
        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checklogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
