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
        Database db = null;
        Form temp = null;
        public Main()
        {
            InitializeComponent();
            db = new Database();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (temp != null)
            {
                temp.Close();
            }
            HopDong hd = new HopDong(db);
            hd.TopLevel = false;
            panel1.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            hd.Show();
            temp = hd;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            phongtro pt = new phongtro(db);
            pt.TopLevel = false;
            panel1.Controls.Add(pt);
            pt.Dock = DockStyle.Fill;
            pt.Show();
            temp = pt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            nguoithuetro ntt =  new nguoithuetro();
            ntt.TopLevel = false;
            panel1.Controls.Add(ntt);
            ntt.Dock = DockStyle.Fill;
            ntt.Show();
            temp = ntt;
        }
    }
}
