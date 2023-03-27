using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        Database db = new Database();
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong(db);
            hd.TopLevel = false;
            panel1.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            hd.Show();
        }

    }
}
