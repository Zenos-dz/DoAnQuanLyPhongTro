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
    public partial class Report_Start : Form
    {
        Database db = null;
        public List<string> value = null;
        public Report_Start(ref Database db)
        {
            InitializeComponent();
            this.db = db;  
        }

        private void run_Click(object sender, EventArgs e)
        {
            try { 
                var table0 = db.getData($"SELECT manguoithue FROM hopdong WHERE maphong = '{tbmaphong.Text}' ");

                var temp = new report(ref db, table0.Rows[0]["manguoithue"].ToString(), tbmaphong.Text,float.Parse(tbgiadien.Text),float.Parse(tbgianuoc.Text));
                this.Hide();
                temp.ShowDialog();
                this.value = temp.value();
                this.Close();
            }
            catch(Exception ex)
            {
                this.Show();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
