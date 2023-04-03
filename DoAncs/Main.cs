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
    public partial class Main : Form
    {
        public Database db = new Database();
        Form temp = null;
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void hopdong(object sender, EventArgs e)
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

        private void phongtro(object sender, EventArgs e)
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

        private void nguoithuetro(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            nguoithuetro ntt =  new nguoithuetro(db);
            ntt.TopLevel = false;
            panel1.Controls.Add(ntt);
            ntt.Dock = DockStyle.Fill;
            ntt.Show();
            temp = ntt;
        }

        private void button7_DockChanged(object sender, EventArgs e)
        {
            a1phongtro.Location = new Point(0, 100);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            sodiennuoc sdn = new sodiennuoc(db);
            sdn.TopLevel = false;
            panel1.Controls.Add(sdn);
            sdn.Dock = DockStyle.Fill;
            sdn.Show();
            temp = sdn;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            hoadon fhd = new hoadon(db);
            fhd.TopLevel = false;
            panel1.Controls.Add(fhd);
            fhd.Dock = DockStyle.Fill;
            fhd.Show();
            temp = fhd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp.Close();
            }
            cosovatchat csvc = new cosovatchat(db);
            csvc.TopLevel = false;
            panel1.Controls.Add(csvc);
            csvc.Dock = DockStyle.Fill;
            csvc.Show();
            temp = csvc;
        }
    }
}
