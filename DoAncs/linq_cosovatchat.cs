using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Doancs
{
    public partial class linq_cosovatchat : Form
    {
        protected QUANLYTRO_LINQ_Entities qlt = null;
        protected CoSoVatChat linq_cosovatchat_val = new CoSoVatChat();
        protected string savebutton = "";
        protected string logintype = "";
        public linq_cosovatchat(ref QUANLYTRO_LINQ_Entities qlt, string logintype)
        {
            InitializeComponent();
            this.qlt = qlt;
            disable_all(false, true, tbmaphong);
            if (logintype != "")
            {
                bAdd.Hide();
                bEdit.Hide();
                bDelete.Hide();
                bSave.Hide();
                bFind.Hide();
                bCancel.Hide();
                try
                {
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
        void enable_all(params Control[] ex)
        {
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            
            tbmaphong.Enabled = true;
            dieuhoa.Enabled = true;
            quatdien.Enabled = true;
            tulanh.Enabled = true;
            binhnonglanh.Enabled = true;
            
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
                tbmaphong.Enabled = false;
                dieuhoa.Enabled = false;
                quatdien.Enabled = false;
                tulanh.Enabled = false;
                binhnonglanh.Enabled = false;
            }
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
                var load = from inn in qlt.CoSoVatChat
                           where (inn.MaPhong == logintype)
                           select inn;
                bangcosovatchat.DataSource = load.ToList();
                return;
            }
            if (temp == null)
            {
                var load = from inn in qlt.CoSoVatChat
                           select inn;
                bangcosovatchat.DataSource = load.ToList();
            }
            else
            {
                var load = from inn in qlt.CoSoVatChat
                           where (inn.MaPhong == tbmaphong.Text)
                           select inn;
                bangcosovatchat.DataSource = load.ToList();
            }
        }
        private void cosovatchat_Load(object sender, EventArgs e)
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
            loadbang(tbmaphong.Text);
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                var tempq = from temp2 in qlt.CoSoVatChat
                            where (temp2.MaPhong == tbmaphong.Text)
                            select temp2;
                qlt.CoSoVatChat.Remove(tempq.First());
                qlt.SaveChanges();
                loadbang();
            }
        }
        protected bool for_save(string anystr)
        {
            if (anystr == "Có" )
            {
                return true;
            }
            return false;
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
                        var tempq = from temp2 in qlt.CoSoVatChat
                                    where (temp2.MaPhong == tbmaphong.Text)
                                    select temp2;
                        CoSoVatChat itemuse = tempq.First();
                        itemuse.MaPhong = tbmaphong.Text;
                        itemuse.DieuHoa = for_save(dieuhoa.Text);
                        itemuse.QuatDien = for_save(quatdien.Text);
                        itemuse.TuLanh = for_save(tulanh.Text);
                        itemuse.BinhNongLanh = for_save(binhnonglanh.Text);
                        qlt.SaveChanges();
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
                        linq_cosovatchat_val.MaPhong = tbmaphong.Text;
                        linq_cosovatchat_val.DieuHoa = for_save(dieuhoa.Text);
                        linq_cosovatchat_val.QuatDien = for_save(quatdien.Text);
                        linq_cosovatchat_val.TuLanh = for_save(tulanh.Text);
                        linq_cosovatchat_val.BinhNongLanh = for_save(binhnonglanh.Text);
                        qlt.CoSoVatChat.Add(linq_cosovatchat_val);
                        qlt.SaveChanges();
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
