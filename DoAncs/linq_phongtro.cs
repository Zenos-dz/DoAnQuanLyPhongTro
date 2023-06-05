using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Doancs
{
    public partial class linq_phongtro : Form
    {
        protected QUANLYTRO_LINQ_Entities qlt = null;
        protected string savebutton = "";
        protected PhongTro linq_phongtro_val = new PhongTro();
        protected string logintype = "";
        public linq_phongtro(ref QUANLYTRO_LINQ_Entities qlt, string logintype)
        {
            this.qlt = qlt;
            InitializeComponent();
            disable_all(false, true, tbmaphong);
            this.logintype = logintype; 
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
            //button
            bAdd.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bSave.Enabled = true;
            bFind.Enabled = true;
            //textbox
            tbmaphong.Enabled = true;
            tbdientich.Enabled = true;
            tbgiatien.Enabled = true;
            tbtenphong.Enabled = true;
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
                tbmaphong.Enabled = false;
                tbdientich.Enabled = false;
                tbgiatien.Enabled = false;
                tbtenphong.Enabled = false;
            }
            //ex object
            foreach (var item in ex)
            {
                item.Enabled = true;
            }
        }

        private void bangphongtro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            tbmaphong.Text = bangphongtro.Rows[pos].Cells[0].Value.ToString();
            tbtenphong.Text = bangphongtro.Rows[pos].Cells[1].Value.ToString();
            tbdientich.Text = bangphongtro.Rows[pos].Cells[2].Value.ToString();
            tbgiatien.Text = bangphongtro.Rows[pos].Cells[3].Value.ToString();
        }
        void loadbang(string temp = null)
        {
            if (temp == null)
            {
                var load = from inn in qlt.PhongTro
                           select inn;
                bangphongtro.DataSource = load.ToList();
            }
            else
            {
                var load = from inn in qlt.PhongTro
                           where (inn.MaPhong == tbmaphong.Text)
                           select inn; 
                bangphongtro.DataSource = load.ToList();
            }
        }
        private void phongtro_Load(object sender, EventArgs e)
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
            disable_all(true, true, bFind, tbmaphong);
            savebutton = "find";
            loadbang(tbmaphong.Text);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ask_form temp = new ask_form();
            temp.ShowDialog();
            if (temp.result == true)
            {
                try
                {
                    var tempq = from temp2 in qlt.PhongTro
                                where (temp2.MaPhong == tbmaphong.Text)
                                select temp2;
                    qlt.PhongTro.Remove(tempq.First());
                    qlt.SaveChanges();
                }
                catch
                {
                    //lỗi khóa phụ
                    MessageBox.Show("Phòng này đang được sử dụng, nếu bạn muốn xóa bỏ nó hãy hủy hợp đồng của phòng này!");
                }
                loadbang();
            }
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
                        var tempq = from temp2 in qlt.PhongTro
                                    where (temp2.MaPhong == tbmaphong.Text)
                                    select temp2;
                        PhongTro itemuse = tempq.First();
                        itemuse.MaPhong = tbmaphong.Text;
                        itemuse.TenPhong = tbtenphong.Text;
                        itemuse.DienTich = float.Parse(tbdientich.Text);
                        itemuse.GiaTienPhong = int.Parse(tbgiatien.Text);
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
                        linq_phongtro_val.MaPhong = tbmaphong.Text;
                        linq_phongtro_val.TenPhong = tbtenphong.Text;
                        linq_phongtro_val.DienTich = float.Parse(tbdientich.Text);
                        linq_phongtro_val.GiaTienPhong = int.Parse(tbgiatien.Text);
                        qlt.PhongTro.Add(linq_phongtro_val);
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