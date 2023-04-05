using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Doancs
{
    public partial class cosovatchat : Form
    {
        Database db = null;
        string savebutton = "";
        public cosovatchat(Database db)
        {
            InitializeComponent();
            this.db = db;
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
            tbdieuhoa.Enabled = true;
            tbquatdien.Enabled = true;
            tbtulanh.Enabled = true;
            tbbinhnonglanh.Enabled = true;
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
                tbdieuhoa.Enabled = false;
                tbquatdien.Enabled = false;
                tbtulanh.Enabled = false;
                tbbinhnonglanh.Enabled = false;
            }
            //enable except object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void bangcosovatchat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmaphong.Text = bangcosovatchat.Rows[pos].Cells[0].Value.ToString();
            tbdieuhoa.Text = bangcosovatchat.Rows[pos].Cells[1].Value.ToString();
            tbquatdien.Text = bangcosovatchat.Rows[pos].Cells[2].Value.ToString();
            tbtulanh.Text = bangcosovatchat.Rows[pos].Cells[3].Value.ToString();
            tbbinhnonglanh.Text = bangcosovatchat.Rows[pos].Cells[4].Value.ToString();

        }
        void loadbang(string temp = null)
        {
            if (temp == null)
            {
                bangcosovatchat.DataSource = db.getData("select * from cosovatchat");
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
            loadbang($"select * from cosovatchat where maphong = {tbmaphong.Text}");
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                db.cmd($"DELETE FROM cosovatchat where maphong= {tbmaphong.Text}");
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
                        db.cmd($"UPDATE cosovatchat SET " +
                            $" dieuhoa = {tbdieuhoa.Text},  " +
                            $" quatdien = {tbquatdien.Text}, " +
                            $" tulanh = {tbtulanh.Text}, " +
                            $" binhnonglanh = {tbbinhnonglanh.Text} " +
                            $" WHERE maphong = {tbmaphong.Text}");
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
                        db.cmd($"INSERT INTO cosovatchat VALUES ({tbmaphong.Text}," +
                            $" {tbdieuhoa.Text},  " +
                            $" {tbquatdien.Text}, " +
                            $" {tbtulanh.Text}, " +
                            $" {tbbinhnonglanh.Text} " +
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
