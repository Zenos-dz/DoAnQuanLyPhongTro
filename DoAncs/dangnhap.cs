﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doancs
{
    public partial class dangnhap : Form
    {
        Database db = new Database();
        public dangnhap()
        {
            InitializeComponent();
            pass.PasswordChar = '\u058E';
        }
        
        //for login
        protected void checklogin()
        {
            //code check login
            string query = $"SELECT username FROM NguoiDung WHERE username='{username.Text.ToLower()}' AND password='{pass.Text}'";
            DataTable reader = db.getData(query);
            reader.Rows.Add();
            try
            {
                if (reader.Rows[0].IsNull(0) == false)
                {
                    this.Hide();
                    username.Text = "";
                    pass.Text = "";
                    Main main = new Main(ref db,"");
                    main.ShowDialog();
                    this.Show();
                }
                else 
                {
                    query = $"SELECT MaNguoiThue FROM NguoiThueTro WHERE MaNguoiThue='{username.Text}' AND password='{pass.Text}'";
                    reader = db.getData(query);
                    reader.Rows.Add();
                    if (reader.Rows[0].IsNull(0) == false)
                    {
                        this.Hide();
                        Main main = new Main(ref db, username.Text);
                        username.Text = "";
                        pass.Text = "";
                        main.ShowDialog();
                        this.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("có lỗi trong quá trình vận hành ứng dụng, vui lòng liên hệ lập trình viên!" + ex.Message);
                this.Show();
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            checklogin();
        }
        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checklogin();
        }
        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checklogin();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
