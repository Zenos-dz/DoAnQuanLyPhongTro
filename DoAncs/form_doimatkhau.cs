using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class form_doimatkhau : Form
    {
        protected Database db = null;
        protected string logintype;
        public form_doimatkhau(ref Database db,string logintype)
        {
            InitializeComponent();
            this.db = db;
            this.logintype = logintype;
            tboldpass.PasswordChar = '*';
            tbnewpass.PasswordChar = '*';
            tbnewpass2.PasswordChar = '*';
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (this.logintype == "")
            {
                dt = db.getData($"SELECT * FROM nguoidung WHERE password = '{tboldpass.Text}'");
            }
            else
            {
                dt = db.getData($"SELECT * FROM nguoithuetro WHERE pass = '{tboldpass.Text}'");
            }
            try
            {
                string temp = dt.Rows[0][1].ToString();
                }
            catch
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!!!");
                return;
            }
            if (tbnewpass.Text != tbnewpass2.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp!!!");
                return;
            }    
            if (tbnewpass.Text.IndexOf(" ") != -1)
            {
                MessageBox.Show("Mật khẩu mới không được chứa kí tự trống!!!");
                return;
            }
            if (this.logintype == "")
            {
                db.cmd($"UPDATE nguoidung SET " +
                        $"password = '{tbnewpass}' " +
                        $" WHERE username = 'admin'");
            }
            else
            {
                db.cmd($"UPDATE nguoithuetro SET " +
                        $"password = '{tbnewpass}' " +
                        $" WHERE manguoithue = '{this.logintype}'");
            }
            MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại!!!");
            //https://stackoverflow.com/questions/779405/how-do-i-restart-my-c-sharp-winform-application
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }
    }
}
