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
        Database db = null;
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
                string sql = $"SELECT * FROM nguoithuetro ";
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
            btnsave.Enabled = true;
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
            txtngaysinh.Text = ((DateTime)dataGridView1.Rows[i].Cells["ngaysinh"].Value).ToString("dd-MM-yyyy");
            txtgioitinh.Text = dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells["sdt"].Value.ToString();
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
            int r = dataGridView1.CurrentRow.Index;
            try
            {
                string uid  = dataGridView1.Rows[r].Cells[0].Value.ToString();
                ask_form temp = new ask_form();
                temp.ShowDialog();
                if(temp.result == true) { 
                    string sSql = $"DELETE FROM nguoithuetro WHERE manguoithue={uid}";
                    Database db = new Database();
                    db.runQuery(sSql);
                    LoadGridData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

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
            txtsdt.Enabled= false;
            string exp = " ";
            if (!string.IsNullOrEmpty(txtmanguoithue.Text))
            {
                exp += $"WHERE manguoithue = {txtmanguoithue.Text}";
            }
            string ssql = $"SELECT * FROM NGUOITHUETRO{exp} ";
            LoadGridData(ssql);
            txtmanguoithue.Enabled = true;
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
                    string ssql = $"INSERT INTO NGUOITHUETRO values" +
                        $" ('{uid}', N'{hn}', N'{an}', '{fn}' ,'{ah}' ,'{dn}');";
                    Database db = new Database();
                    db.runQuery(ssql);
                    LoadGridData();
                }
                else if (btnedit.Enabled == true)
                {
                    int r = dataGridView1.CurrentRow.Index;
                    string id = dataGridView1.Rows[r].Cells[0].Value.ToString();
                    string ssql = "UPDATE nguoithuetro SET " +
                            $"manguoithue = N'{uid}'," +
                            $"tennguoithue = N'{hn}'," +
                            $"gioitinh = N'{an}'," +
                            $"ngaysinh = N'{fn}'," +
                            $"sdt = N'{ah}'," +
                            $"cmnd = N'{dn}' "
                            + $"WHERE manguoithue = {uid} ";
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
