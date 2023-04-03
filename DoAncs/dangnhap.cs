using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class dangnhap : Form
    {
        Database db = new Database();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            user.BorderStyle = BorderStyle.None;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //user.BackColor = Color.FromArgb(0, Color.Red);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.BorderStyle = BorderStyle.None;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        protected void checklogin()
        {
            //code check login
            if (true)
            {
                //this.UseWaitCursor = true;
                //button1.Text = "Đang tải chương trình...";
                db.testconnect();
                //this.UseWaitCursor = false;
                this.Hide();
                Main main = new Main(db);
                main.ShowDialog();
                Application.Exit();
            }
        }
        private void dangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checklogin();
            }
        }
        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checklogin();
            }
        }
        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checklogin();
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            checklogin();
        }

    }
}
