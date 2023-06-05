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
    public partial class sqlclient_hoadon : Form
    {
        protected Database db = null;
        protected string savebutton = "";
        protected string logintype = "";
        public sqlclient_hoadon(Database db,string logintype)
        {
            InitializeComponent();
            this.db = db;
            this.logintype = logintype;
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
            tbmahd.Enabled = true;
            tbmaphong.Enabled = true;
            tbmanguoithue.Enabled = true;
            tbthanhtien.Enabled = true;
            ngaylap.Enabled = true;
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
                tbmahd.Enabled = false;
                tbmaphong.Enabled = false;
                tbmanguoithue.Enabled = false;
                tbthanhtien.Enabled = false;
                ngaylap.Enabled = false;
            }
            //enable except object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void banghoadon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmahd.Text = banghoadon.Rows[pos].Cells[0].Value.ToString();
            tbmaphong.Text = banghoadon.Rows[pos].Cells[1].Value.ToString();
            tbmanguoithue.Text = banghoadon.Rows[pos].Cells[2].Value.ToString();
            ngaylap.Text = ((DateTime)banghoadon.Rows[pos].Cells[3].Value).ToString("dd-MM-yyyy");
            tbthanhtien.Text = banghoadon.Rows[pos].Cells[4].Value.ToString();

        }
        void loadbang(string temp = null)
        {
            if (logintype != "")
            {
                banghoadon.DataSource = db.getData($"SELECT * FROM hoadon WHERE manguoithue = '{logintype}'");
                return;
            }
            if (temp == null)
            {
                banghoadon.DataSource = db.getData("SELECT * FROM hoadon");
            }
            else
            {
                banghoadon.DataSource = db.getData(temp);
            }
        }
        private void hoadon_Load(object sender, EventArgs e)
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
            disable_all(false, true, tbmanguoithue);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            disable_all(true, true, bAdd, bSave,tbmahd);
            savebutton = "add";
            Report_Start rdlc1 = new Report_Start(db);
            rdlc1.ShowDialog();
            tbmaphong.Text = rdlc1.value[0];
            tbmanguoithue.Text = rdlc1.value[1];
            tbthanhtien.Text = rdlc1.value[2];
            ngaylap.Value = DateTime.Today;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            enable_all();
            disable_all(true, false, bEdit, bSave);
            savebutton = "edit";
        }


        private void bFind_Click(object sender, EventArgs e)
        {
            loadbang($"SELECT * FROM hoadon WHERE maphong = '{tbmaphong.Text}'");
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                db.cmd($"DELETE FROM hoadon WHERE mahoadon= {tbmahd.Text}");
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
                        db.cmd($"UPDATE hoadon SET " +
                            $" maphong = '{tbmaphong.Text}',  " +
                            $" manguoithue = {tbmanguoithue.Text}, " +
                            $" ngaylap = '{ngaylap.Value.ToString("MM-dd-yyyy")}', " +
                            $" thanhtien = {tbthanhtien.Text} " +
                            $" WHERE mahoadon = {tbmahd.Text}");
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
                        db.cmd($"INSERT INTO hoadon VALUES ({tbmahd.Text}," +
                            $" '{tbmaphong.Text}',  " +
                            $" {tbmanguoithue.Text}, " +
                            $" '{ngaylap.Value.ToString("MM-dd-yyyy")}', " +
                            $" {tbthanhtien.Text} " +
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
