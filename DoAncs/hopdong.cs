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
    public partial class HopDong : Form
    {
        Database db= null;
        public HopDong(Database dbinput)
        {
            InitializeComponent();
            db = dbinput;
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getData("select * from hopdong");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
