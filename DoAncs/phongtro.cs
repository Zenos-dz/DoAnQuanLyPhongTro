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

namespace Doancs
{
    public partial class phongtro : Form
    {
        internal Database db = new Database();
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
            tbdientich.Enabled = check;
            tbgiatien.Enabled = check;
            tbgiatien.Enabled = check;
            tbtienphong.Enabled = check;
        }
        private void LoadGridData (string ssql = "")
        {
            dgvUsers.DataSource = null;
            if (string.IsNullOrEmpty(ssql))
            { 
                string sql = $"SELECT * FROM phongtro ";
                dgvUsers.DataSource = db.getData(sql);
            }
            else
                dgvUsers.DataSource = db.getData(ssql);
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
            string exp = " ";
            if (!string.IsNullOrEmpty(tbmaph.Text))
            {
                exp += $"WHERE maphong = {tbmaph.Text}";
            }/*
            if (!string.IsNullOrEmpty(txtdientich.Text))
            {
                exp += $"where dientich = {txtdientich.Text}";
            }
            if (!string.IsNullOrEmpty(txtgiatien.Text))
            {
                exp += $"where giatien = {txtgiatien.Text}";
            }
            if (!string.IsNullOrEmpty(txttenphong.Text))
            {
                exp += $"where tenphong = {txttenphong.Text}";
            }*/
            string ssql = $" SELECT * FROM phongtro {exp} ";
            LoadGridData(ssql);
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbdientich.Text = dgvUsers.Rows[i].Cells["dientich"].Value.ToString();
            tbgiatien.Text = dgvUsers.Rows[i].Cells["giatienphong"].Value.ToString();
            tbmaph.Text = dgvUsers.Rows[i].Cells["maphong"].Value.ToString();
            tbtienphong.Text = dgvUsers.Rows[i].Cells["tenphong"].Value.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
                bDelete.Enabled = false;
                bEdit.Enabled = false;
            //btnAddnew.Enabled = false;
                bEdit.Enabled = false;
                setEnable(true);
                tbdientich.Clear();
                tbgiatien.Clear();
                tbmaph.Clear();
                tbtienphong.Focus();
            }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbtienphong.Text.Trim() == "")
                {
                    MessageBox.Show("Thông tin tên phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbtienphong.Focus();
                    return;
                }
                string uid = tbtienphong.Text;
                string fn = tbmaph.Text;
                string un = tbgiatien.Text;
                string pw = tbdientich.Text;
                if (bAdd.Enabled == true)
                {

                    string ssql = $"INSERT INTO phongtro(maphong,tenphong,giatienphong,dientich)VALUES" +
                        $"({fn}, N'{uid}', {un}, {pw})";
                    db.runQuery(ssql);
                    LoadGridData();
                }
                if (bEdit.Enabled == true)
                {
                    int r = dgvUsers.CurrentRow.Index;
                    string id = dgvUsers.Rows[r].Cells[0].Value.ToString();
                    string ssql = string.Format("UPDATE phongtro SET" +
                                            " tenphong = N'{0}'," +
                                            " maphong = N'{1}'," +
                                            " giatienphong = N'{2}'," +
                                            " dientich = N'{3}' "
                                            + $"WHERE maphong = {fn}"
                                            , uid, fn, un, pw);
                    db.runQuery(ssql);
                    LoadGridData();
                }
                bAdd.Enabled = true;
                bSave.Enabled = true;
                bEdit.Enabled = true;
                bDelete.Enabled = true;
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
                string sSql = $"DELETE FROM phongtro WHERE maphong={uid}";
                db.runQuery(sSql);
                LoadGridData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show($" Lỗi dòng {r} đã nằm trong bảng thanh toán, bạn có thể muốn xóa dữ liệu trong bảng thanh toán trước ","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bAdd.Enabled = false;
            bDelete.Enabled = false;
            setEnable(true);

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(true);
            bAdd.Enabled = true;
            bSave.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
        }

        private void txtmaphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
