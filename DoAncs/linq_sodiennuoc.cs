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
    public partial class linq_sodiennuoc : Form
    {
        protected QUANLYTRO_LINQ_Entities qlt = null;
        protected SoDienNuoc linq_sodiennuoc_val = new SoDienNuoc();
        protected string savebutton = "";
        protected string logintype = "";
        public linq_sodiennuoc(QUANLYTRO_LINQ_Entities qlt, string logintype)
        {
            InitializeComponent();
            this.qlt = qlt;
            disable_all(false, true, tbmaphong);
            if(logintype!= "")
            {
                // hide button
                bAdd.Hide();
                bEdit.Hide();
                bDelete.Hide();
                bSave.Hide();
                bFind.Hide();
                bCancel.Hide();
                try { 
                    //lấy mã phòng từ mã người thuê logintype
                    var query = from inn in qlt.HopDong
                                where (inn.MaNguoiThue == logintype)
                                select inn.MaPhong;
                    var dt = query.ToList();
                    logintype = dt[0];
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
            if (logintype != "")
            {
                var load = from inn in qlt.SoDienNuoc
                           where (inn.MaPhong == logintype)
                           select inn;
                bangsodiennuoc.DataSource = load.ToList();
                return;
            }
            if (temp == null) {
                var load = from inn in qlt.SoDienNuoc
                           select inn;
                bangsodiennuoc.DataSource = load.ToList();
            }
            else
            {
                var load = from inn in qlt.SoDienNuoc
                           where (inn.MaPhong == tbmaphong.Text)
                           select inn;
                bangsodiennuoc.DataSource = load.ToList();
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
            loadbang(tbmaphong.Text);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true) {
                var tempq = from temp2 in qlt.SoDienNuoc
                            where (temp2.MaPhong == tbmaphong.Text)
                            select temp2;
                qlt.SoDienNuoc.Remove(tempq.First());
                qlt.SaveChanges();
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
                        var tempq = from temp2 in qlt.SoDienNuoc
                                    where (temp2.MaPhong == tbmaphong.Text)
                                    select temp2;
                        SoDienNuoc itemuse = tempq.First();
                        itemuse.MaPhong = tbmaphong.Text;
                        itemuse.ChiSoNuocCu = int.Parse(tbcsnc.Text);
                        itemuse.ChiSoNuocMoi = int.Parse(tbcsnm.Text);
                        itemuse.ChiSoDienMoi = int.Parse(tbcsdm.Text);
                        itemuse.ChiSoDienCu = int.Parse(tbcsdc.Text);
                        qlt.SaveChanges();
                        loadbang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kiểm tra dữ liệu nhập vào!" + ex.Message.ToString());
                    }

                    break;
                case "add":
                    try {
                        linq_sodiennuoc_val.MaPhong = tbmaphong.Text;
                        linq_sodiennuoc_val.ChiSoNuocCu = int.Parse(tbcsnc.Text);
                        linq_sodiennuoc_val.ChiSoNuocMoi = int.Parse(tbcsnm.Text);
                        linq_sodiennuoc_val.ChiSoDienMoi = int.Parse(tbcsdm.Text);
                        linq_sodiennuoc_val.ChiSoDienCu = int.Parse(tbcsdc.Text);
                        qlt.SoDienNuoc.Add(linq_sodiennuoc_val);
                        qlt.SaveChanges();
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
