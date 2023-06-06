using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doancs
{
    public partial class Main : Form
    {
        private Database db = null;
        private QUANLYTRO_LINQ_Entities qlt = new QUANLYTRO_LINQ_Entities();
        protected Form saveform = null;
        protected Button savebutton = null;
        protected bool islogout = false;
        protected Panel savepanel = null;
        protected string logintype = "";
        public Main(ref Database db, string logintype)
        {
            InitializeComponent();
            this.db = db;
            this.logintype = logintype; 
            CLOCK.ForeColor = SystemColors.MenuBar;
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
            TimerForMainClock.Enabled = true;
            TimerForMainClock.Interval = 1000;
        }
        private void TimerForMainClock_Tick(object sender, EventArgs e)
        { 
            CLOCK.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void Check2ndClick(Panel inputPanel)
        {
            if (savepanel == inputPanel)
            {
                savepanel.Hide();
                savepanel = null;
            }
            else { 
                if(savepanel != null) {
                    savepanel.Hide();
                }
                savepanel = inputPanel;
                savepanel.Show();
            }
        }
        private void loadchildform(Form anyform,Button anybutton,bool holdopenpanel = false)
        {
            if(anybutton == savebutton || anyform == saveform)
            {
                return;
            }
            if (saveform != null)
            {
                saveform.Close();
                savebutton.FlatAppearance.BorderColor = default;
                savebutton.FlatAppearance.BorderSize = 1;
                savebutton.BackColor = default;
                savebutton.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                CLOCK.Hide();
                txt_welcome.Hide();
                TimerForMainClock.Stop();
            }
            if (savepanel != null && holdopenpanel == false)
            {
                savepanel.Hide();
                savepanel = null;
            }
            anybutton.FlatAppearance.BorderColor = Color.DarkCyan;
            anybutton.FlatAppearance.BorderSize = 1;
            anybutton.FlatStyle = FlatStyle.Flat;
            anybutton.BackColor = Color.Blue;
            anyform.TopLevel = false;
            panel1.Controls.Add(anyform);
            anyform.Dock = DockStyle.Fill;
            anyform.Show();
            saveform = anyform;
            savebutton = anybutton;
        }
        private void hopdong(object sender, EventArgs e)
        {
            sqlclient_hopdong hd = new sqlclient_hopdong(ref db,logintype);
            loadchildform(hd,a3hopdong);
        }
        private void phongtro(object sender, EventArgs e)
        {
            Check2ndClick(phongtro_panel);
            
        }
        private void phongtrolinq_Click(object sender, EventArgs e)
        {
            linq_phongtro pt = new linq_phongtro(ref qlt,logintype);
            loadchildform(pt, a1phongtro,true);
        }

        private void phongtrosql_Click(object sender, EventArgs e)
        {
            sqlclient_phongtro pt = new sqlclient_phongtro(ref db,logintype);
            loadchildform(pt, a1phongtro, true);
        }
        private void nguoithuetro(object sender, EventArgs e)
        {
            sqlclient_nguoithuetro ntt = new sqlclient_nguoithuetro(ref db,logintype);
            loadchildform(ntt, a2nguoithue);
        }
        private void hoadon(object sender, EventArgs e)
        {
            sqlclient_hoadon fhd = new sqlclient_hoadon(ref db,logintype);
            loadchildform(fhd,a5hoadon);
        }
        private void cosovchat(object sender, EventArgs e)
        {
            Check2ndClick(csvc_panel);
        }
        private void csvc_linq_Click(object sender, EventArgs e)
        {
            linq_cosovatchat csvc = new linq_cosovatchat(ref qlt,logintype);
            loadchildform(csvc, bcsvc, true);  
        }
        private void csvc_sqlclient_Click(object sender, EventArgs e)
        {
            sqlclient_cosovatchat csvc = new sqlclient_cosovatchat(ref db,logintype);
            loadchildform(csvc, bcsvc,true);
        }
        private void sdn_Click(object sender, EventArgs e)
        {
            Check2ndClick(sodiennuoc_panel);
        }
        private void sodiennuoclinq_Click(object sender, EventArgs e)
        {
            linq_sodiennuoc sdn = new linq_sodiennuoc(ref qlt,logintype);
            loadchildform(sdn, a4sodiennuoc, true);
        }

        private void sodiennuocsql_Click(object sender, EventArgs e)
        {
            sqlclient_sodiennuoc sdn = new sqlclient_sodiennuoc(ref db,logintype);
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
        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.MidnightBlue;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = default;
        }

        private void logo_main_Click(object sender, EventArgs e)
        {
            if (saveform != null)
            {
                TimerForMainClock.Start();
                CLOCK.Show();
                txt_welcome.Show();
                saveform.Close();
                savebutton.FlatAppearance.BorderColor = default;
                savebutton.FlatAppearance.BorderSize = 1;
                savebutton.BackColor = default;
                savebutton.FlatStyle = FlatStyle.Flat;
                savebutton = null; 
                saveform = null;
            }
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            form_doimatkhau doimk = new form_doimatkhau(ref db, logintype);
            loadchildform(doimk, bchangepass);
        }
    }
}
