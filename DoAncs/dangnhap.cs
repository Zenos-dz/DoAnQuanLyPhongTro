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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
       
           this.Hide();
            Main main = new Main(db);
            main.ShowDialog();
            Application.Exit();
        }
        void call_main()
        {
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
