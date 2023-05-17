using System;
using System.Linq;
using System.Windows.Forms;

namespace Doancs
{
    public partial class linq_cosovatchat : Form
    {
        QUANLYTRO_LINQ_Entities qlt = null;
        CoSoVatChat linq_cosovatchat_val = new CoSoVatChat();
        string savebutton = "";
        public linq_cosovatchat(QUANLYTRO_LINQ_Entities qlt)
        {
            InitializeComponent();
            this.qlt = qlt;
            disable_all(false, true, tbmaphong);
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
