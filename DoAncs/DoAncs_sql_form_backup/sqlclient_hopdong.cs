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
    public partial class HopDong : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        public HopDong(Database dbinput)
        {
            InitializeComponent();
            db = dbinput;
            disable_all(false, true, tbmaphong);
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            loadbang();
        }

        //enable all button and textbox with except
        void enable_all(params Control[] ex)
        {
            //enable button
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            //enable textbox
            tbmaphong.Enabled = true;
            tbmahd.Enabled = true;
            tbmanguoithue.Enabled = true;
            ngaythue.Enabled = true;
            ngayketthuc.Enabled = true;
            //disable except object
            foreach (var item in ex)
            {
                item.Enabled = false;
            }
        }
        //disable all button and textbox with except
        void disable_all(bool disablebt = true, bool disabletb = true, params Control[] ex)
        {
            //disable button
            if (disablebt == true)
            {
                bAdd.Enabled = false;
                bEdit.Enabled = false;
                bDelete.Enabled = false;
                bSave.Enabled = false;
                bFind.Enabled = false;
            }
            //disable textbox
            if (disabletb == true)
            {
                tbmaphong.Enabled = false;
                tbmahd.Enabled = false;
                tbmanguoithue.Enabled = false;
                ngaythue.Enabled = false;
                ngayketthuc.Enabled = false;
            }
            //enable except object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void banghopdong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmahd.Text = banghopdong.Rows[pos].Cells[0].Value.ToString();
            tbmaphong.Text = banghopdong.Rows[pos].Cells[1].Value.ToString();
            tbmanguoithue.Text = banghopdong.Rows[pos].Cells[2].Value.ToString();
            ngaythue.Text =  ((DateTime)banghopdong.Rows[pos].Cells[3].Value).ToString("dd-MM-yyyy");
            ngayketthuc.Text = ((DateTime)banghopdong.Rows[pos].Cells[4].Value).ToString("dd-MM-yyyy");

        }
        void loadbang(string temp = null)
        {
            if (temp == null)
            {
                banghopdong.DataSource = db.getData("SELECT * FROM hopdong");
            }
            else
            {
                banghopdong.DataSource = db.getData(temp);
            }
        }
        //button controll
        private void bCancel_Click(object sender, EventArgs e)
        {
            if (savebutton == "find")
            {
                loadbang();
            }
            enable_all();
            savebutton = "";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
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
            loadbang($"SELECT * FROM hopdong WHERE maphong = {tbmaphong.Text}");
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                db.cmd($"DELETE FROM hopdong WHERE maphong= {tbmaphong.Text}");
                loadbang();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            switch (savebutton)
            {
                case "":
                    break;
                case "edit":
                    try
                    {
                        db.cmd($"UPDATE hopdong SET " +
                            $" maphong = {tbmaphong.Text}, " +
                            $" manguoithue = {tbmanguoithue.Text}, " +
                            $" ngaybatdauthue = '{ngaythue.Value.ToString("MM-dd-yyyy")}', " +
                            $" ngayketthucthue = '{ngayketthuc.Value.ToString("MM-dd-yyyy")}' " +
                            $" WHERE maphong = {tbmahd.Text}");
                        loadbang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }

                    break;
                case "add":
                    try
                    {
                        db.cmd($"INSERT INTO hopdong VALUES ({tbmahd.Text}," +
                            $" {tbmaphong.Text},  " +
                            $" {tbmanguoithue.Text}, " +
                            $" '{ngaythue.Value.ToString("MM-dd-yyyy")}', " +
                            $" '{ngayketthuc.Value.ToString("MM-dd-yyyy")}' " +
                            $")");
                        loadbang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }
                    break;
            }
        }
    }
}
