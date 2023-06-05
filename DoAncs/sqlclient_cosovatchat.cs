using System;
using System.Windows.Forms;

namespace Doancs
{
    public partial class sqlclient_cosovatchat : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        protected string logintype = "";
        public sqlclient_cosovatchat(ref Database db, string logintype)
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
            //enable button
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            //enable textbox
            tbmaphong.Enabled = true;
            dieuhoa.Enabled = true;
            quatdien.Enabled = true;
            tulanh.Enabled = true;
            binhnonglanh.Enabled = true;
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
                dieuhoa.Enabled = false;
                quatdien.Enabled = false;
                tulanh.Enabled = false;
                binhnonglanh.Enabled = false;
            }
            //enable except object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }
        protected string for_combobox(string anystr)
        {
            if (anystr == "True")
            {
                return "Có";
            }
            return "Không";
        }
        private void bangcosovatchat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmaphong.Text = bangcosovatchat.Rows[pos].Cells[0].Value.ToString();
            dieuhoa.Text = for_combobox(bangcosovatchat.Rows[pos].Cells[1].Value.ToString());
            quatdien.Text = for_combobox(bangcosovatchat.Rows[pos].Cells[2].Value.ToString());
            tulanh.Text = for_combobox(bangcosovatchat.Rows[pos].Cells[3].Value.ToString());
            binhnonglanh.Text = for_combobox(bangcosovatchat.Rows[pos].Cells[4].Value.ToString());

        }
        void loadbang(string temp = null)
        {
            if (logintype != "")
            {
                bangcosovatchat.DataSource = db.getData($"SELECT * FROM cosovatchat WHERE maphong = '{logintype}'");
                return;
            }
            if (temp == null)
            {
                bangcosovatchat.DataSource = db.getData("SELECT * FROM cosovatchat");
            }
            else
            {
                bangcosovatchat.DataSource = db.getData(temp);
            }
        }
        private void cosovatchat_Load(object sender, EventArgs e)
        {
            loadbang();
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
            loadbang($"SELECT * FROM cosovatchat WHERE maphong = '{tbmaphong.Text}'");
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                db.cmd($"DELETE FROM cosovatchat WHERE maphong= '{tbmaphong.Text}'");
                loadbang();
            }
        }
        protected int for_save(string anystr)
        {
            if (anystr == "Có" || anystr == "có" || anystr == "Yes" || anystr == "yes")
            {
                return 1;
            }
            return 0;
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
                        db.cmd($"UPDATE cosovatchat SET " +
                            $" dieuhoa = {for_save(dieuhoa.Text)},  " +
                            $" quatdien = {for_save(quatdien.Text)}, " +
                            $" tulanh = {for_save(tulanh.Text)}, " +
                            $" binhnonglanh = {for_save(binhnonglanh.Text)} " +
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
                        db.cmd($"INSERT INTO cosovatchat VALUES ('{tbmaphong.Text}'," +
                            $" {for_save(dieuhoa.Text)},  " +
                            $" {for_save(quatdien.Text)}, " +
                            $" {for_save(tulanh.Text)}, " +
                            $" {for_save(binhnonglanh.Text)} " +
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
