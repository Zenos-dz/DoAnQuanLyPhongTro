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
    public partial class sqlclient_sodiennuoc : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        protected string logintype = "";
        public sqlclient_sodiennuoc(ref Database db, string logintype)
        {
            InitializeComponent();
            this.db = db;
            disable_all(false, true, tbmaphong); 
            if (logintype != "")
            {
                // hide button
                bAdd.Hide();
                bEdit.Hide();
                bDelete.Hide();
                bSave.Hide();
                bFind.Hide();
                bCancel.Hide();
                var dt = db.getData($"SELECT maphong FROM hopdong WHERE manguoithue = '{logintype}'");
                try
                {
                    logintype = dt.Rows[0][0].ToString();
                }
                catch
                {
                    logintype = "   ";
                }
                this.logintype = logintype;
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
            tbcsdc.Enabled = true;
            tbcsdm.Enabled = true;
            tbcsnc.Enabled = true;
            tbcsnm.Enabled = true;
            tbmaphong.Enabled = true;
            tbthang.Enabled = true;
            tbnam.Enabled = true;
            //except
            foreach (var item in ex)
            {
                item.Enabled = false;
            }
        }
        //disable all button and textbox with except
        void disable_all(bool disablebt = true, bool disabletb = true,params Control[] ex)
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
            if (disabletb == true) { 
                tbcsdc.Enabled = false;
                tbcsdm.Enabled = false;
                tbcsnc.Enabled = false;
                tbcsnm.Enabled = false;
                tbmaphong.Enabled = false;
                tbthang.Enabled = false;
                tbnam.Enabled = false;
            }
            //ex object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void bangsodiennuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmaphong.Text = bangsodiennuoc.Rows[pos].Cells[0].Value.ToString();
            tbthang.Text = bangsodiennuoc.Rows[pos].Cells[1].Value.ToString();
            tbnam.Text = bangsodiennuoc.Rows[pos].Cells[2].Value.ToString();
            tbcsdc.Text = bangsodiennuoc.Rows[pos].Cells[3].Value.ToString();
            tbcsdm.Text = bangsodiennuoc.Rows[pos].Cells[4].Value.ToString();
            tbcsnc.Text = bangsodiennuoc.Rows[pos].Cells[5].Value.ToString();
            tbcsnm.Text = bangsodiennuoc.Rows[pos].Cells[6].Value.ToString();

        }
        void loadbang(string temp = null)
        {
            if(logintype != "")
            {
                bangsodiennuoc.DataSource = db.getData($"SELECT * FROM sodiennuoc WHERE maphong = {logintype}");
                return;
            }
            if(temp == null) { 
                bangsodiennuoc.DataSource = db.getData("SELECT * FROM sodiennuoc");
            }
            else
            {
                bangsodiennuoc.DataSource = db.getData(temp);
            }
        }
        private void sodiennuoc_Load(object sender, EventArgs e)
        {
            loadbang();
        }
        //button
        private void bCancel_Click(object sender, EventArgs e)
        {
            if(savebutton == "find")
            {
                loadbang();
            }
            enable_all();
            savebutton = "";
            disable_all(false, true, tbmaphong);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            disable_all(true,false,bAdd,bSave);
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
            disable_all(true, true, bFind,tbmaphong);
            savebutton = "find";
            loadbang($"SELECT * FROM sodiennuoc WHERE maphong = '{tbmaphong.Text}'");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true) { 
                db.cmd($"DELETE FROM sodiennuoc WHERE maphong= '{tbmaphong.Text}'");
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
                        db.cmd($"UPDATE sodiennuoc SET " +
                            $"thang = {tbthang.Text}," +
                            $"nam = {tbnam.Text}," +
                            $"ChiSoDienCu = {tbcsdc.Text}," +
                            $"ChiSoDienMoi = {tbcsdm.Text}," +
                            $"ChiSoNuocCu = {tbcsnc.Text}," +
                            $"ChiSoNuocMoi = {tbcsnm.Text}" +
                            $" WHERE maphong = '{tbmaphong.Text}'");
                        loadbang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }

                    break;
                case "add":
                    try { 
                        db.cmd($"INSERT INTO sodiennuoc VALUES ('{tbmaphong.Text}'," +
                            $"{tbthang.Text}," +
                            $"{tbnam.Text}," +
                            $"{tbcsdc.Text}," +
                            $"{tbcsdm.Text}," +
                            $"{tbcsnc.Text}," +
                            $"{tbcsnm.Text}" +
                            $")");
                        loadbang();
                    }
                    catch (Exception ex){
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!"+ex.Message.ToString());
                    }
                    break;
            }
        }
    }
}
