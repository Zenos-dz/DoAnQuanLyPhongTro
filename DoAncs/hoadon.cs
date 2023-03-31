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
    public partial class hoadon : Form
    {
        Database db = null;
        int idhistorybutton = 0;
        public hoadon(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getData(" select * from hoadon ");
        }
    }
}
