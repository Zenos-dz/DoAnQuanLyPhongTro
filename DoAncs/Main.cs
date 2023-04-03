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
        public Database db = null;
        Form saveform = null;
        public Main(Database db)
        {
            InitializeComponent();
            this.db = db;
            //test csdl
            //db.cmd("GO");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void hopdong(object sender, EventArgs e)
        {

            if (saveform != null)
            {
                saveform.Close();
            }
            HopDong hd = new HopDong(db);
            hd.TopLevel = false;
            panel1.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            hd.Show();
            saveform = hd;
        }

        private void phongtro(object sender, EventArgs e)
        {
            if (saveform != null)
            {
                saveform.Close();
            }
            phongtro pt = new phongtro(db);
            pt.TopLevel = false;
            panel1.Controls.Add(pt);
            pt.Dock = DockStyle.Fill;
            pt.Show();
            saveform = pt;
        }

        private void nguoithuetro(object sender, EventArgs e)
        {
            if (saveform != null)
            {
                saveform.Close();
            }
            nguoithuetro ntt =  new nguoithuetro(db);
            ntt.TopLevel = false;
            panel1.Controls.Add(ntt);
            ntt.Dock = DockStyle.Fill;
            ntt.Show();
            saveform = ntt;
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
            if (saveform != null)
            {
                saveform.Close();
            }
            sodiennuoc sdn = new sodiennuoc(db);
            sdn.TopLevel = false;
            panel1.Controls.Add(sdn);
            sdn.Dock = DockStyle.Fill;
            sdn.Show();
            saveform = sdn;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveform != null)
            {
                saveform.Close();
            }
            hoadon fhd = new hoadon(db);
            fhd.TopLevel = false;
            panel1.Controls.Add(fhd);
            fhd.Dock = DockStyle.Fill;
            fhd.Show();
            saveform = fhd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveform != null)
            {
                saveform.Close();
            }
            cosovatchat csvc = new cosovatchat(db);
            csvc.TopLevel = false;
            panel1.Controls.Add(csvc);
            csvc.Dock = DockStyle.Fill;
            csvc.Show();
            saveform = csvc;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
            TimerForMainClock.Enabled = true;
            TimerForMainClock.Interval = 1000;
        }

        private void TimerForMainClock_Tick(object sender, EventArgs e)
        {
            if (saveform == null) {
                CLOCK.Show();
                CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
            }
            else
                CLOCK.Hide();
        }
    }
}
