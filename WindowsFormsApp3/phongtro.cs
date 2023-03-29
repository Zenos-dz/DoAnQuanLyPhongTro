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
    public partial class phongtro : Form
    {
        Database db = null;
        public phongtro(Database dbinput)
        {
            InitializeComponent();
            db = dbinput;
        }

        private void phongtro_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }
        private void setEnable (bool check) 
        {
            txtdientich.Enabled = check;
            txtgiatien.Enabled = check;
            txtgiatien.Enabled = check;
            txttenphong.Enabled = check;
        }
        private void LoadGridData ()
        {
            Database db = new Database();
            string sql = "SELECT * from phongtro order by dientich";
            dgvUsers.DataSource = db.getData(sql);
            setEnable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtdientich.Text = dgvUsers.Rows[i].Cells["dientich"].Value.ToString();
            txtgiatien.Text = dgvUsers.Rows[i].Cells["giatien"].Value.ToString();
            txtmaphong.Text = dgvUsers.Rows[i].Cells["maphong"].Value.ToString();
            txttenphong.Text = dgvUsers.Rows[i].Cells["tenphong"].Value.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
           
          
                btnAddnew.Enabled = false;
                setEnable(true);
                txtdientich.Clear();
                txtgiatien.Clear();
                txtmaphong.Clear();
                txttenphong.Focus();
            }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txttenphong.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin tên phòng không được để trống!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txttenphong.Focus();
                return;
            }
            string uid = txttenphong.Text;
            string fn = txtmaphong.Text;
            string un = txtgiatien.Text;
            string pw = txtdientich.Text;
            if(btnAddnew.Enabled)
            {
                string ssql = string.Format("insert into phongtro(maphong,tenphong,giatien,dientich)values" +
                    "(N'{0}',N'{1}',N'{2}',N'{3}')", uid, fn, un, pw);
                Database db = new Database();
                db.runQuery(ssql);
                LoadGridData();
            }
            else
            {
                int r = dgvUsers.CurrentRow.Index;
                string id = dgvUsers.Rows[r].Cells[0].Value.ToString();
                string ssql = string.Format("Update phongtro SET" +
                                        " tenphong = N'{0}'," +
                                        " maphong = N'{1}'," +
                                        " giatien = N'{2}'," +
                                        " dientich = N'{3}'", uid, fn, un, pw);
                Database db = new Database();
                db.runQuery(ssql);
                LoadGridData();                         
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvUsers.CurrentRow.Index;
            string uid = dgvUsers.Rows[r].Cells[0].Value.ToString();
            string sSql = string.Format("DELETE FROM phongtro where tenphong={0}",uid);
            Database db = new Database();
            db.runQuery(sSql);
            LoadGridData();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddnew.Enabled = false;
            setEnable(true);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }
    }
}
