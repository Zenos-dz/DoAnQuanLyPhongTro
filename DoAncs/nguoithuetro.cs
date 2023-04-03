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

        private void setEnable(bool check)
        {
            txtmanguoithue.Enabled = check;
            txttennguoithue.Enabled = check;
            txtgioitinh.Enabled = check;
            txtngaysinh.Enabled = check;
            txtngaysinh.Enabled = check;
            txtcmnd.Enabled = check;
        }

        private void LoadGridData(string ssql = "")
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
            btndelete.Enabled = false;
            btnsave.Enabled = false;
            /*  btnadd.Enabled = false;*/
            btnedit.Enabled = false;
            setEnable(true);
            txtcmnd.Clear();
            txtgioitinh.Clear();
            txtngaysinh.Clear();
            txtmanguoithue.Clear();
            txttennguoithue.Clear();
            txtsdt.Clear();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanguoithue.Text = dataGridView1.Rows[i].Cells["manguoithue"].Value.ToString();
            txttennguoithue.Text = dataGridView1.Rows[i].Cells["tennguoithue"].Value.ToString();
            txtngaysinh.Text = dataGridView1.Rows[i].Cells["ngaysinh"].Value.ToString();
            txtgioitinh.Text = dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString();
            txtcmnd.Text = dataGridView1.Rows[i].Cells["cmnd"].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btndelete.Enabled = false;
            setEnable(true);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(true);
            btnadd.Enabled = true;
            btnsave.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string exp = " ";
            if (!string.IsNullOrEmpty(txtmanguoithue.Text))
            {
                exp += $"where manguoithue = {txtmanguoithue.Text}";
            }
            string ssql = $"SELECT * FROM NGUOITHUETRO{exp} ";
            LoadGridData(ssql);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttennguoithue.Text.Trim() == "")
                {
                    MessageBox.Show("Thông tin tên người thuê không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttennguoithue.Focus();
                    return;
                }
                string uid = txtmanguoithue.Text;
                string hn = txttennguoithue.Text;
                string an = txtgioitinh.Text;
                string fn = txtngaysinh.Text;
                string ah = txtsdt.Text;
                string dn = txtcmnd.Text;
                if (btnadd.Enabled == true)
                {
                    string ssql = $"INSERT INTO NGUOITHUETRO(manguoithue, tennguoithue, gioitinh, ngaysinh, sdt,cmnd) values" +
                        $" ({uid}, {hn}, {an}, {fn} ,{ah} ,{dn})";
                    Database db = new Database();
                    db.runQuery(ssql);
                    LoadGridData();
                }
                if (btnedit.Enabled == true)
                {
                    int r = dataGridView1.CurrentRow.Index;
                    string id = dataGridView1.Rows[r].Cells[0].Value.ToString();
                    string ssql = string.Format("Update nguoithuetro SET" +
                                                  "manguoithue = N'{0}'," +
                                                  "tennguoithue = N'{1}," +
                                                  "gioitinh = N'{2}," +
                                                  "ngaysinh = N'{3}'," +
                                                  "sdt = N'{4}'," +
                                                  "cmnd = N'{5}',"
                                                  + $"where manguoithue = {uid}"
                                                  , uid, hn, an, fn, ah, dn);
                    Database db = new Database();
                    db.runQuery(ssql);
                    LoadGridData();
                }
                btnadd.Enabled = true;
                btnsave.Enabled = true;
                btnedit.Enabled = true;
                btndelete.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
               
        }
    }
}
