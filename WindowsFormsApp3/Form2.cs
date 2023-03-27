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
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }
        Database db= null;
        public HopDong(Database dbinput)
        {
            db = dbinput;
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getData("select * from hopdong");
        }
    }
}
