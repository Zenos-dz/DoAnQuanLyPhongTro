using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class dangnhap : Form
    {
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
            user.BackColor = Color.FromArgb(0, Color.Red); ;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.BackColor = Color.Transparent; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
