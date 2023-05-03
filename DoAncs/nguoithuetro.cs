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
    public partial class nguoithuetro : Form
    {
        Database db = null;
        string savebutton = "";
        public nguoithuetro(Database db)
        {
            InitializeComponent();
            this.db = db;
            disable_all(false, true, tbmanguoithue);
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
            tbmanguoithue.Enabled = true;
            tbtennguoithue.Enabled = true;
            tbcmnd.Enabled = true;
            tbgioitinh.Enabled = true;
            tbngaysinh.Enabled = true;
            tbsdt.Enabled = true;
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
                tbmanguoithue.Enabled = false;
                tbtennguoithue.Enabled = false;
                tbcmnd.Enabled = false;
                tbgioitinh.Enabled = false;
                tbngaysinh.Enabled = false;
                tbsdt.Enabled = false;
            }
            //ex object
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
            tbngaysinh.Text = bangnguoithuetro.Rows[pos].Cells[3].Value.ToString();
            tbsdt.Text = bangnguoithuetro.Rows[pos].Cells[2].Value.ToString();
            tbcmnd.Text = bangnguoithuetro.Rows[pos].Cells[3].Value.ToString();

        }
        void loadbang(string temp = null)
        {
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
        //button
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
                    //lỗi khóa phụ
                }
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
                        db.cmd($"UPDATE nguoithuetro SET " +
                            $"thang = {tbtennguoithue.Text}," +
                            $"nam = {tbgioitinh.Text}," +
                            $"ChiSoDienCu = {tbngaysinh.Text}," +
                            $" WHERE manguoithue = {tbmanguoithue.Text}");
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
                        db.cmd($"INSERT INTO nguoithuetro VALUES ({tbmanguoithue.Text}," +
                            $"{tbtennguoithue.Text}," +
                            $"{tbgioitinh.Text}," +
                            $"{tbngaysinh.Text}," +
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
