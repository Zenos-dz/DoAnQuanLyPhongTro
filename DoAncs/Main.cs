using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doancs
{
    public partial class Main : Form
    {
        public Database db = null;
        public QUANLYTRO_LINQ_Entities qlt = new QUANLYTRO_LINQ_Entities();
        Form saveform = null;
        Button savebutton = null;
        bool islogout = false;
        Panel savepanel = null;
        //for database and clock
        public Main(Database db)
        {
            InitializeComponent();
            this.db = db;
            //setup clock
            CLOCK.ForeColor = SystemColors.MenuBar;
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
            TimerForMainClock.Enabled = true;
            TimerForMainClock.Interval = 1000;
            //hide menu dropdown
            //csvc_panel.Hide();
        }
        private void TimerForMainClock_Tick(object sender, EventArgs e)
        { 
            //reset realtime clock
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        //hide pannel nếu click 2 lần, nếu click lần đầu : mở panel + đóng panel trước đó(nếu có)
        private void Check2ndClick(Panel inputPanel)
        {
            if (savepanel == inputPanel)
            {
                //nếu click 2 lần
                savepanel.Hide();
                savepanel = null;
            }
            else { 
                //click lần đầu
                if(savepanel != null) {
                    //đóng panel đã mở trước đó nếu có
                    savepanel.Hide();
                }
                savepanel = inputPanel;
                savepanel.Show();
            }
        }
        //for form
        private void loadchildform(Form anyform,Button anybutton,bool holdopenpanel = false)
        {
            //form control
            if (saveform != null)
            {
                saveform.Close();
                //savebutton.ForeColor = Color.MidnightBlue;
                savebutton.FlatAppearance.BorderColor = default;
                savebutton.FlatAppearance.BorderSize = 1;
                savebutton.BackColor = default;
                savebutton.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                //stop clock in main form
                CLOCK.Hide();
                txt_welcome.Hide();
                TimerForMainClock.Stop();
            }
            //for pannel
            if (savepanel != null && holdopenpanel == false)
            {
                savepanel.Hide();
                savepanel = null;
            }
            //anybutton.ForeColor = Color.MidnightBlue;
            anybutton.FlatAppearance.BorderColor = Color.DarkCyan;//Color.FromArgb(238,238,0);
            anybutton.FlatAppearance.BorderSize = 1;
            anybutton.FlatStyle = FlatStyle.Flat;
            anybutton.BackColor = Color.Blue;
            anyform.TopLevel = false;
            panel1.Controls.Add(anyform);
            anyform.Dock = DockStyle.Fill;
            //anyform.Show(Parent);
            anyform.Show();
            saveform = anyform;
            savebutton = anybutton;
        }
        private void hopdong(object sender, EventArgs e)
        {
            sqlclient_hopdong hd = new sqlclient_hopdong(db);
            loadchildform(hd,a3hopdong);
        }
        private void phongtro(object sender, EventArgs e)
        {
            Check2ndClick(phongtro_panel);
            
        }
        private void phongtrolinq_Click(object sender, EventArgs e)
        {
            linq_phongtro pt = new linq_phongtro(qlt);
            loadchildform(pt, a1phongtro,true);
        }

        private void phongtrosql_Click(object sender, EventArgs e)
        {
            sqlclient_phongtro pt = new sqlclient_phongtro(db);
            loadchildform(pt, a1phongtro, true);
        }
        private void nguoithuetro(object sender, EventArgs e)
        {
            sqlclient_nguoithuetro ntt = new sqlclient_nguoithuetro(db);
            loadchildform(ntt, a2nguoithue);
        }
        private void hoadon(object sender, EventArgs e)
        {
            sqlclient_hoadon fhd = new sqlclient_hoadon(db);
            loadchildform(fhd,a5hoadon);
        }
        private void cosovchat(object sender, EventArgs e)
        {
            Check2ndClick(csvc_panel);
        }
        private void csvc_linq_Click(object sender, EventArgs e)
        {
            linq_cosovatchat csvc = new linq_cosovatchat(qlt);
            loadchildform(csvc, bcsvc, true);
        }
        private void csvc_sqlclient_Click(object sender, EventArgs e)
        {
            sqlclient_cosovatchat csvc = new sqlclient_cosovatchat(db);
            loadchildform(csvc, bcsvc,true);
        }
        private void sdn_Click(object sender, EventArgs e)
        {
            Check2ndClick(sodiennuoc_panel);
        }
        private void sodiennuoclinq_Click(object sender, EventArgs e)
        {
            linq_sodiennuoc sdn = new linq_sodiennuoc(qlt);
            loadchildform(sdn, a4sodiennuoc, true);
        }

        private void sodiennuocsql_Click(object sender, EventArgs e)
        {
            sqlclient_sodiennuoc sdn = new sqlclient_sodiennuoc(db);
            loadchildform(sdn, a4sodiennuoc, true);
        }
        private void logout_Click(object sender, EventArgs e)
        {
            islogout = true;
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (islogout == false)
            {
                Environment.Exit(0);
            }
        }
        //hover in
        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.MidnightBlue;
        }

        //hover out
        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = default;
        }

        private void logo_main_Click(object sender, EventArgs e)
        {
            //form control
            if (saveform != null)
            {
                TimerForMainClock.Start();
                CLOCK.Show();
                txt_welcome.Show();
                saveform.Close();
                //savebutton.ForeColor = Color.MidnightBlue;
                savebutton.FlatAppearance.BorderColor = default;
                savebutton.FlatAppearance.BorderSize = 1;
                savebutton.BackColor = default;
                savebutton.FlatStyle = FlatStyle.Flat;
                savebutton = null; 
                saveform = null;
            }
        }

    }
}
