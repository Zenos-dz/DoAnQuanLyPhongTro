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
    public partial class sqlclient_phongtro : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        protected string logintype = "";
        public sqlclient_phongtro(ref Database db, string logintype)
        {
            InitializeComponent();
            this.db = db;
            disable_all(false, true, tbmaphong);
            this.logintype = logintype;
            if (logintype != "")
            {
                // hide button
                bAdd.Hide();
                bEdit.Hide();
                bDelete.Hide();
                bSave.Hide();
                bFind.Hide();
                bCancel.Hide();
            }
        }
        //enable all button and textbox with except
        void enable_all(params Control[] ex)
        {
            //button
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            //textbox
            tbmaphong.Enabled = true;
            tbdientich.Enabled = true;
            tbgiatien.Enabled = true;
            tbtenphong.Enabled = true;
            //except
            foreach (var item in ex)
            {
                item.Enabled = false;
            }
        }
        //disable all button and textbox with except
        void disable_all(bool disablebt = true, bool disabletb = true, params Control[] ex)
        {
            //button
            if (disablebt == true)
            {
                bAdd.Enabled = false;
                bEdit.Enabled = false;
                bDelete.Enabled = false;
                bSave.Enabled = false;
                bFind.Enabled = false;
            }
            //textbox
            if (disabletb == true)
            {
                tbmaphong.Enabled = false;
                tbdientich.Enabled = false;
                tbgiatien.Enabled = false;
                tbtenphong.Enabled = false;
            }
            //ex object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void bangphongtro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmaphong.Text = bangphongtro.Rows[pos].Cells[0].Value.ToString();
            tbtenphong.Text = bangphongtro.Rows[pos].Cells[1].Value.ToString();
            tbdientich.Text = bangphongtro.Rows[pos].Cells[2].Value.ToString();
            tbgiatien.Text = bangphongtro.Rows[pos].Cells[3].Value.ToString();
        }
        void loadbang(string temp = null)
        {
            if (temp == null)
            {
                bangphongtro.DataSource = db.getData("SELECT * FROM phongtro");
            }
            else
            {
                bangphongtro.DataSource = db.getData(temp);
            }
        }
        private void phongtro_Load(object sender, EventArgs e)
        {
            loadbang();
        }
        //button
        private void bCancel_Click(object sender, EventArgs e)
        {
            if (savebutton == "find")
            {
                loadbang();
            }
            enable_all();
            savebutton = "";
            disable_all(false, true, tbmaphong);
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
            disable_all(true, false, bEdit, bSave);
            savebutton = "edit";
        }


        private void bFind_Click(object sender, EventArgs e)
        {
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
            loadbang($"SELECT * FROM phongtro WHERE maphong = '{tbmaphong.Text}'");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                try { 
                db.cmd($"DELETE FROM phongtro WHERE maphong= '{tbmaphong.Text}'");
                }
                catch
                {
                    //lỗi khóa phụ
                    MessageBox.Show("Phòng này đang được sử dụng, nếu bạn muốn xóa bỏ nó hãy hủy hợp đồng của phòng này!");
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
                        db.cmd($"UPDATE phongtro SET " +
                            $"tenphong = N'{tbtenphong.Text}'," +
                            $"dientich = {tbdientich.Text}," +
                            $"giatienphong = {tbgiatien.Text}," +
                            $" WHERE maphong = '{tbmaphong.Text}'");
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
                        db.cmd($"INSERT INTO phongtro VALUES ('{tbmaphong.Text}'," +
                            $"N'{tbtenphong.Text}'," +
                            $"{tbdientich.Text}," +
                            $"{tbgiatien.Text} " +
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
            if (ok == 1)
            {
                enable_all();
                savebutton = "";
                disable_all(false, true, tbmaphong);
            }
        }
    }
}
