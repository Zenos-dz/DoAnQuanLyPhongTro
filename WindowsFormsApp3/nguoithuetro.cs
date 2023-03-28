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
    public partial class nguoithuetro : Form
    {
        Database db = null;
        public nguoithuetro()
        {
            InitializeComponent();
            db = new Database();
        }

        private void nguoithuetro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getData("Select * from nguoithuetro");
        }
    }
}
