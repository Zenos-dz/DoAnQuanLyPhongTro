using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class setting : Form
    {
        protected Database db = null;
        protected string logintype;
        public setting(Database db,string logintype)
        {
            InitializeComponent();
            this.db = db;
            this.logintype = logintype;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (this.logintype == "")
            {
                dt = db.getData($"SELECT * FROM nguoidung WHERE password = '{tboldpass}'");
            }
            else
            {
                dt = db.getData($"SELECT * FROM nguoithuetro WHERE pass = '{tboldpass}'");
            }
            try
            {
                string temp = dt.Rows[0][1].ToString();
                lboldpass.Text = "OK";
            }
            catch
            {
                lboldpass.Text = "X";
                return;
            }
            if (tbnewpass == tbnewpass2 && tbnewpass.Text.IndexOf(" ") != -1)
            {
                if (this.logintype == "")
                {
                    db.cmd($"UPDATE nguoidung SET " +
                            $"password = '{tbnewpass}'," +
                            $" WHERE manguoithue = 'admin'");
                }
                else
                {

                }
            }
        }

        private void tbnewpass2_TextChanged(object sender, EventArgs e)
        {
            if(tbnewpass == tbnewpass2)
            {
                lbnewpassmatch.Text = "OK";
            }
            else
            {
                lbnewpassmatch.Text = "X";
            }
        }

        private void tbnewpass_TextChanged(object sender, EventArgs e)
        {
            if (tbnewpass.Text.IndexOf(" ") != -1) //có chứa dấu cách
            {
                lbnewpass.Text = "X";
            }
            else
            {
                lbnewpass.Text = "OK";
            }
        }
    }
}
