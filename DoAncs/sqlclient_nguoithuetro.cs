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

namespace Doancs
{
    public partial class sqlclient_nguoithuetro : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        protected string logintype = "";
        public sqlclient_nguoithuetro(ref Database db, string logintype)
        {
            InitializeComponent();
            this.db = db;
            this.logintype = logintype;
            disable_all(false, true, tbmanguoithue);
            if (logintype != "")
            {
                 manguoithue
                tbmanguoithue.Enabled = false;
                
                bAdd.Hide();
                
                bDelete.Hide();
                
                bFind.Hide();
                
            }
        }
        
        void enable_all(params Control[] ex)
        {
            
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            
            tbmanguoithue.Enabled = true;
            tbtennguoithue.Enabled = true;
            tbcmnd.Enabled = true;
            tbgioitinh.Enabled = true;
            ngaysinh.Enabled = true;
            tbsdt.Enabled = true;
            
            foreach (var item in ex)
            {
                item.Enabled = false;
            }
        }
        
        void disable_all(bool disablebt = true, bool disabletb = true, params Control[] ex)
        {
            
            if (disablebt == true)
            {
                bAdd.Enabled = false;
                bEdit.Enabled = false;
                bDelete.Enabled = false;
                bSave.Enabled = false;
                bFind.Enabled = false;
            }
            
            if (disabletb == true)
            {
                tbmanguoithue.Enabled = false;
                tbtennguoithue.Enabled = false;
                tbcmnd.Enabled = false;
                tbgioitinh.Enabled = false;
                ngaysinh.Enabled = false;
                tbsdt.Enabled = false;
            }
            
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void bangnguoithuetro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmanguoithue.Text = bangnguoithuetro.Rows[pos].Cells[0].Value.ToString();
            tbtennguoithue.Text = bangnguoithuetro.Rows[pos].Cells[1].Value.ToString();
            tbgioitinh.Text = bangnguoithuetro.Rows[pos].Cells[2].Value.ToString();
            ngaysinh.Text = ((DateTime)bangnguoithuetro.Rows[pos].Cells[3].Value).ToString("dd-MM-yyyy");
            tbsdt.Text = bangnguoithuetro.Rows[pos].Cells[4].Value.ToString();
            tbcmnd.Text = bangnguoithuetro.Rows[pos].Cells[5].Value.ToString();

        }
        void loadbang(string temp = null)
        {
            if (logintype != "")
            {
                bangnguoithuetro.DataSource = db.getData($"SELECT * FROM nguoithuetro WHERE manguoithue = '{logintype}'");
                return;
            }
            if (temp == null)
            {
                bangnguoithuetro.DataSource = db.getData("SELECT * FROM nguoithuetro");
            }
            else
            {
                bangnguoithuetro.DataSource = db.getData(temp);
            }
        }
        private void nguoithuetro_Load(object sender, EventArgs e)
        {
            loadbang();
        }
        
        private void bCancel_Click(object sender, EventArgs e)
        {
            if (savebutton == "find")
            {
                loadbang();
            }
            enable_all();
            savebutton = "";
            disable_all(false, true, tbmanguoithue);
            if(logintype != "")
            {
                tbmanguoithue.Enabled = false;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            enable_all();
            disable_all(true, false, bAdd, bSave);
            savebutton = "add";
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            enable_all();
            if(logintype == "")
            {     
                disable_all(true, false, bEdit, bSave);
            }
            else
            {
                disable_all(true, true, bEdit, bSave,tbsdt);
            }
            savebutton = "edit";
        }


        private void bFind_Click(object sender, EventArgs e)
        {
            disable_all(true, true, bFind, tbmanguoithue);
            savebutton = "find";
            loadbang($"SELECT * FROM nguoithuetro WHERE manguoithue = {tbmanguoithue.Text}");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                try
                {
                    db.cmd($"DELETE FROM nguoithuetro WHERE manguoithue= {tbmanguoithue.Text}");
                }
                catch
                {
                    
                    MessageBox.Show("Người thuê này đã đăng kí phòng, bạn phải hủy hợp đồng của người thuê này trước khi xóa!");
                }
                loadbang();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int ok = 0;
            switch (savebutton)
            {
                case "":
                    break;
                case "edit":
                    try
                    {
                        db.cmd($"UPDATE nguoithuetro SET " +
                            $"tennguoithue = N'{tbtennguoithue.Text}'," +
                            $"gioitinh = '{tbgioitinh.Text}'," +
                            $"ngaysinh = '{ngaysinh.Value.ToString("MM-dd-yyyy")}'," +
                            $"sdt = '{tbsdt.Text}'," +
                            $"cmnd = '{tbcmnd.Text}' " +
                            $" WHERE manguoithue = {tbmanguoithue.Text}");
                        loadbang();
                        ok = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }

                    break;
                case "add":
                    try
                    {
                        db.cmd($"INSERT INTO nguoithuetro(manguoithue,tennguoithue,gioitinh,ngaysinh,sdt,cmnd)" +
                            $"VALUES ({tbmanguoithue.Text}," +
                            $"N'{tbtennguoithue.Text}'," +
                            $"N'{tbgioitinh.Text}'," +
                            $"'{ngaysinh.Value.ToString("MM-dd-yyyy")}'," +
                            $"'{tbsdt.Text}'," +
                            $"'{tbcmnd.Text}'" +
                            $")");
                        loadbang();
                        ok = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }
                    break;
            }
            if(ok == 1)
            {
                enable_all();
                savebutton = "";
                disable_all(false, true, tbmanguoithue);
                if (logintype != "")
                {
                    tbmanguoithue.Enabled = false;
                }
            }
        }
    }
}
