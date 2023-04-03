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
    public partial class sodiennuoc : Form
    {
        Database db = null;
        string savebutton = "";
        public sodiennuoc(Database db)
        {
            InitializeComponent();
            this.db = db;
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
            tbmap.Enabled = true;
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
                tbmap.Enabled = false;
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
            tbmap.Text = bangsodiennuoc.Rows[pos].Cells[0].Value.ToString();
            tbthang.Text = bangsodiennuoc.Rows[pos].Cells[1].Value.ToString();
            tbnam.Text = bangsodiennuoc.Rows[pos].Cells[2].Value.ToString();
            tbcsdc.Text = bangsodiennuoc.Rows[pos].Cells[3].Value.ToString();
            tbcsdm.Text = bangsodiennuoc.Rows[pos].Cells[4].Value.ToString();
            tbcsnc.Text = bangsodiennuoc.Rows[pos].Cells[5].Value.ToString();
            tbcsnm.Text = bangsodiennuoc.Rows[pos].Cells[6].Value.ToString();

        }
        void loadbang(string temp = null)
        {
            if(temp == null) { 
                bangsodiennuoc.DataSource = db.getData("select * from sodiennuoc");
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
            disable_all(true, true, bFind,tbmap);
            savebutton = "find";
            loadbang($"select * from sodiennuoc where maphong = {tbmap.Text}");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true) { 
                db.cmd($"DELETE FROM sodiennuoc where maphong= {tbmap.Text}");
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
                            $" WHERE maphong = {tbmap.Text}");
                        loadbang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }

                    break;
                case "add":
                    try { 
                        db.cmd($"INSERT INTO sodiennuoc VALUES ({tbmap.Text}," +
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
