using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doancs
{
    public partial class Main : Form
    {
        public Database db = null;
        Form saveform = null;

        //for database and clock
        public Main(Database db)
        {
            InitializeComponent();
            CLOCK.ForeColor = SystemColors.Control;
            this.db = db;
            //setup clock
            CLOCK.ForeColor = SystemColors.ControlText;
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
            TimerForMainClock.Enabled = true;
            TimerForMainClock.Interval = 1000;
        }
        private void TimerForMainClock_Tick(object sender, EventArgs e)
        {
            //reset time clock
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        //for form
        private void loadchildform(Form anyform)
        {
            //form control
            if (saveform != null)
            {
                saveform.Close();
            }
            else
            {
                //stop clock in main form
                CLOCK.Hide();
                TimerForMainClock.Stop();
            }
            anyform.TopLevel = false;
            panel1.Controls.Add(anyform);
            anyform.Dock = DockStyle.Fill;
            anyform.Show();
            saveform = anyform;
        }
        private void hopdong(object sender, EventArgs e)
        {

            HopDong hd = new HopDong(db);
            loadchildform(hd);
        }
        private void phongtro(object sender, EventArgs e)
        {
            phongtro pt = new phongtro(db);
            loadchildform(pt);
        }
        private void nguoithuetro(object sender, EventArgs e)
        {
            nguoithuetro ntt =  new nguoithuetro(db);
            loadchildform(ntt);
        }
        private void hoadon(object sender, EventArgs e)
        {
            hoadon fhd = new hoadon(db);
            loadchildform(fhd);
        }
        private void cosovchat(object sender, EventArgs e)
        {
            cosovatchat csvc = new cosovatchat(db);
            loadchildform(csvc);
        }
        private void sdn_Click(object sender, EventArgs e)
        {
            sodiennuoc sdn = new sodiennuoc(db);
            loadchildform(sdn);
        }
    }
}
