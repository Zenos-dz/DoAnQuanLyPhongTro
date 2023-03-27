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
            txtdientich.Enabled = false;
            txtgiatien.Enabled = false;
            txtgiatien.Enabled = false;
            txttenphong.Enabled = false;
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
            txttenphong.Text = dgvUsers.Rows[i].Cells["tienphong"].Value.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate {
                    btnAddnew_Click(sender, e);
                });
            }
            else
            {
                btnAddnew.Enabled = false;
                setEnable(true);
                txtdientich.Clear();
                txtgiatien.Clear();
                txtmaphong.Clear();
                txttenphong.Focus();
            }
        }
    private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvUsers.CurrentRow.Index;
            string uid = dgvUsers.Rows[r].Cells[0].Value.ToString();
            string sSql = string.Format("delete from phongtro wehere maphong = N'{0}'", uid);
            Database db = new Database();
            db.runQuery(sSql);
            LoadGridData();

        }
    }
}
