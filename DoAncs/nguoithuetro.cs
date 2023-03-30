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
        internal Database db = null;
        public nguoithuetro(Database dbinput)
        {
            InitializeComponent();
            db = dbinput;
        }

        private void nguoithuetro_Load(object sender, EventArgs e)
        {
           /* dataGridView1.DataSource = db.getData("Select * from nguoithuetro");*/
           LoadGridData();
        }

        private void setEnable (bool check)
        {
            txtmanguoithue.Enabled = check;
            txttennguoithue.Enabled = check;
            txtgioitinh.Enabled= check;
            txtngaysinh.Enabled= check;
            txtngaysinh.Enabled = check;
            txtcmnd.Enabled = check;
        }

        private void LoadGridData (string ssql = "")
        {
            dataGridView1.DataSource = null;
            if (string.IsNullOrEmpty(ssql))
            {
                string sql = $"SELECT * from nguoithuetro ";
                dataGridView1.DataSource = db.getData(sql);
            }
            else
            {
                dataGridView1.DataSource = db.getData(ssql);
                setEnable(false);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanguoithue.Text = dataGridView1.Rows[i].Cells["manguoithue"].Value.ToString();
            txttennguoithue.Text = dataGridView1.Rows[i].Cells["tennguoithue"].Value.ToString() ;
            txtngaysinh.Text = dataGridView1.Rows[i].Cells["ngayyinh"].Value.ToString();
            txtgioitinh.Text = dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString();
            txtcmnd.Text = dataGridView1.Rows[i].Cells["cmnd"].Value.ToString();
        }

    }
}
