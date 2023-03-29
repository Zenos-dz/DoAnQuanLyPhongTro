using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class phongtro : Form
    {
        internal Database db = null;
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
            if (string.IsNullOrEmpty(txtmaphong.Text))
            {

            }
            string sql = "SELECT * from phongtro where ";
            dgvUsers.DataSource = db.getData(sql);
            setEnable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }*/
            string ssql = $" Select * from phongtro where ";
            db.runQuery(ssql);
            LoadGridData();
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtdientich.Text = dgvUsers.Rows[i].Cells["dientich"].Value.ToString();
            txtgiatien.Text = dgvUsers.Rows[i].Cells["giatienphong"].Value.ToString();
            txtmaphong.Text = dgvUsers.Rows[i].Cells["maphong"].Value.ToString();
            txttenphong.Text = dgvUsers.Rows[i].Cells["tenphong"].Value.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            //btnAddnew.Enabled = false;
                btnEdit.Enabled = false;
                setEnable(true);
                txtdientich.Clear();
                txtgiatien.Clear();
                txtmaphong.Clear();
                txttenphong.Focus();
            }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenphong.Text.Trim() == "")
                {
                    MessageBox.Show("Thông tin tên phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttenphong.Focus();
                    return;
                }
                string uid = txttenphong.Text;
                string fn = txtmaphong.Text;
                string un = txtgiatien.Text;
                string pw = txtdientich.Text;
                if (btnAddnew.Enabled == true)
                {
                    string ssql = string.Format("SET IDENTITY_INSERT phongtro ON;insert into phongtro(maphong,tenphong,giatienphong,dientich)values" +
                        "(N'{0}',N'{1}',N'{2}',N'{3}'); SET IDENTITY_INSERT phongtro OFF;", fn, uid, un, pw);
                    Database db = new Database();
                    db.runQuery(ssql);
                    LoadGridData();
                }
                if (btnEdit.Enabled == true)
                {
                    int r = dgvUsers.CurrentRow.Index;
                    string id = dgvUsers.Rows[r].Cells[0].Value.ToString();
                    string ssql = string.Format("Update phongtro SET" +
                                            " tenphong = N'{0}'," +
                                            " maphong = N'{1}'," +
                                            " giatienphong = N'{2}'," +
                                            " dientich = N'{3}'"
                                            + $"where maphong = {fn}"
                                            , uid, fn, un, pw);
                    Database db = new Database();
                    db.runQuery(ssql);
                    LoadGridData();
                }
                btnAddnew.Enabled = true;
                btnSave.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            };
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvUsers.CurrentRow.Index;
            try
            { 
                string uid = dgvUsers.Rows[r].Cells[0].Value.ToString();
                string sSql = $"DELETE FROM phongtro where maphong={uid}";
                Database db = new Database();
                db.runQuery(sSql);
                LoadGridData();
            }
            catch(Exception ex)
            {
                MessageBox.Show($" Lỗi dòng {r} đã nằm trong bảng thanh toán, bạn có thể muốn xóa dữ liệu trong bảng thanh toán trước ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddnew.Enabled = false;
            btnDelete.Enabled = false;
            setEnable(true);

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(true);
            btnAddnew.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txtmaphong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
