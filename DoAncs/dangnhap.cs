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
            db.testconnect(); //load csdl 1 lan truoc khi chay main de tang toc do
            pass.PasswordChar = '\u058E';
        }
        private void user_TextChanged(object sender, EventArgs e)
        {
            username.BorderStyle = BorderStyle.None;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.BorderStyle = BorderStyle.None;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        //for login
        protected void checklogin()
        {
            //code check login
            string query = $"SELECT username FROM NguoiDung WHERE username='{username.Text}' AND password='{pass.Text}'";
            DataTable reader = db.getData(query);
            try
            {
                reader.NewRow();
                if (reader.Rows[0].IsNull(0) == false)
                {
                    //MessageBox.Show("Login successful");
                    //this.UseWaitCursor = true;
                    //button1.Text = "Đang tải chương trình...";
                    //this.UseWaitCursor = false;
                    this.Hide();
                    Main main = new Main(db);
                    main.ShowDialog();
                    Application.Exit();
                    // allow user to a
                    // close application
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Invalid username or password");
            }
            
        }
        //login with button
        private void login_Click(object sender, EventArgs e)
        {
            checklogin();
        }
        //login with enter key
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
